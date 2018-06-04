using System;
using System.IO;
using System.Threading;

namespace ProjetoBenner4
{
    public class MicroondasController
    {
        //Controles de execução
        ManualResetEvent _desligar = new ManualResetEvent(false);
        ManualResetEvent _pausar = new ManualResetEvent(true);

        //Delegate que irá executar o callback a cada interação da Thread
        private DelegateFornoAssando _callbackFornoAssando;
        private DelegateAvisoUsuario _callbackAvisoUsuario;
        
        /// <summary>
        /// define como deve ser o callback do resultado
        /// </summary>
        /// <param name="Prato">Callback</param>
        public delegate void DelegateFornoAssando(string Prato);

        /// <summary>
        /// define como deve ser o callback de avisos
        /// </summary>
        /// <param name="Aviso">Callback</param>
        public delegate void DelegateAvisoUsuario(string Aviso);


        //Thread que ira executar a classe business
        Thread _t;
        Microondas _microondas;

        private int _tempo;
        private string _prato;
        private int _potencia;
        private Programa _programa;
        private static string _arquivo;      // serve para salvar no arquivo

        /// <summary>
        /// cozinha um prato com a informações fornecidas
        /// </summary>
        /// <param name="Programa">programa de cozimento</param>
        /// <param name="Prato">prato a ser cozido</param>
        /// <param name="Tempo">tempo de aquecimento</param>
        /// <param name="Potencia">potencia do microondas</param>
        /// <param name="Arquivo">arquivo a ser cozido</param>
        /// <param name="CallbackFornoAssando">metodo a ser chamado durante as atualizações de status</param>
        /// <param name="CallbackAvisoUsuario">metodo a ser chamado quando houver um aviso para o usuario</param>
        public void Cozinhar(Programa Programa, string Prato, int Tempo, int Potencia, string Arquivo , DelegateFornoAssando CallbackFornoAssando, DelegateAvisoUsuario CallbackAvisoUsuario)
        {
            //Atribui o delegate de callback
            _callbackFornoAssando = CallbackFornoAssando;

            //Atribui o delegate de avisos
            _callbackAvisoUsuario = CallbackAvisoUsuario;

            _arquivo = Arquivo;
            _tempo = Tempo;
            _prato = Prato;
            _potencia = Potencia;
            _programa = Programa;

            // salva apenas se tiver informado o arquivo
            if (!String.IsNullOrEmpty(_arquivo))
            {
                //abre e le o arquivo
                _prato = File.ReadAllText(_arquivo);
            }

            // verifica compatibilidade de pratos
            if (_programa.Verificar && _programa.Nome.ToUpper() != _prato.ToUpper())
            {
                _callbackAvisoUsuario("Prato incompativel com programa escolhido.");
                return;
            }

            try
            {
                // cria novo microondas
                _microondas = new Microondas(_prato, _tempo, _potencia);
                _tempo = _microondas.Tempo;

                //Liga ele dentro da Thread
                _t = new Thread(Assar);
                _t.Start();

                _callbackAvisoUsuario("Forno assando");
            }
            catch (Exception ex)
            {
                _callbackAvisoUsuario("Erro ao iniciar a controladora do forno: " + ex.Message.ToString());
            }
        }
        
        private void Assar()
        {

            //Assa por um minuto
            for (int i = 0; i < _tempo; i++)
            {
                //Faz a checagem dos controles de execução
                _pausar.WaitOne(Timeout.Infinite);

                if (_desligar.WaitOne(0))
                {
                    _t.Interrupt();
                    //_t.Join();
                    return;
                }

                _microondas.CozinhaUmSegundo(_programa.CharPadrao);
                Thread.Sleep(1000);
                _callbackFornoAssando(_microondas.Prato);
                AtualizaArquivo(_microondas.Prato);
            }

            // atualiza para salvar no arquivo
            _callbackAvisoUsuario("Forno terminou");
        }

        /// <summary>
        /// Escreve atualizações no arquivo enviado
        /// </summary>
        /// <param name="Texto">string a ser escrevida no arquivo</param>
        public static void AtualizaArquivo(string Texto)
        {
            // salva apenas se tiver informado o arquivo
            if (!String.IsNullOrEmpty(_arquivo)){
                //abre e le o arquivo
                string documento = File.ReadAllText(_arquivo);

                // antes do return precisa salvar a string no txt
                File.WriteAllText(_arquivo, Texto);
            }
        }

        /// <summary>
        /// Pausa o processando de assamento do forno
        /// </summary>
        public void Pausar()
        {
            //Muda a propriedade que é checada dentro da execução do forno
            _callbackAvisoUsuario("Solicitando pausa do forno");
            _pausar.Reset();
            _callbackAvisoUsuario("Forno pausado");
        }

        /// <summary>
        /// Reinicia o processo de assando de um forno que foi pausado
        /// </summary>
        public void Retomar()
        {
            //Muda a propriedade que é checada dentro da execução do forno
            _callbackAvisoUsuario("Solicitando retomada do forno");
            _pausar.Set();
            _callbackAvisoUsuario("Forno assando");
        }

        /// <summary>
        /// Para o processo de assando do forno
        /// </summary>
        public void Parar()
        {
            _callbackAvisoUsuario("Solicitando parada do forno");
            //Muda a propriedade que é checada dentro da execução do forno
            _desligar.Set();

            //Em caso do usuário ter parado uma tarefa que estava pausada
            //Dessa forna o fluxo de execução segue até o desligar
            _pausar.Set();

            //Aguarda a execução da Thread terminar
            _callbackAvisoUsuario("Forno parado");
        }
    }
}
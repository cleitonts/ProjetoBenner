using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoBenner4
{
    public partial class Form1 : Form
    {
        // objetos
        private ProgramasController _programasController;
        private MicroondasController _controller;
        private List<Programa> _listaProgramas;

        //Delegate para permitir a a alteração da propriedade do Form
        //quando a Thread do CallBack não for a mesma da Thread em execução
        delegate void settxtResultado(string text);
        delegate void settxtAviso(string text);
        public Form1()
        {
            InitializeComponent();
            _controller = new MicroondasController();
            _programasController = new ProgramasController();
            this.CarregarProgramas();
            txtAviso.Text = "";
        }

        /// <summary>
        /// Faz o reload de programas e atualiza combos e grids
        /// </summary>
        public void CarregarProgramas()
        {
            // instancia a lista de programas
            _listaProgramas = _programasController.CarregarLista();

            // monta select e data grid
            var _bs = new BindingSource();
            _bs.DataSource = _listaProgramas;
            cbLista.DataSource = _bs;
            cbLista.DisplayMember = "Nome";

            dgProgramas.DataSource = _bs;
        }

        /// <summary>
        /// Metodo que atualiza a interface do usuário, mostrando como o prato está
        /// </summary>
        /// <param name="Prato">Situação atual do prato</param>
        public void txtResultadoCallBack(string Prato)
        {
            //Se a Thread que fez a chamada for diferente da Thread que criou o textBoxResult
            //cria um SetTextCallback e chama-o de forma assincrona usando o Invoke
            if (this.txtResultado.InvokeRequired)
            {
                settxtResultado d = new settxtResultado(txtResultadoCallBack);
                this.Invoke(d, new object[] { Prato });
            }
            else
            {
                this.txtResultado.Text = Prato;
            }

        }

        /// <summary>
        /// Metodo que atualiza a interface do usuário, mostrando erros e avisos
        /// </summary>
        /// <param name="Aviso">mensagem</param>
        /// 
        public void txtAvisoCallBack(string Aviso)
        {
            //Se a Thread que fez a chamada for diferente da Thread que criou o labelAvisoUsuario
            //cria um SetLabelAvisoUsuario e chama-o de forma assincrona usando o Invoke
            if (this.txtAviso.InvokeRequired)
            {
                settxtAviso d = new settxtAviso(txtAvisoCallBack);
                this.Invoke(d, new object[] { Aviso });
            }
            else
            {
                this.txtAviso.Text = Aviso;
            }

        }

        private void btnRapido_Click(object sender, EventArgs e)
        {
            // altera a opção selecionada
            var _programa = new Programa("Rapido", "Programa rapido", 30, 8, "R", false);
            cbLista.SelectedIndex = cbLista.FindString("Rapido");

            // clica no botão cozinhar
            btnCozinhar_Click(sender, e);
        }

        private void btnCozinhar_Click(object sender, EventArgs e)
        {
            Programa _programa = ((Programa)cbLista.SelectedItem);
            _controller.Cozinhar(_programa, txtPrato.Text,
                txtTempo.Value.MinutesAndSecondsToInteger(), Convert.ToInt32(txtPotencia.Value),
                txtArquivo.Text, new MicroondasController.DelegateFornoAssando(txtResultadoCallBack),
                new MicroondasController.DelegateAvisoUsuario(txtAvisoCallBack));
        }
        private void cbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPotencia.Value = ((Programa)cbLista.SelectedItem).Potencia;
            lbInstrucao.Text = ((Programa)cbLista.SelectedItem).Instrucao;

            // tratamento do campo tempo
            txtTempo.Value = Convert.ToDateTime("00:00");       // zera o tempo
            int _tempo = ((Programa)cbLista.SelectedItem).Tempo;
            txtTempo.Value = txtTempo.Value.AddSeconds(_tempo);

        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // altera os itens exibidos na grid de acordo com o valor da pesquisa
            var _bs = new BindingSource();
            _bs.DataSource = this._listaProgramas.Where(x => x.Nome.ToUpper().Contains(txtPesquisa.Text.ToUpper()));
            dgProgramas.DataSource = _bs;
        }
        private void btnProgramaNovo_Click(object sender, EventArgs e)
        {
            try
            {
                int _tempo = Convert.ToDateTime(txtProgramaTempo.Value).MinutesAndSecondsToInteger();

                Programa _programa = new Programa(txtProgramaNome.Text, txtProgramaInstrucao.Text, _tempo, 
                    Convert.ToInt32(txtProgramaPotencia.Value), txtProgramaChar.Text, true);

                _programasController.Adicionar(_programa);

                // recarrega programas
                this.CarregarProgramas();
                dgProgramas.Refresh();

                MessageBox.Show("Programa salvo com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // exclui cada linha selecionada do datagrid
            foreach (DataGridViewRow item in dgProgramas.SelectedRows)
            {
                Programa _programaexcluir = (Programa)item.DataBoundItem;
                _programasController.Remover(_programaexcluir);
            }

            _programasController.Salvar();
            this.CarregarProgramas();

            MessageBox.Show("Os programas foram excluidos");

        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            // se o arquivo estiver ok adiciona o path no txt
            if (this.opFile.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = opFile.FileName;
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            _controller.Pausar();
        }

        private void btnRetomar_Click(object sender, EventArgs e)
        {
            _controller.Retomar();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            _controller.Parar();
        }
    }
}

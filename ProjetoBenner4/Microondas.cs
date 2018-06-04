using System;

namespace ProjetoBenner4
{
    /// <summary>
    /// Classe que representa um forno microondas
    /// </summary>
    public class Microondas
    {
        // vars durante o processo de cozimento
        private int tempo;
        private string prato;
        private int potencia = 10;

        /// <summary>
        /// Tempo de cozimento do prato
        /// </summary>
        public int Tempo
        {
            get
            {
                return tempo;
            }
            private set
            {
                // valida tamanho
                if (value > 120 || value < 1)
                {
                    throw new Exception("Tempo não informado ou fora do internvalo (1 - 120)");
                }
                tempo = value;
            }
        }

        /// <summary>
        /// Nome do prato que será aquecido no microondas
        /// </summary>
        public string Prato
        {
            get
            {
                return prato;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Por favor, informe o prato.");
                }
                prato = value;
            }
        }

        /// <summary>
        /// Potencia de aquecimento do prato
        /// </summary>
        public int Potencia
        {
            get
            {
                return potencia;
            }
            set
            {
                // valida tamanho
                if (value > 10 || value < 1)
                {
                    throw new Exception("Potência não informado ou fora do internvalo (1 - 10)");
                }
                potencia = value;
            }
        }

        /// <summary>
        /// Cria um novo microondas
        /// </summary>
        /// <param name="Prato">Nome do prato que será aquecido no microondas</param>
        /// <param name="Tempo">Tempo de cozimento do prato</param>
        /// <param name="Potencia">Potencia de aquecimento do prato</param>
        
        public Microondas(string Prato, int Tempo, int Potencia)
        {
            this.Prato = Prato;
            this.Tempo = Tempo;
            this.Potencia = Potencia;
        }

        /// <summary>
        /// Cozinha o prato com a potencia informada durante um segundo
        /// <param name="CharPadrao">Caracter de aquecimento do prato</param>
        /// </summary>
        public void CozinhaUmSegundo(string CharPadrao)
        {
            for (int i = 0; i < this.Potencia; i++)
            {
                this.Prato += CharPadrao;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetoBenner4
{
    /// <summary>
    /// Classe que define um programa de microondas
    /// </summary>
    [Serializable]
    public class Programa
    {
        /// <summary>
        /// Nome do programa de microondas
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Instrução de uso do programa
        /// </summary>
        public string Instrucao { get; set; }
        /// <summary>
        /// Tempo de cozimento do programa
        /// </summary>
        public int Tempo { get; set; }
        /// <summary>
        /// Potencia de cozimento do programa
        /// </summary>
        public int Potencia { get; set; }
        /// <summary>
        /// caracter padrão que é informado na string de cozimento
        /// </summary>
        public string CharPadrao { get; set; }

        /// <summary>
        /// controla se ira verificar disponibilidade de pratos
        /// </summary>
        public bool Verificar { get; set; }

        /// <summary>
        /// Cria um novo programa
        /// </summary>
        /// <param name="Nome">Nome do programa de microondas</param>
        /// <param name="Instrucao">Instrução de uso do programa</param>
        /// <param name="Tempo">Tempo de cozimento do programa</param>
        /// <param name="Potencia">Potencia de cozimento do programa</param>
        /// <param name="CharPadrao">caracter padrão que é informado na string de cozimento</param>
        /// <param name="VerificaCompatibilidade">controla se ira verificar disponibilidade de pratos</param>
        public Programa(string Nome, string Instrucao, int Tempo, int Potencia, string CharPadrao, bool Verificar)
        {
            this.Nome = Nome;
            this.Instrucao = Instrucao;
            this.Tempo = Tempo;
            this.Potencia = Potencia;
            this.CharPadrao = CharPadrao;
            this.Verificar = Verificar;
        }

        public Programa() { }
    }
}

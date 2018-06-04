using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBenner4
{
    public static class Extencoes
    {
        /// <summary>
        /// Converte minutos e segundos em segundos inteiros
        /// </summary>
        /// <param name="DataHora">minutos e segundos</param>
        /// <returns></returns>
        public static int MinutesAndSecondsToInteger(this DateTime DataHora)
        {
            // converte time para int
            int _tempo = DataHora.Minute * 60;
            _tempo += DataHora.Second;

            return _tempo;
        }
    }
}

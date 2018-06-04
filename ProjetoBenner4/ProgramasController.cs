using System.Collections.Generic;

namespace ProjetoBenner4
{
    /// <summary>
    /// Controla a lista de programas
    /// </summary>
    public class ProgramasController
    {
        private ProgramasDAL _programas;

        public ProgramasController()
        {
            _programas = new ProgramasDAL();
            _programas.Carregar();
        }

        /// <summary>
        /// carrega a lista de programas
        /// </summary>
        /// <returns>retorna uma lista de programas</returns>
        public List<Programa> CarregarLista()
        {
            return this._programas.ListarProgramas();
        }

        /// <summary>
        /// salva os programas no xml
        /// </summary>
        public void Salvar()
        {
            _programas.Salvar();
        }

        /// <summary>
        /// adiciona um novo programa no xml e na lista de programas
        /// </summary>
        /// <param name="Programa">programa a ser adicionado</param>
        public void Adicionar(Programa Programa)
        {
            _programas.Adicionar(Programa);
            _programas.Salvar();
        }

        /// <summary>
        /// exclui um programa da lista de programas
        /// </summary>
        /// <param name="Programa">Programa a ser excluido</param>
        public void Remover(Programa Programa)
        {
            _programas.Remover(Programa);
        }
    }
}

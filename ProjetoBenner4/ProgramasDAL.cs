using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProjetoBenner4
{
    /// <summary>
    /// Gerencia os dados de programas, lendo e escrevendo no arquivo XML
    /// </summary>
    public class ProgramasDAL
    {
        private List<Programa> _programas;
        protected string _path = Path.GetDirectoryName(Application.ExecutablePath);

        public ProgramasDAL()
        {
            _programas = new List<Programa>();

        }

        /// <summary>
        /// adiciona um programa na lista de programas
        /// </summary>
        /// <param name="programa">programa a ser adicionado</param>
        public void Adicionar(Programa programa)
        {
            if (this._programas.Count(c => c.Nome.Equals(programa.Nome)) > 0)
            {
                throw new Exception("Já existe um programa com este nome");
            }
            else
            {
                this._programas.Add(programa);
            }
        }

        /// <summary>
        /// remove um programa da lista de programas
        /// </summary>
        /// <param name="programa">programa a ser removido</param>
        public void Remover(Programa programa)
        {
            this._programas.Remove(programa);
        }

        public List<Programa> ListarProgramas()
        {
            return this._programas;
        }

        /// <summary>
        /// salva a lista atual de programas no xml
        /// </summary>
        public void Salvar()
        {
            // limpa o arquivo
            File.WriteAllText(_path + "\\Programas.xml", string.Empty);

            XmlSerializer ser = new XmlSerializer(typeof(List<Programa>));
            FileStream fs = new FileStream(_path + "\\Programas.xml", FileMode.OpenOrCreate);
            ser.Serialize(fs, this._programas);
            fs.Close();
        }

        /// <summary>
        /// carrega o xml e mapeia os itens como uma lista de programas
        /// </summary>
        public void Carregar()
        {
            // abre o documento e cria o serializer
            XmlSerializer serialize = new XmlSerializer(typeof(List<Programa>));
            FileStream documento;

            try
            {
                documento = new FileStream(_path + "\\Programas.xml", FileMode.OpenOrCreate);
                this._programas = serialize.Deserialize(documento) as List<Programa>;
                documento.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel carregar novo programa. " + ex.Message);
            }
        }
    }
}
using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoBenner4;

namespace ProjetoBennerTeste
{
    [TestClass]
    public class Projeto4
    {
        private Programa _programa = new Programa("Pipoca", "Cozinhar Pipoca", 10, 3, "P", true);

        [TestMethod]
        public void AssarUmSegundo()
        {
            string _prato = "frango";

            Microondas _microondas = new Microondas(_prato, 1, 5);
            _microondas.CozinhaUmSegundo("F");

            _prato = "frangoFFFFF";
            Assert.AreEqual(_prato, _microondas.Prato);
        }
        
        [TestMethod]
        public void AssaPratoTodo()
        {
            string _resultado = null;
            string _aviso = null;

            void txtResultadoCallBack(string Prato)
            {
                _resultado = Prato;
            }
            void txtAvisoCallBack(string Aviso)
            {
                _aviso = Aviso;
            }

            // tada a lista da forma que o combo box espera receber
            MicroondasController _microondasController = new MicroondasController();
            _microondasController.Cozinhar(_programa, "Pipoca", 10, 3, null, 
                new MicroondasController.DelegateFornoAssando(txtResultadoCallBack),
                new MicroondasController.DelegateAvisoUsuario(txtAvisoCallBack));

            string _prato = "PipocaPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP";

            while (_aviso != "Forno terminou") {
                Thread.Sleep(1000);
            }

            Assert.AreEqual(_prato, _resultado);
        }

        [TestMethod]
        public void PratoIncompativel()
        {
            string _resultado = null;
            string _aviso = null;

            void txtResultadoCallBack(string Prato)
            {
                _resultado = Prato;
            }
            void txtAvisoCallBack(string Aviso)
            {
                _aviso = Aviso;
            }

            // tada a lista da forma que o combo box espera receber
            MicroondasController _microondasController = new MicroondasController();
            _microondasController.Cozinhar(_programa, "Chocolate", 10, 3, null,
                new MicroondasController.DelegateFornoAssando(txtResultadoCallBack),
                new MicroondasController.DelegateAvisoUsuario(txtAvisoCallBack));

            Assert.AreEqual("Prato incompativel com programa escolhido.", _aviso);
        }

        [TestMethod]
        public void converterTempo()
        {
            DateTime _data = new DateTime(2018, 06, 03, 21, 1, 30);
            Assert.AreEqual(90, _data.MinutesAndSecondsToInteger());
        }
    }
}

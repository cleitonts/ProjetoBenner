using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjetoBennerTeste
{
    [TestClass]
    public class Projeto1
    {
        [TestMethod]
        public void assarUmSegundo()
        {
            string _prato = "frango";

            ProjetoBenner.Microondas _microondas = new ProjetoBenner.Microondas(_prato, 1, 5);
            _microondas.CozinhaUmSegundo();

            _prato = "frango.....";
            Assert.AreEqual(_prato, _microondas.Prato);
        }

        [TestMethod]
        public void assaPratoTodo()
        {
            string _prato = "frango";

            ProjetoBenner.MicroondasController _microondasControllar = 
                new ProjetoBenner.MicroondasController();
            string _aquecido = _microondasControllar.Start(_prato, 5, 2);

            _prato = "frango..........";
            Assert.AreEqual(_prato, _aquecido);
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoBenner2;

namespace ProjetoBennerTeste
{
    [TestClass]
    public class Projeto2
    {
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
        public void ContaProgramas()
        {
            List<Programa> _programa = Programa.Load();

            int quantProgramas = _programa.Count;
            Assert.AreEqual(7, quantProgramas);
        }

        [TestMethod]
        public void AssaPratoTodo()
        {
            string _prato = "Pipoca";
            List<Programa> _programa = Programa.Load();

            // tada a lista da forma que o combo box espera receber
            MicroondasController _microondasController = new MicroondasController();
            string _aquecido = _microondasController.Start(_prato, _programa.Find(x => x.Nome == "Pipoca"));
            _prato = "PipocaPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP";
            _prato += "PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP";

            Assert.AreEqual(_prato, _aquecido);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PratoIncompativel()
        {
            string _prato = "chocolate";
            List<Programa> _programa = Programa.Load();

            // tada a lista da forma que o combo box espera receber
            MicroondasController _microondasController = new MicroondasController();
            _microondasController.Start(_prato, _programa.Find(x => x.Nome == "Pipoca"));
        }
    }
}

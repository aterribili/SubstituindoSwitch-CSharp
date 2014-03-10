using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubstituindoSwitch;

namespace SubstituindoSwitchTest
{
    [TestClass]
    public class SwitchTest
    {
        [TestMethod]
        public void DeveBuscarRegiaoSul()
        {
            Assert.AreEqual("Sul", new Switch().BuscaRegiao(2));
        }

        [TestMethod]
        public void DeveBuscarRegiaoNorte()
        {
            Assert.AreEqual("Norte", new Switch().BuscaRegiao(3));
        }

        [TestMethod]
        public void DeveBuscarRegiaoLeste()
        {
            Assert.AreEqual("Leste", new Switch().BuscaRegiao(5));
        }

        [TestMethod]
        public void DeveBuscarRegiaoOeste()
        {
            Assert.AreEqual("Oeste", new Switch().BuscaRegiao(7));
        }
    }
}

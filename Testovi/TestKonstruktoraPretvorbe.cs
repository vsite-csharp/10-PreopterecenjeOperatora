using System;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.PreopterećenjeOperatora.Testovi
{
    [TestClass]
    public class TestKonstruktoraPretvorbe
    {
        [TestMethod]
        public void Racionalni_KonstruktorPretvorbeZaDvadesetPetDajeRacionalniBrojSBrojnikom25Nazivnikom1()
        {
            ConstructorInfo constructorInfo = typeof(Racionalni).GetConstructors().FirstOrDefault(ci => ci.GetParameters().Count() == 1 && ci.GetParameters().ElementAt(0).ParameterType == typeof(double));
            Assert.IsNotNull(constructorInfo);
            Racionalni rac = new Racionalni(25);
            Assert.AreEqual(25, rac.Brojnik);
            Assert.AreEqual(1, rac.Nazivnik);
        }

        [TestMethod]
        public void Racionalni_KonstruktorPretvorbeZaDvadesetPetStotninaDajeRacionalniBrojSBrojnikom1Nazivnikom4()
        {
            ConstructorInfo constructorInfo = typeof(Racionalni).GetConstructors().FirstOrDefault(ci => ci.GetParameters().Count() == 1 && ci.GetParameters().ElementAt(0).ParameterType == typeof(double));
            Assert.IsNotNull(constructorInfo);
            Racionalni rac = (Racionalni)constructorInfo.Invoke(new object[] { 0.25 });
            Assert.AreEqual(1, rac.Brojnik);
            Assert.AreEqual(4, rac.Nazivnik);
        }

        [TestMethod]
        public void Racionalni_KonstruktorPretvorbeZaStodvadesetpettisućinaDajeRacionalniBrojSBrojnikom1Nazivnikom8()
        {
            ConstructorInfo constructorInfo = typeof(Racionalni).GetConstructors().FirstOrDefault(ci => ci.GetParameters().Count() == 1 && ci.GetParameters().ElementAt(0).ParameterType == typeof(double));
            Assert.IsNotNull(constructorInfo);
            Racionalni rac = (Racionalni)constructorInfo.Invoke(new object[] { 0.125 });
            Assert.AreEqual(1, rac.Brojnik);
            Assert.AreEqual(8, rac.Nazivnik);
        }
    }
}

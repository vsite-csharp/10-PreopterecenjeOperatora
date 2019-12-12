using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.PreopterećenjeOperatora.Testovi
{
    [TestClass]
    public class TestImplicitnePretvorbe
    {
        [TestMethod]
        public void Racionalni_ImplicitnaPretvorbaIzJedneDesetineDajeBrojSBrojnikom1Nazivnikom10()
        {
            var staticMethods = typeof(Racionalni).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var opImplicitFromDouble = staticMethods.FirstOrDefault(mi => mi.Name == "op_Implicit" && mi.ReturnType == typeof(Racionalni) && mi.GetParameters().Count() == 1 && mi.GetParameters().ElementAt(0).ParameterType == typeof(double));
            Assert.IsNotNull(opImplicitFromDouble);
            Racionalni rac = (Racionalni)opImplicitFromDouble.Invoke(null, new object[] { 0.1 });
            Assert.AreEqual(1, rac.Brojnik);
            Assert.AreEqual(10, rac.Nazivnik);
        }

        [TestMethod]
        public void Racionalni_ImplicitnaPretvorbaIzDvaDajeBrojSBrojnikom2Nazivnikom1()
        {
            var staticMethods = typeof(Racionalni).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var opImplicitFromLong = staticMethods.FirstOrDefault(mi => mi.Name == "op_Implicit" && mi.ReturnType == typeof(Racionalni) && mi.GetParameters().Count() == 1 && mi.GetParameters().ElementAt(0).ParameterType == typeof(long));
            Assert.IsNotNull(opImplicitFromLong);
            Racionalni rac = (Racionalni)opImplicitFromLong.Invoke(null, new object[] { 2 });
            Assert.AreEqual(2, rac.Brojnik);
            Assert.AreEqual(1, rac.Nazivnik);
        }
    }
}

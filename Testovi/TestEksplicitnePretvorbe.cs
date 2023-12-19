namespace Vsite.CSharp.PreopterećenjeOperatora.Testovi
{
    [TestClass]
    public class TestEksplicitnePretvorbe
    {
        [TestMethod]
        public void Racionalni_EksplicitnaPretvorbaZaDvijeTrećineUDoubleDajeDvijeTrećine()
        {
            var staticMethods = typeof(Racionalni).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var opExplicitToDouble = staticMethods.FirstOrDefault(mi => mi.Name == "op_Explicit" && mi.ReturnType == typeof(double) && mi.GetParameters().Count() == 1 && mi.GetParameters().ElementAt(0).ParameterType == typeof(Racionalni));
            Assert.IsNotNull(opExplicitToDouble);
            Racionalni rac = new Racionalni(2, 3);
            Assert.AreEqual(2.0 / 3.0, opExplicitToDouble!.Invoke(null, new object[] { rac }));
        }

        [TestMethod]
        public void Racionalni_EksplicitnaPretvorbaZaDvijeTrećineULongDaje0()
        {
            var staticMethods = typeof(Racionalni).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var opExplicitToLong = staticMethods.FirstOrDefault(mi => mi.Name == "op_Explicit" && mi.ReturnType == typeof(long) && mi.GetParameters().Count() == 1 && mi.GetParameters().ElementAt(0).ParameterType == typeof(Racionalni));
            Assert.IsNotNull(opExplicitToLong);
            Racionalni rac = new Racionalni(2, 3);
            Assert.AreEqual(2L / 3L, opExplicitToLong!.Invoke(null, new object[] { rac }));
        }
    }
}

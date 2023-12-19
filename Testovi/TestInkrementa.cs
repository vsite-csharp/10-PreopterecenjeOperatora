namespace Vsite.CSharp.PreopterećenjeOperatora.Testovi
{
    [TestClass]
    public class TestInkrementa
    {
        [TestMethod]
        public void StrukturaDatum_PreinkrementUvećavaRezultatIPridruženuVarijablu()
        {
            var staticMethods = typeof(StrukturaDatum).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var opIncrement = staticMethods.FirstOrDefault(mi => mi.Name == "op_Increment" && mi.ReturnType == typeof(StrukturaDatum) && mi.GetParameters().Count() == 1 && mi.GetParameters().ElementAt(0).ParameterType == typeof(StrukturaDatum));
            Assert.IsNotNull(opIncrement);
            StrukturaDatum sd = new StrukturaDatum(2015, 12, 31);
            sd = (StrukturaDatum)opIncrement?.Invoke(null, new object[] { sd })!;
            StrukturaDatum sdPrefix = sd;
            Assert.AreEqual(new StrukturaDatum(2016, 1, 1), sd);
            Assert.AreEqual(new StrukturaDatum(2016, 1, 1), sdPrefix);
        }

        [TestMethod]
        public void StrukturaDatum_PostinkrementUvećavaRezultatAliNeIPridruženuVarijablu()
        {
            var staticMethods = typeof(StrukturaDatum).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var opIncrement = staticMethods.FirstOrDefault(mi => mi.Name == "op_Increment" && mi.ReturnType == typeof(StrukturaDatum) && mi.GetParameters().Count() == 1 && mi.GetParameters().ElementAt(0).ParameterType == typeof(StrukturaDatum));
            Assert.IsNotNull(opIncrement);
            StrukturaDatum sd = new StrukturaDatum(2015, 12, 31);
            StrukturaDatum sdPostfix = sd;
            sd = (StrukturaDatum)opIncrement?.Invoke(null, new object[] { sd })!;
            Assert.AreEqual(new StrukturaDatum(2016, 1, 1), sd);
            Assert.AreEqual(new StrukturaDatum(2015, 12, 31), sdPostfix);
        }

        [TestMethod]
        public void KlasaDatum_PreinkrementUvećavaRezultatIPridruženuVarijablu()
        {
            var staticMethods = typeof(KlasaDatum).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var opIncrement = staticMethods.FirstOrDefault(mi => mi.Name == "op_Increment" && mi.ReturnType == typeof(KlasaDatum) && mi.GetParameters().Count() == 1 && mi.GetParameters().ElementAt(0).ParameterType == typeof(KlasaDatum));
            Assert.IsNotNull(opIncrement);
            KlasaDatum kd = new KlasaDatum(2016, 2, 28);
            KlasaDatum kd2 = (KlasaDatum)opIncrement?.Invoke(null, new object[] { kd })!;
            Assert.AreEqual(new KlasaDatum(2016, 2, 28), kd);
            Assert.AreEqual(new KlasaDatum(2016, 2, 29), kd2);
        }

        [TestMethod]
        public void KlasaDatum_PostinkrementUvećavaRezultatIPridruženuVarijablu()
        {
            var staticMethods = typeof(KlasaDatum).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var opIncrement = staticMethods.FirstOrDefault(mi => mi.Name == "op_Increment" && mi.ReturnType == typeof(KlasaDatum) && mi.GetParameters().Count() == 1 && mi.GetParameters().ElementAt(0).ParameterType == typeof(KlasaDatum));
            Assert.IsNotNull(opIncrement);
            KlasaDatum kd = new KlasaDatum(2016, 2, 29);
            KlasaDatum kd2 = (KlasaDatum)opIncrement?.Invoke(null, new object[] { kd })!;
            Assert.AreEqual(new KlasaDatum(2016, 2, 29), kd);
            Assert.AreEqual(new KlasaDatum(2016, 3, 1), kd2);
        }
    }
}

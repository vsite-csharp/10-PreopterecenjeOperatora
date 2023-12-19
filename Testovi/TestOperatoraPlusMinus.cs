namespace Vsite.CSharp.PreopterećenjeOperatora.Testovi
{
    [TestClass]
    public class TestOperatoraPlusMinus
    {
        [TestMethod]
        public void KompleksniBroj_BinarniOperatorPlusDajeZbrojDvaKompleksnaBroja()
        {
            KompleksniBroj kb1 = new KompleksniBroj(1, 2);
            KompleksniBroj kb2 = new KompleksniBroj(3, 5);
            Assert.AreEqual(new KompleksniBroj(4, 7), kb1 + kb2);
        }

        [TestMethod]
        public void KompleksniBroj_BinarniOperatorMinusDajeRazlikuDvaKompleksnaBroja()
        {

            var staticMethods = typeof(KompleksniBroj).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var opSubtraction = staticMethods.FirstOrDefault(mi => mi.Name == "op_Subtraction" && mi.ReturnType == typeof(KompleksniBroj) && mi.GetParameters().Count() == 2 && mi.GetParameters().ElementAt(0).ParameterType == typeof(KompleksniBroj) && mi.GetParameters().ElementAt(1).ParameterType == typeof(KompleksniBroj));
            Assert.IsNotNull(opSubtraction);

            KompleksniBroj kb1 = new KompleksniBroj(1, 2);
            KompleksniBroj kb2 = new KompleksniBroj(3, 5);
            KompleksniBroj? razlika = (KompleksniBroj?)opSubtraction?.Invoke(null, new object[] { kb1, kb2 })!;
            Assert.AreEqual(new KompleksniBroj(-2, -3), razlika);
        }

        [TestMethod]
        public void KompleksniBroj_UnarniOperatorMinusVraćaKompleksniBrojSPromijenenimPredznacima()
        {
            var staticMethods = typeof(KompleksniBroj).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var opNegation = staticMethods.FirstOrDefault(mi => mi.Name == "op_UnaryNegation" && mi.ReturnType == typeof(KompleksniBroj) && mi.GetParameters().Count() == 1 && mi.GetParameters().ElementAt(0).ParameterType == typeof(KompleksniBroj));
            Assert.IsNotNull(opNegation);
            KompleksniBroj kb = new KompleksniBroj(1, 2);
            KompleksniBroj negacija = (KompleksniBroj)opNegation?.Invoke(null, new object[] { kb })!;
            Assert.AreEqual(new KompleksniBroj(-1, -2), negacija);
        }
    }
}

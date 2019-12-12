using System;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    struct KompleksniBroj
    {
        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBroj(double realniDio, double imaginarniDio)
        {
            RealniDio = realniDio;
            ImaginarniDio = imaginarniDio;
        }

        public override string ToString()
        {
            if (ImaginarniDio == 0)
                return RealniDio.ToString();
            if (RealniDio == 0)
                return PrikazImaginarnog();
            if (ImaginarniDio < 0)
                return string.Format("{0}{1}", RealniDio, PrikazImaginarnog());
            return string.Format("{0}+{1}", RealniDio, PrikazImaginarnog());
        }

        private string PrikazImaginarnog()
        {
            if (ImaginarniDio == 1)
                return "i";
            if (ImaginarniDio == -1)
                return "-i";
            return string.Format("{0}i", ImaginarniDio);
        }

        public static KompleksniBroj operator +(KompleksniBroj br1, KompleksniBroj br2)
        {
            return new KompleksniBroj(br1.RealniDio + br2.RealniDio, br1.ImaginarniDio + br2.ImaginarniDio);
        }

        public static KompleksniBroj operator-(KompleksniBroj br1, KompleksniBroj br2)
        {
            return new KompleksniBroj(br1.RealniDio - br2.RealniDio, br1.ImaginarniDio - br2.ImaginarniDio);
        }
        // TODO:003 Implementirati preopterećeni unarni operator - (za promjenu predznaka).
        public static KompleksniBroj operator-(KompleksniBroj number)
        {
            return new KompleksniBroj(-number.RealniDio, -number.ImaginarniDio);
        }
        // TODO:005 Pokrenuti testove (3 testa u grupi "TestOperatoraPlusMinus" moraju proći).

    }

    class OperatoriPlusMinus
    {
        static void Main(string[] args)
        {
            KompleksniBroj kb1 = new KompleksniBroj(1, 2);
            KompleksniBroj kb2 = new KompleksniBroj(0, -4);

            KompleksniBroj zbroj = kb1 + kb2;
            Console.WriteLine("({0}) + ({1}) = {2}", kb1, kb2, zbroj);

            KompleksniBroj razlika = kb2 - kb1;
            Console.WriteLine("({0}) - ({1}) = {2}", kb2, kb1, razlika);

            Console.WriteLine("-[({0}) + ({1})] = {2}", kb1, kb2, -(zbroj));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}

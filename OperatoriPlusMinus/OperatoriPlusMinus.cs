using System;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    struct KompleksniBroj
    {
        public readonly double RealniDio;
        public readonly double ImaginarniDio;

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
                return $"{RealniDio}{PrikazImaginarnog()}";
            return $"{RealniDio}+{PrikazImaginarnog()}";
        }

        private string PrikazImaginarnog()
        {
            if (ImaginarniDio == 1)
                return "i";
            if (ImaginarniDio == -1)
                return "-i";
            return $"{ImaginarniDio}i";
        }

        // TODO:000 implementirati binarni operator + (za zbrajanje dva kompleksna broja), pokrenuti program i provjeriti ispis.
        public static KompleksniBroj operator +(KompleksniBroj br1, KompleksniBroj br2)
        {
            return new KompleksniBroj(br1.RealniDio+br2.RealniDio, br1.ImaginarniDio+br2.ImaginarniDio);
        }

        // Implementirati binarni operator - (za oduzimanje dva kompleksna broja).
        public static KompleksniBroj operator -(KompleksniBroj br1, KompleksniBroj br2)
        {
            return new KompleksniBroj(br1.RealniDio - br2.RealniDio, br1.ImaginarniDio - br2.ImaginarniDio);
        }
        // Implementirati preopterećeni unarni operator - (za promjenu predznaka).
        public static KompleksniBroj operator -(KompleksniBroj br)
        {
            return new KompleksniBroj(-br.RealniDio, -br.ImaginarniDio);
        }
        // Pokrenuti testove (3 testa u grupi "TestOperatoraPlusMinus" moraju proći).

    }

    class OperatoriPlusMinus
    {
        static void Main(string[] args)
        {
            KompleksniBroj kb1 = new KompleksniBroj(1, 2);
            KompleksniBroj kb2 = new KompleksniBroj(0, -4);

            KompleksniBroj zbroj = kb1 + kb2;
            Console.WriteLine("({0}) + ({1}) = {2}", kb1, kb2, zbroj);

            //Naredba koja poziva binarni operator -
            //Otkomentirati donje dvije naredbe, pokrenuti program i provjeriti ispis.
            KompleksniBroj razlika = kb2 - kb1;
            Console.WriteLine($"({kb2}) - ({kb1}) = {razlika}");

            //Naredba koja poziva unarni operator -
            //Otkomentirati donje dvije naredbe, pokrenuti program i provjeriti ispis.
            var negativni = -zbroj;
            Console.WriteLine($"-[({kb1}) + ({kb2})] = {negativni}");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}

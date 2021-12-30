using System;
namespace Vsite.CSharp.PreopterećenjeOperatora
{
    public struct Racionalni
    {
        public Racionalni(long brojnik = 0, long nazivnik = 1)
        {
            Brojnik = brojnik;
            Nazivnik = nazivnik;
        }

        public readonly long Brojnik;

        public readonly long Nazivnik;

        public override string ToString()
        {
            return string.Format("{0} / {1}", Brojnik, Nazivnik);
        }

        // :021 dodati konstruktor pretvorbe (konverzije) koji stvara racionalni broj iz tipa double i u njemu treba samo pozvati metodu Raščlani.
        public Racionalni(double broj)
        {
            var rezultat = Raščlani(broj);
            Brojnik = rezultat.brojnik;
            Nazivnik = rezultat.nazivnik;
        }

        private static (long brojnik, long nazivnik) Raščlani(double broj)
        {
            long brojnik = (long)broj;
            long nazivnik = 1;
            while (brojnik - broj * nazivnik != 0 && nazivnik < 1e10)
            {
                nazivnik *= 10;
                brojnik = (long)(broj * nazivnik);
            }
            long nzv = NajvećiZajedničkiVišekratnik(brojnik, nazivnik);
            return (brojnik / nzv, nazivnik / nzv);
        }

        private static long NajvećiZajedničkiVišekratnik(long prviBroj, long drugiBroj)
        {
            if (prviBroj == drugiBroj)
                return prviBroj;
            if (prviBroj > drugiBroj)
                return SljedećiVišekratnik(drugiBroj, prviBroj);
            return SljedećiVišekratnik(prviBroj, drugiBroj);
        }

        private static long SljedećiVišekratnik(long manjiBroj, long veciBroj)
        {
            long ostatak = veciBroj % manjiBroj;
            if (ostatak == 0)
                return manjiBroj;
            return SljedećiVišekratnik(ostatak, manjiBroj);
        }

        //OperatorImplicitnePretvorbe
        public static implicit operator Racionalni(long broj)
        {
            return new Racionalni(broj);
        }

        public static implicit operator Racionalni(double broj)
        {
            return new Racionalni(broj);
        }

        //OperatorEksplicitnePretvorbe
        public double ToDouble()
        {
            return (double)Brojnik / Nazivnik;
        }

        public static explicit operator double (Racionalni racionalni)
        {
            return racionalni.ToDouble();
        }

        public double ToInt64()
        {
            return Brojnik / Nazivnik;
        }

        public static explicit operator long(Racionalni racionalni)
        {
            return (long)racionalni.ToInt64();
        }
    }
}

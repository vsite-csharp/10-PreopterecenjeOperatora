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

        public long Brojnik
        {
            get;
            private set;
        }

        public long Nazivnik
        {
            get;
            private set;
        }

        public static implicit operator Racionalni(long longToRac)
        {
            Racionalni r = new Racionalni(longToRac);
            return r;
        }

        public static implicit operator Racionalni(double doubleToRac)
        {
            Racionalni r = new Racionalni(doubleToRac);
            return r;
        }

        public double ToDouble()
        {
            return (double)Brojnik / Nazivnik;
        }

        public static explicit operator double(Racionalni rToD)
        {
            return rToD.ToDouble();
        }

        public long ToInt64()
        {
            return (long)Brojnik / Nazivnik;
        }

        public static explicit operator long(Racionalni rToL)
        {
            return rToL.ToInt64();
        }
        public override string ToString()
        {
            return string.Format("{0} / {1}", Brojnik, Nazivnik);
        }

        public Racionalni(double broj):this()
        {
            Raščlani(broj);
        }

        private void Raščlani(double broj)
        {
            long brojnik = (long)broj;
            long nazivnik = 1;
            while (brojnik - broj * nazivnik != 0 && nazivnik < 1e10)
            {
                nazivnik *= 10;
                brojnik = (long)(broj * nazivnik);
            }
            long nzv = NajvećiZajedničkiVišekratnik(brojnik, nazivnik);
            Brojnik = brojnik / nzv;
            Nazivnik = nazivnik / nzv;
        }

        private long NajvećiZajedničkiVišekratnik(long prviBroj, long drugiBroj)
        {
            if (prviBroj == drugiBroj)
                return prviBroj;
            if (prviBroj > drugiBroj)
                return SljedećiVišekratnik(drugiBroj, prviBroj);
            return SljedećiVišekratnik(prviBroj, drugiBroj);
        }

        private long SljedećiVišekratnik(long manjiBroj, long veciBroj)
        {
            long ostatak = veciBroj % manjiBroj;
            if (ostatak == 0)
                return manjiBroj;
            return SljedećiVišekratnik(ostatak, manjiBroj);
        }
    }
}

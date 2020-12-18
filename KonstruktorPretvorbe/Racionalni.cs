﻿using System;

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

        // dodati konstruktor pretvorbe (konverzije) koji stvara racionalni broj iz tipa double i u njemu treba samo pozvati metodu Raščlani.
        public Racionalni(double broj) : this(0, 1)
        {
            Brojnik = Raščlani(broj).brojnik;
            Nazivnik = Raščlani(broj).nazivnik;
        }
        public Racionalni(Racionalni rac)
        {
            Brojnik = rac.Brojnik;
            Nazivnik = rac.Nazivnik;
        }

        //public static implicit operator long(Racionalni rac) => rac.Brojnik;
        public static implicit operator Racionalni(long rac) => new Racionalni(rac);
        //public static implicit operator double(Racionalni rac) => rac.Brojnik;
        public static implicit operator Racionalni(double rac) => new Racionalni(rac);
        public static explicit operator double(Racionalni rac)
        {
            return rac.ToDouble(rac);
        }
        public static explicit operator long(Racionalni rac)
        {
            return rac.ToInt64(rac);
        }

        public double ToDouble(Racionalni rac)
        {
            double rez = (double)rac.Brojnik / (double)rac.Nazivnik;
            return rez;
        }
        public long ToInt64(Racionalni rac)
        {
            long rez = rac.Brojnik / rac.Nazivnik;
            return rez;
        }

        private (long brojnik, long nazivnik) Raščlani(double broj)
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

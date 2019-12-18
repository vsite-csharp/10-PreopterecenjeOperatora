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

        public static implicit operator Racionalni(long longToRational) => new Racionalni(longToRational);
        public static implicit operator Racionalni(double doubleToRational) => new Racionalni(doubleToRational);
        public double ToDouble => (double)Brojnik / Nazivnik;
        public static explicit operator double(Racionalni r) => r.ToDouble;
        public long ToInt64 => (long)Brojnik / Nazivnik;
        public static explicit operator long(Racionalni r) => r.ToInt64;

        public override string ToString()
        {
            return string.Format("{0} / {1}", Brojnik, Nazivnik);
        }

        // TODO:021 dodati konstruktor pretvorbe (konverzije) koji stvara racionalni broj iz tipa double i u njemu treba samo pozvati metodu Raščlani.
        public Racionalni(double broj) : this()
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

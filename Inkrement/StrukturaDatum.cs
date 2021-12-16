using System;
using System.Runtime.CompilerServices;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    public struct StrukturaDatum
    {
        public StrukturaDatum(int godina, int mjesec, int dan) : this()
        {
            this.godina = godina;
            this.mjesec = mjesec;
            this.dan = dan;
        }

        public int Godina
        {
            get { return godina; }
        }

        public int Mjesec
        {
            get { return mjesec; }
        }

        public int Dan
        {
            get { return dan; }
        }

        private int godina;
        private int mjesec;
        private int dan;

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}", Dan, Mjesec, Godina);
        }

        // TODO:010 Definirati operator ++ koji će objekt tipa StrukturaDatum uvećati za jedan dan, pozivom statičke metode Datum.UvećajDan.
        public static StrukturaDatum operator ++(StrukturaDatum strukturaDatum)
        {
            var godina = strukturaDatum.Godina;
            var mjesec = strukturaDatum.Mjesec;
            var dan = strukturaDatum.Dan;
            Datum.UvećajDan(ref godina, ref mjesec, ref dan);
            return new StrukturaDatum(godina, mjesec, dan);
        }

    }
}

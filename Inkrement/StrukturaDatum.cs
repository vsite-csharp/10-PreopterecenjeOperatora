using System;

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

        public static StrukturaDatum operator ++(StrukturaDatum S)
        {
            Datum.UvećajDan(ref S.dan, ref S.mjesec, ref S.godina);
            return S;
        }

    }
}

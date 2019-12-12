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

        public static StrukturaDatum operator++(StrukturaDatum date)
        {
            Datum.UvećajDan(ref date.dan, ref date.mjesec, ref date.godina);
            return date;
        }

    }
}

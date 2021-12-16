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

        // 010 Definirati operator ++ koji će objekt tipa StrukturaDatum uvećati za jedan dan, pozivom statičke metode Datum.UvećajDan.
        public static StrukturaDatum operator ++(StrukturaDatum dat)
        {
            (int god, int mon, int day) = Datum.UvećajDan(dat.godina, dat.mjesec, dat.dan);
            return new StrukturaDatum(god, mon, day);
            /*DateTime dt = new DateTime(dat.godina, dat.mjesec, dat.dan);
            dt.AddDays(1);
            return new StrukturaDatum(dt.Year, dt.Month, dt.Day);*/
        }

    }
}

using System;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    public class KlasaDatum
    {
        public KlasaDatum(int godina, int mjesec, int dan)
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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            KlasaDatum drugi = (KlasaDatum)obj;
            if (drugi.Godina != Godina)
                return false;
            if (drugi.Mjesec != Mjesec)
                return false;
            return drugi.Dan == Dan;
        }

        public override int GetHashCode()
        {
            return Godina ^ Mjesec ^ Dan;
        }

        // TODO:013 definirati operator ++ koji će objekt tipa KlasaDatum uvećati za jedan dan, pozivom statičke metode Datum.UvećajDan.
        public static KlasaDatum operator ++(KlasaDatum datum)
        {
            KlasaDatum noviDatum = new KlasaDatum(datum.godina, datum.mjesec, datum.dan);
            Datum.UvećajDan(ref noviDatum.dan, ref noviDatum.mjesec, ref noviDatum.godina);
            return datum;
        }

    }
}

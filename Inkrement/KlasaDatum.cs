namespace Vsite.CSharp.PreopterećenjeOperatora
{
    public class KlasaDatum : IEquatable<KlasaDatum>
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
            return $"{Dan}.{Mjesec}.{Godina}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as KlasaDatum);
        }
        public bool Equals(KlasaDatum? other)
        {
            if (other == null)
            {
                return false;
            }
            if (other.GetType() != GetType())
            {
                return false;
            }
            if (other.Godina != Godina)
            {
                return false;
            }
            if (other.Mjesec != Mjesec)
            {
                return false;
            }
            return other.Dan == Dan;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Godina, Mjesec, Dan);
        }

        // :013 definirati operator ++ koji će objekt tipa KlasaDatum uvećati za jedan dan, pozivom statičke metode Datum.UvećajDan.


        public static KlasaDatum operator++(KlasaDatum datum)
		{
			(int godina, int mjesec, int dan) = Datum.UvećajDan(datum.Godina, datum.Mjesec, datum.Dan);

            return new KlasaDatum(godina,mjesec, dan);
		}


	}
}

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    static class Datum
    {
        public static bool JeLiPrestupnaGodina(int godina)
        {
            if (godina % 400 == 0)
                return true;
            if (godina % 100 == 0)
                return false;
            return godina % 4 == 0;
        }

        public static int BrojDanaUMjesecu(int godina, int mjesec)
        {
            switch (mjesec)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return JeLiPrestupnaGodina(godina) ? 29 : 28;
                default:
                    throw new ArgumentOutOfRangeException("mjesec");
            }
        }

        // Metoda vraća n-torku (tuple) koja se sastoji od dva broja.
        // Za to treba biti dostupna struktura System.ValuTuple koja dolazi s .NET 4.7 i .NET Core,
        // dok za starije verzije treba instalirati NuGet paket System.ValueTuple.
        public static (int godina, int mjesec) UvećajMjesec(int godina, int mjesec)
        {
            mjesec++;
            if (mjesec > 12)
            {
                mjesec = 1;
                ++godina;
            }
            return (godina, mjesec);

        }

        // Metoda vraća n-torku (tuple) koja se sastoji od tri broja:
        public static (int godina, int mjesec, int dan) UvećajDan(int godina, int mjesec, int dan)
        {
            dan++;
            if (dan > BrojDanaUMjesecu(godina, mjesec))
            {
                dan = 1;
                (godina, mjesec) = UvećajMjesec(godina, mjesec);
            }
            return (godina, mjesec, dan);
        }
    }
}

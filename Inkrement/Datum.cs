using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static void UvećajMjesec(ref int godina, ref int mjesec)
        {
            mjesec++;
            if (mjesec <= 12)
                return;
            mjesec = 1;
            ++godina;
        }

        public static void UvećajDan(ref int godina, ref int mjesec, ref int dan)
        {
            dan++;
            if (dan <= BrojDanaUMjesecu(godina, mjesec))
                return;
            dan = 1;
            UvećajMjesec(ref godina, ref mjesec);
        }
    }
}

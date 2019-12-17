using System;
using System.Diagnostics;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    // TODO:030 U strukturu Racionalni iz prethodnog projekta dodati operator implicitne konverzije iz long u Racionalni.

    // TODO:032 U strukturu Racionalni iz prethodnog projekta dodati operator implicitne konverzije iz double u Racionalni.

    class OperatorImplicitnePretvorbe
    {
        static void Main(string[] args)
        {
            try
            {
                Racionalni rac = new Racionalni();
                // TODO:031 Otkomentirati donje naredbe i provjeriti ispis.
                // koristi implicitnu pretvorbu iz int
                rac = 2;
                Debug.Assert(rac.ToString() == "2 / 1");
                Console.WriteLine(rac);

                // TODO:033 Otkomentirati donje naredbe i provjeriti ispis.
                // koristi implicitnu pretvorbu iz double
                rac = 0.1;
                Debug.Assert(rac.ToString() == "1 / 10");
                Console.WriteLine(rac);

                //TODO:034 Pokrenuti i provjeriti testove (2 testa iz grupe "TestImplicitnePretvorbe" moraju proći).
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}


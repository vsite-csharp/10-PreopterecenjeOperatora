using System;
using System.Diagnostics;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    // U strukturu Racionalni iz prethodnog projekta dodati operator implicitne pretvorbe iz long u Racionalni.

    // U strukturu Racionalni iz prethodnog projekta dodati operator implicitne pretvorbe iz double u Racionalni.

    class OperatorImplicitnePretvorbe
    {
        static void Main(string[] args)
        {
            try
            {
                Racionalni rac = new Racionalni();
                // Otkomentirati donje naredbe, staviti breakpointe u konstruktore implicitne pretvorbe, pokrenuti program i provjeriti ispis.
                rac = 2;
                Debug.Assert(rac.ToString() == "2 / 1");
                Console.WriteLine(rac);

                // Otkomentirati donje naredbe, pokrenuti program i provjeriti ispis.
                rac = 0.1;
                Debug.Assert(rac.ToString() == "1 / 10");
                Console.WriteLine(rac);

                // Pokrenuti i provjeriti testove (2 testa iz grupe "TestImplicitnePretvorbe" moraju proći).
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

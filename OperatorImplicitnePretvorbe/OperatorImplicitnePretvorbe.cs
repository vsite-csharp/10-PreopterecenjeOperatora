using System;
using System.Diagnostics;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    // :030 U strukturu Racionalni iz prethodnog projekta dodati operator implicitne pretvorbe iz long u Racionalni.

    // :032 U strukturu Racionalni iz prethodnog projekta dodati operator implicitne pretvorbe iz double u Racionalni.

    class OperatorImplicitnePretvorbe
    {
        static void Main(string[] args)
        {
            try
            {
                //Racionalni rac = new Racionalni();
                // :031 Otkomentirati donje naredbe, staviti breakpointe u konstruktore implicitne pretvorbe, pokrenuti program i provjeriti ispis.
                Racionalni rac = 2;
                Debug.Assert(rac.ToString() == "2 / 1");
                Console.WriteLine(rac);

                // :033 Otkomentirati donje naredbe, pokrenuti program i provjeriti ispis.
                rac = 0.1;
                Debug.Assert(rac.ToString() == "1 / 10");
                Console.WriteLine(rac);

                //:034 Pokrenuti i provjeriti testove (2 testa iz grupe "TestImplicitnePretvorbe" moraju proći).
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

﻿using System.Diagnostics;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    // TODO:030 U strukturu Racionalni iz prethodnog projekta dodati operator implicitne pretvorbe iz long u Racionalni.

    // TODO:032 U strukturu Racionalni iz prethodnog projekta dodati operator implicitne pretvorbe iz double u Racionalni.

    static class OperatorImplicitnePretvorbe
    {
        static void Main()
        {
            try
            {
                Racionalni rac = new Racionalni();
                // TODO:031 Otkomentirati donje naredbe, staviti breakpointe u konstruktore implicitne pretvorbe, pokrenuti program i provjeriti ispis.
                //rac = 2;
                //Debug.Assert(rac.ToString() == "2 / 1");
                Console.WriteLine(rac);

                // TODO:033 Otkomentirati donje naredbe, pokrenuti program i provjeriti ispis.
                //rac = 0.1;
                //Debug.Assert(rac.ToString() == "1 / 10");
                Console.WriteLine(rac);

                //TODO:034 Pokrenuti i provjeriti testove (2 testa iz grupe "TestImplicitnePretvorbe" moraju proći).
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("GOTOVO!!!");
        }
    }
}

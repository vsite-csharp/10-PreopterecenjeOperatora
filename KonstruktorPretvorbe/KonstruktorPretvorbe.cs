﻿using System.Diagnostics;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    static class Program
    {
        static void Main()
        {
            try
            {
                // TODO:020 Provjeriti konstruktor koji će donja naredba pozvati, pokrenuti program i provjeriti ispis.
                Racionalni rac = new Racionalni(25);
                Debug.Assert(rac.ToString() == "25 / 1");
                Console.WriteLine(rac);

                // TODO:022 Provjeriti koji konstruktor će donja naredba pozvati, otkomentirati naredbu te pokrenuti program i provjeriti ispis.
                //rac = new Racionalni(0.25);
                //Debug.Assert(rac.ToString() == "1 / 4");
                Console.WriteLine(rac);

                // TODO:023 Provjeriti koji konstruktor će donja naredba pozvati, otkomentirati naredbu te pokrenuti program i provjeriti ispis.
                //rac = new Racionalni(0.125F);
                //Debug.Assert(rac.ToString() == "1 / 8");
                Console.WriteLine(rac);

                // TODO:024 Pokrenuti i provjeriti testove (3 testa iz grupe "TestKonstruktoraPretvorbe" moraju proći).
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("GOTOVO!!!");
        }
    }
}

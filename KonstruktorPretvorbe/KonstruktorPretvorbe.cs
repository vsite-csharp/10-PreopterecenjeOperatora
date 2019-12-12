using System;
using System.Diagnostics;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Provjeriti konstruktor koji će donja naredba pozvati, pokrenuti program i provjeriti ispis.
                Racionalni rac = new Racionalni(25);
                Debug.Assert(rac.ToString() == "25 / 1");
                Console.WriteLine(rac);

                // Provjeriti koji konstruktor će donja naredba pozvati, otkomentirati naredbu te pokrenuti program i provjeriti ispis.
                rac = new Racionalni(0.25);
                Debug.Assert(rac.ToString() == "1 / 4");
                Console.WriteLine(rac);

                // Provjeriti koji konstruktor će donja naredba pozvati, otkomentirati naredbu te pokrenuti program i provjeriti ispis.
                // Naredba koja poziva konstruktor pretvorbe iz double
                rac = new Racionalni(0.125F);
                Debug.Assert(rac.ToString() == "1 / 8");
                Console.WriteLine(rac); 

                // Pokrenuti i provjeriti testove (3 testa iz grupe "TestKonstruktoraPretvorbe" moraju proći).
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
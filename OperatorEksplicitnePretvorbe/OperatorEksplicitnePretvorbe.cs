using System;
using System.Diagnostics;

namespace Vsite.CSharp.PreopterećenjeOperatora
{

    // U strukturi Racionalni iz projekta KonstruktoriPretvorbe definirati javnu (public) metodu pretvorbe ToDouble() koja će racionalni broj pretvoriti u double i to vratiti kao rezultat.


    // U strukturi Racionalni iz projekta KonstruktoriPretvorbe definirati operator eksplicitne pretvorbe u double (koji poziva gornju metodu ToDouble).


    // U strukturi Racionalni iz projekta KonstruktoriPretvorbe definirati javnu (public) metodu pretvorbe ToInt64() koja će racionalni broj pretvoriti u long i to vratiti kao rezultat


    // U strukturi Racionalni iz projekta KonstruktoriPretvorbe definirati operator eksplicitne pretvorbe u long (koji poziva gornju metodu ToInt64)


    class Program
    {
        static void Main(string[] args)
        {
            Racionalni rac = new Racionalni(2, 3);
            // Otkomentirati donje naredbe i provjeriti ispis.
            //eksplicitna pretvorba u double
            double racKaoDouble = (double) rac;
            Console.WriteLine(racKaoDouble);

            // Otkomentirati donje naredbe i provjeriti ispis.
            // eksplicitna pretvorba u int
            long racKaoInt = (long)rac;
            Console.WriteLine(racKaoInt);

            // Pokrenuti i provjeriti testove (2 testa iz grupe "TestEksplicitnePretvorbe" moraju proći).

            Console.WriteLine("GOTOVO!!!!");
            Console.ReadKey();
        }
    }
}

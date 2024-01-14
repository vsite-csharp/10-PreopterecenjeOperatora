namespace Vsite.CSharp.PreopterećenjeOperatora
{

    // :040 U strukturi Racionalni iz projekta KonstruktoriPretvorbe definirati javnu (public) metodu pretvorbe ToDouble() koja će racionalni broj pretvoriti u double i to vratiti kao rezultat.


    // :041 U strukturi Racionalni iz projekta KonstruktoriPretvorbe definirati operator eksplicitne pretvorbe u double (koji poziva gornju metodu ToDouble).


    // :043 U strukturi Racionalni iz projekta KonstruktoriPretvorbe definirati javnu (public) metodu pretvorbe ToInt64() koja će racionalni broj pretvoriti u long i to vratiti kao rezultat


    // :044 U strukturi Racionalni iz projekta KonstruktoriPretvorbe definirati operator eksplicitne pretvorbe u long (koji poziva gornju metodu ToInt64)


    static class Program
    {
        static void Main()
        {
            Racionalni rac = new Racionalni(2, 3);
            // :042 Otkomentirati donje naredbe i provjeriti ispis.
            double racKaoDouble = (double)rac;
            Console.WriteLine(racKaoDouble);

            // :045 Otkomentirati donje naredbe i provjeriti ispis.
            long racKaoInt = (long)rac;
            Console.WriteLine(racKaoInt);

            // :046 Pokrenuti i provjeriti testove (2 testa iz grupe "TestEksplicitnePretvorbe" moraju proći).

            Console.WriteLine("GOTOVO!!!!");
        }
    }
}

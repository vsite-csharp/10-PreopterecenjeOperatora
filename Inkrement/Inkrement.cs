using System;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StrukturaDatum:");

            StrukturaDatum sd = new StrukturaDatum(2015, 12, 31);

            Console.WriteLine($"Početni datum: {sd}");

            // Otkomentirati donje naredbe koje koriste prefiksni operator ++ pokrenuti program te provjeriti ispis.
            Console.WriteLine("Pre-inkrement:");
            StrukturaDatum sdPre = ++sd;
            Console.WriteLine($"Original: {sd}");
            Console.WriteLine($"Pre:      {sdPre}");

            // Otkomentirati donje naredbe koje koriste postfiksni operator ++i pokrenuti program te provjeriti ispis.
            Console.WriteLine("post-inkrement:");
            StrukturaDatum sdPost = sd++;
            Console.WriteLine($"original: {sd}");
            Console.WriteLine($"post:     {sdPost}");
            Console.WriteLine($"pre:      {sdPre}");

            Console.WriteLine("KlasaDatum:");

            KlasaDatum kd = new KlasaDatum(2016, 2, 28);

            Console.WriteLine($"Početni datum: {kd}");

            // Otkomentirati donje naredbe koje koriste prefiksni operator ++ pokrenuti program te provjeriti ispis.
            Console.WriteLine("pre-inkrement:");
            KlasaDatum kdpre = ++kd;
            Console.WriteLine($"original: {kd}");
            Console.WriteLine($"pre:      {kdpre}");

            // Otkomentirati donje naredbe koje koriste postfiksni operator ++ pokrenuti program te provjeriti ispis.
            Console.WriteLine("post-inkrement:");
            KlasaDatum kdpost = kd++;
            Console.WriteLine($"original: {kd}");
            Console.WriteLine($"post:     {kdpost}");
            Console.WriteLine($"pre:      {kdpre}");

            // TODO:015 Pokrenuti i provjeriti testove (4 testa iz grupe "TestInkrementa" moraju proći).

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}

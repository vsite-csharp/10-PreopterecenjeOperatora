﻿namespace Vsite.CSharp.PreopterećenjeOperatora
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("StrukturaDatum:");

            StrukturaDatum sd = new StrukturaDatum(2015, 12, 31);

            Console.WriteLine($"Početni datum: {sd}");

            // TODO:011 Otkomentirati donje naredbe koje koriste prefiksni operator ++ pokrenuti program te provjeriti ispis.
            //Console.WriteLine("Pre-inkrement:");
            //StrukturaDatum sdPre = ++sd;
            //Console.WriteLine($"Original: {sd}");
            //Console.WriteLine($"Pre:      {sdPre}");

            // TODO:012 Otkomentirati donje naredbe koje koriste postfiksni operator ++i pokrenuti program te provjeriti ispis.
            //Console.WriteLine("Post-inkrement:");
            //StrukturaDatum sdPost = sd++;
            //Console.WriteLine($"Original: {sd}");
            //Console.WriteLine($"Post:     {sdPost}");
            //Console.WriteLine($"Pre:      {sdPre}");

            Console.WriteLine("KlasaDatum:");

            KlasaDatum kd = new KlasaDatum(2016, 2, 28);

            Console.WriteLine($"Početni datum: {kd}");

            // TODO:014 Otkomentirati donje naredbe koje koriste prefiksni operator ++ pokrenuti program te provjeriti ispis.
            //Console.WriteLine("Pre-inkrement:");
            //KlasaDatum kdPre = ++kd;
            //Console.WriteLine($"Original: {kd}");
            //Console.WriteLine($"Pre:      {kdPre}");

            // TODO:015 Otkomentirati donje naredbe koje koriste postfiksni operator ++ pokrenuti program te provjeriti ispis.
            //Console.WriteLine("Post-inkrement:");
            //KlasaDatum kdPost = kd++;
            //Console.WriteLine($"Original: {kd}");
            //Console.WriteLine($"Post:     {kdPost}");
            //Console.WriteLine($"Pre:      {kdPre}");

            // TODO:016 Pokrenuti i provjeriti testove (4 testa iz grupe "TestInkrementa" moraju proći).

            Console.WriteLine("GOTOVO!!!");
        }
    }
}

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

            Console.WriteLine("Pre-inkrement:");
            StrukturaDatum sdPre = ++sd;
            Console.WriteLine($"Original: {sd}");
            Console.WriteLine($"Pre:      {sdPre}");

            Console.WriteLine("Post-inkrement:");
            StrukturaDatum sdPost = sd++;
            Console.WriteLine($"Original: {sd}");
            Console.WriteLine($"Post:     {sdPost}");
            Console.WriteLine($"Pre:      {sdPre}");

            Console.WriteLine("KlasaDatum:");

            KlasaDatum kd = new KlasaDatum(2016, 2, 28);

            Console.WriteLine($"Početni datum: {kd}");

            Console.WriteLine("Pre-inkrement:");
            KlasaDatum kdPre = ++kd;
            Console.WriteLine($"Original: {kd}");
            Console.WriteLine($"Pre:      {kdPre}");

            Console.WriteLine("Post-inkrement:");
            KlasaDatum kdPost = kd++;
            Console.WriteLine($"Original: {kd}");
            Console.WriteLine($"Post:     {kdPost}");
            Console.WriteLine($"Pre:      {kdPre}");


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}

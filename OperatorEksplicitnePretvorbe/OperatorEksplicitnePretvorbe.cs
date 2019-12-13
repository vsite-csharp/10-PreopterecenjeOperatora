using System;
using System.Diagnostics;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    class Program
    {
        static void Main(string[] args)
        {
            Racionalni rac = new Racionalni(2, 3);
            // eksplicitna pretvorba u double
            double racKaoDouble = (double)rac;
            Console.WriteLine(racKaoDouble);

            // eksplicitna pretvorba u int
            long racKaoInt = (long)rac;
            Console.WriteLine(racKaoInt);

            Console.WriteLine("GOTOVO!!!!");
            Console.ReadKey();
        }
    }
}

using System;
using System.Diagnostics;

namespace Vsite.CSharp.PreopterećenjeOperatora
{
    class OperatorImplicitnePretvorbe
    {
        static void Main(string[] args)
        {
            try
            {
                Racionalni rac = new Racionalni();
                // koristi implicitnu pretvorbu iz int
                rac = 2;
                Debug.Assert(rac.ToString() == "2 / 1");
                Console.WriteLine(rac);

                // koristi implicitnu pretvorbu iz double
                rac = 0.1;
                Debug.Assert(rac.ToString() == "1 / 10");
                Console.WriteLine(rac);

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

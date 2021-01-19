using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Csdelegates
{
    class Program
    {

        delegate int PeformCalculation(int x, int y);
       

       public static Func<int, int, int> addition = (i, i1) => i+i1 ;
        static void Main(string[] args)
        {



            PeformCalculation operation = new PeformCalculation(addition);




        }

        static int Addition(int x, int y)
        {

            return x + y;

        }

        static int Multiplication(int x, int y)
        {

            return x * y;

        }
    }
}

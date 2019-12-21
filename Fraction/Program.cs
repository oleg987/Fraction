using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction(1, 4);
            Fraction fraction1 = new Fraction(1, 4);

            Console.WriteLine(fraction + 15);

            //Console.WriteLine("Hello" + " world!");
        }
    }
}

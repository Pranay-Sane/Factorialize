using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorialize(5));
            Console.WriteLine(Factorialize(10));
            Console.WriteLine(Factorialize(20));
            Console.WriteLine(Factorialize(0));
        }

        static ulong Factorialize(uint num)
        {
            ulong result = 1;
            while(num > 1)
            {
                result *= num;
                num -= 1;
            }
            return result;
        }
    }
}

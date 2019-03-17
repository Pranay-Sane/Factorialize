using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
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
            if(num == 0)
            {
                return 1;
            }
            return num * Factorialize(num - 1);
        }
    }
}

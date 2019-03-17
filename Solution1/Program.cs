using System;

namespace Solution1
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
            for(uint i = num; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}

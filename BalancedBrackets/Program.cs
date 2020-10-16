using System;

namespace BalancedBracketsNS
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(BalancedBrackets.HasBalancedBrackets(str));
        }
    }
}

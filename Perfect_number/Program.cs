using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int n1, n2;
            Console.WriteLine("Find perfect numbers within a given number of range:\n");
            Console.WriteLine("enter the start number : ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the end number : ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The Perfect numbers within the given range : ");
            for (int x = n1; x <= n2; x++)
            {
                sum = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        sum += y;
                }
                if (sum == x)
                    Console.WriteLine("{0} ", x);
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("ENTER the strating number of range:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER the endinmg number of range:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" THE PRIME NUMBERS between {0} and {1} are : \n", n1, n2);
            for (int num = n1; num <= n2; num++)
            {
                int y = 0;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        y++;
                        break;
                    }

                }
                if (y == 0 && num != 1)
                    Console.WriteLine("{0}", num);
            }
            Console.WriteLine();
        }
    }
}

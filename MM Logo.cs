using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static int k;
        static void Stars(int number)
        {
            for (k = 0; k < number; k++)
                Console.Write("*");
        }
        static void Minuses(int number)
        { 
            for (k = 0; k < number; k++)
                Console.Write("-");
        }
        static void Main(string[] args)
        {
            Console.Write("N=");
            int count = 0, count1 = 0;
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    if (((n + 1) / 2 >= i) && (n > (i * 2)))
                    {
                        Minuses(n - i);
                        Stars(n + (i * 2));
                        Minuses(n - (i * 2));
                        Stars(n + (i * 2));
                        Minuses(n - i);
                    }
                    else if (j == 0)
                    {
                        Minuses(n - i);
                        Stars(n);
                        Minuses(1 + count);
                        Stars((n * 2) - 1 - count);
                        Minuses(1 + count);
                        Stars(n);
                        Minuses(n - i);
                        count += 2;
                    }
                    else
                    {
                        Minuses(n - i);
                        Stars(n);
                        Minuses(1 + count1);
                        Stars((n * 2) - 1 - count1);
                        Minuses(1 + count1);
                        Stars(n);
                        Minuses(n - i);
                        count1 += 2;                      
                    }
                }       
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
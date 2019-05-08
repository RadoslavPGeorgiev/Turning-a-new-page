using System;

namespace ConsoleApp8
{
    class Program
    {
        static int k, count = 0,count2 = 0;
        static void TopHalfOfM(int size, int rows)
        {
            Minuses(size - rows);
            Stars(size + (rows * 2));
            Minuses(size - (rows * 2));
            Stars(size + (rows * 2));
            Minuses(size - rows);
        }
        static void BottomHalfOfM(int size,int rows,int j)
        {
            if (j == 0)
            {
                Minuses(size - rows);
                Stars(size);
                Minuses(1 + count);
                Stars((size * 2) - 1 - count);
                Minuses(1 + count);
                Stars(size);
                Minuses(size - rows);
                count += 2;
            }
            else
            {
                Minuses(size - rows);
                Stars(size);
                Minuses(1 + count2);
                Stars((size * 2) - 1 - count2);
                Minuses(1 + count2);
                Stars(size);
                Minuses(size - rows);
                count2 += 2;
            }
        }
        static void Stars(int numberOfStars)
        {
            for (k = 0; k < numberOfStars; k++)
                Console.Write("*");
        }
        static void Minuses(int numberOfMinuses)
        {
            for (k = 0; k < numberOfMinuses; k++)
                Console.Write("-");
        }
        static void Main(string[] args)
        {
            Console.Write("N=");
            int size = int.Parse(Console.ReadLine());

            for (int rows = 0; rows <= size; rows++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (((size + 1) / 2 >= rows) && (size > (rows * 2)))
                    {
                        TopHalfOfM(size, rows);
                    }
                    else
                    {
                        BottomHalfOfM(size, rows, j);
                    }   
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

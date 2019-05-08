using System;

namespace ConsoleApp8
{
    class Program
    {
        static int k, count = 0,count2 = 0;
        static void TopHalfOfM(int Size, int i)
        {
            Minuses(Size - i);
            Stars(Size + (i * 2));
            Minuses(Size - (i * 2));
            Stars(Size + (i * 2));
            Minuses(Size - i);
        }
        static void BottomHalfOfM(int Size,int i,int j)
        {
            if (j == 0)
            {
                Minuses(Size - i);
                Stars(Size);
                Minuses(1 + count);
                Stars((Size * 2) - 1 - count);
                Minuses(1 + count);
                Stars(Size);
                Minuses(Size - i);
                count += 2;
            }
            else
            {
                Minuses(Size - i);
                Stars(Size);
                Minuses(1 + count2);
                Stars((Size * 2) - 1 - count2);
                Minuses(1 + count2);
                Stars(Size);
                Minuses(Size - i);
                count2 += 2;
            }
        }
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
            int Size = int.Parse(Console.ReadLine());

            for (int i = 0; i <= Size; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (((Size + 1) / 2 >= i) && (Size > (i * 2)))
                    {
                        TopHalfOfM(Size, i);
                    }
                    else
                    {
                        BottomHalfOfM(Size, i, j);
                    }   
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

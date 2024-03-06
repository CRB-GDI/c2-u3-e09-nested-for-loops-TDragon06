

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose the row width");
            int width1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("how many rows");
            int rows1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= rows1; i++)
            {
                for (int j = 1; j <= width1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
                // Above is part one
                // Below is part two

                Console.WriteLine("choose the row width");
                int width2 = Int32.Parse(Console.ReadLine());
                int rows2 = 0;

                Console.WriteLine();
                for (int e = 0; e < width2; e++)
                {
                    for (int k = rows2 + width2; k >= width2; k--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    rows2++;
                }
            }
        }
    }
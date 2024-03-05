namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose the row width");
                int width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("how many rows");
                int rows = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
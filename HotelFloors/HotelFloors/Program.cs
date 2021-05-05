using System;

namespace HotelFloors
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIterations = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfIterations; i++)
            {
                string input = Console.ReadLine();
                int[] data = Array.ConvertAll<string, int>(input.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
                int m = data[0];
                int n = data[1];

                char[,] hotel = new char[m,n];
                for (int x = 0; x < m; x++)
                {
                    input = Console.ReadLine();
                    char[] tmp = input.ToCharArray();
                    for (int y = 0; y < n; y++)
                    {
                        hotel[x, y] = tmp[y];
                    }
                }
                foreach (char item in hotel)
                {
                    Console.WriteLine(item);
                }
                int numberOfPeople = 0;
                double avgNumberOfPeople;
            }
        }
    }
}

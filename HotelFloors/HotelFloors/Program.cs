using System;
using System.Collections.Generic;

namespace HotelFloors
{
    class Coordinate
    {
        public int x, y;
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        public void lookForRooms(int p, int q, bool[] available)
        {

        }
        static void Main(string[] args)
        {
            int numberOfIterations = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfIterations; i++)
            {
                string input = Console.ReadLine();
                int[] data = Array.ConvertAll<string, int>(input.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
                int m = data[0];
                int n = data[1];
                bool inRoom = false;
                bool closedRoom = false;
                int numberOfPeople = 0;
                int numberOfRooms = 0;
                List<Coordinate> currentRoom = new List<Coordinate>();
                double avgNumberOfPeople;

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

                bool[,] visited = new bool[m, n];
                for (int k = 1; k < m-1; k++)
                {
                    for (int j = 1; j < n-1; j++)
                    {
                        visited[m, n] = false;
                    }
                }

                for (int x = 1; x < m-1; x++)
                {
                    for (int y = 1; y < n-1; y++)
                    {
                        if (hotel[x,y]=='*' || hotel[x,y]=='_')
                        {
                            if (!inRoom)
                            {
                                inRoom = true;
                                numberOfRooms++;
                            }
                        }
                    }
                }

                foreach (char item in hotel)
                {
                    if (item == '*')
                    {
                        numberOfPeople++;
                    }
                }
                
            }
        }
    }
}

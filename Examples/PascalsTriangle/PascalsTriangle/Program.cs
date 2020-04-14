using System;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 15;
            int[][] triangle = new int[N][];

            triangle[0] = new int[] {1};

            for (int i = 1; i < N; i++)
            {
                triangle[i] = new int[i + 1];

                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i)
                    {
                        triangle[i][j] = 1;
                    }
                    else
                    {
                        triangle[i][j] = triangle[i - 1][j] + triangle[i - 1][j - 1];
                    }
                }
            }

            PrintTriangle(triangle);

            Console.Read();
        }

        static void PrintTriangle(int[][] triangle)
        {
            foreach(int[] row in triangle)
            {
                foreach(int element in row)
                {
                    Console.Write($" {element,5} ");
                }
                Console.Write('\n');
            }
        }
    }
}

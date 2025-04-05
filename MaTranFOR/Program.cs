using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaTranFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[10, 10];
            Console.Write("Nhap n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap m:");
            int m = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                {
                    Console.Write("A[" + i + "," + j + "]=");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            Console.WriteLine("Ta co ma tran: ");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= m; j++)
                {
                    Console.Write(" " + A[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}

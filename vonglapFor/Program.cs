using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglapFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int[] A = new int[10];
            Console.WriteLine("Nhap n");
            int n = Convert.ToInt32(Console.ReadLine());
            //nhap du lieu mang
            for (int i = 1; i <= n; i++)

            {
                Console.Write("A[" + i + "]=");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }//in ra
            for (int i = 1; i <= n; i++)
            {
                Console.Write(A[i] + " ");
            }

            sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += A[i];
            }
            Console.Write("Tong day so la: " + sum);
            Console.ReadLine();

        }
    }
}

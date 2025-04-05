using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrantamgiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[10, 10];
            Console.Write("Nhap n: ");
            int n= Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("A["+i+","+j+"]=");
                    A[i,j]= Convert.ToInt32(Console.ReadLine());
                }
                
                
            }
            Console.Write("Ma tran tam giac can tim la: ");
            for (int i = 0; i <= n;i++)
            {
                for (int j = 1;j <= i; j++)
                {
                    Console.Write(" "+ A[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

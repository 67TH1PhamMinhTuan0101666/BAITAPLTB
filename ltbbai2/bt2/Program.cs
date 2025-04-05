using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("nhap so b::");
            double b = double.Parse(Console.ReadLine());
            Console.Write("nhap so c:");
            double c = double.Parse(Console.ReadLine());
            // tinh Delta
            double delta, x1, x2, x;
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta) / (2 * a));
                x2 = (-b - Math.Sqrt(delta) / (2 * a));
                Console.WriteLine(" Nhap gia tri nghiem x1, x2:" + x1 + x2);
                Console.ReadLine();

            }
            if (delta == 0)
            {
                x= (-b /(2 * a));
                Console.WriteLine(" Nhap gia tri nghiem x:" +x);
                Console.ReadLine();
            }

        }
    }
}

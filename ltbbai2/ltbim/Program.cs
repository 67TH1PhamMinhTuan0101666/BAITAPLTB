using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ltbim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("nhap so b::");
            double b = double.Parse(Console.ReadLine());
            Console.Write("nhap so c");
            double c = double.Parse(Console.ReadLine());
            double min = 0;
            if (a > b)
            { min = b; }
            else { min = a; }

            if (min > c)
            { min = c; }
            Console.Write("So nho nhat la" + min);
            Console.ReadLine();
        }
    }
}

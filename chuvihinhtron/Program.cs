using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuvihinhtron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R;
            Console.Write("Nhap vao ban kinh duong tron: ");
            R=Convert.ToDouble(Console.ReadLine());
            tinhchuvihinhtron(R);
            Console.ReadLine();
        }
        private static double tinhchuvihinhtron(double radius)
        {
            double pi = 3.1415926;
            double chuvi=2*pi*radius;
            Console.WriteLine("Ban kinh duong tron: " + radius);
            Console.WriteLine("Chu vi duong tron: "+chuvi);
            return chuvi;
        }
        private  static double tinhdientich(double radius)
        {
            double pi = 3.1415926;
            double S = (pi * 2 * radius * 2 * radius) / 4;
            Console.WriteLine("Dien tich hinh tron la: ");
            Console.ReadLine() ;
            return S;
        }
    }
}

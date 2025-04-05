using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhClass_20_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Name = {"Nam","Tan","Nien","Linh","Hoang" };
            int[] height = { 176, 154, 181, 167, 170 };
            int[] weight = {85, 60, 75, 60, 70 };
            bool[] gender = { true, true, true, false, true };

            Person person1= new Person("Tien",165,81,true);
            Console.Write("Thong tin person: " + person1.getName());
            Console.ReadLine();
        }
    }
}

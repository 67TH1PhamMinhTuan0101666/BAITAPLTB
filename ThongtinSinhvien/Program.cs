using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongtinSinhvien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinhvien Thongtin = new Sinhvien("Nam","BacGiang",0098266,08,09,07);
            Console.Write("Thong tin sinh vien la: " + Thongtin.Hoten + " " + Thongtin.Quequan + " " + Thongtin.MSSV + " " +Thongtin.diemToan+" "
                +Thongtin.diemLy+" "+Thongtin.diemHoa);
            Console.ReadLine();
            double diemTB;
            diemTB = (Thongtin.diemToan + Thongtin.diemLy + Thongtin.diemHoa) / 3;
            Console.Write("Diem TB la: " + diemTB);
            Console.ReadLine();

        }
    }
}

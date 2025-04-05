using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongtinSinhvien
{
    public class Sinhvien
    {//Thuoc tinh         
        public string Hoten;
        public string Quequan;
        public int MSSV;
        public int diemToan;
        public int diemLy;
        public int diemHoa;
        //Phuong thuc

        public Sinhvien(string _Hoten, string _Quequan, int _MSSV, int _diemToan, int _diemLy, int _diemHoa)
        {
            this.Hoten = _Hoten;
            this.Quequan = _Quequan;
            this.MSSV = _MSSV;
            this.diemToan= _diemToan;
            this.diemLy = _diemLy;
            this.diemHoa = _diemHoa;
            
        }
    }
}

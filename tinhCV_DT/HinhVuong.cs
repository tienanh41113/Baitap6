using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhCV_DT
{
    class HinhVuong : HinhCN
    {
        public double chuvi;
        public double dientich;
        public double Canh
        {
            get { return cd; }
            set { cd = value; }
        }
        public HinhVuong() { }
        public HinhVuong(double canh)
        {
            cd = canh;
        }
        public void Cv()
        {
            chuvi = CD * 4;
        }
        public void Dt()
        {
            dientich = CD * CD;
        }
    }
}

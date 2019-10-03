using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhCV_DT
{
    class HinhCN : HinhHoc
    {
        protected double cd;
        private double cr;
        public double chuvi;
        public double dientich;
        public double CD
        {
            get { return cd; }
            set { cd = value; }
        }
        public double CR
        {
            get { return cr; }
            set { cr = value; }
        }
        public HinhCN(double dai, double rong)
        {
            cd = dai;
            cr = rong;
        }
        public HinhCN() { }

        public void Cv()
        {
            chuvi = (cd + cr) * 2;
        }
        public void Dt()
        {
            dientich = cd * cr;
        }
    }
}

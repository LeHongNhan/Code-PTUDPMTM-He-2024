using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_DongHo
{
    public class DongHo
    {
        public int gio { get; set; }
        public int phut { get; set; }
        public int giay { get; set; }
        public int miligiay { get; set; }
        public DongHo()
        {
            gio = 0;
            phut = 0;
            giay = 0;
            miligiay = 0;
        }
        public void tang1MiliGiay()
        {
            if (miligiay == 59)
            {
                miligiay = 0;
                if (giay == 59)
                {
                    giay = 0;
                    if (phut == 59)
                    {
                        phut = 0;
                        gio++;
                    }
                    else
                    {
                        phut++;
                    }
                }
                else
                {
                    giay++;
                }
            }
            else
            {
                miligiay++;
            }
        }
        public void layThoiGian(int gio, int phut, int giay)
        {
            this.gio = gio;
            this.phut = phut;
            this.giay = giay;
        }
        public void demNguoc()
        {
            if (giay == 0)
            {
                if (phut != 0)
                {
                    phut--;
                    giay = 59;
                }
                else if(gio != 0)
                {
                    gio--;
                    giay = 59;
                    phut = 59;
                }
            }
            else
            {
                giay = giay - 1;
            }
        }
    }

}

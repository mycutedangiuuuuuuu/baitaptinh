using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp04
{
    public class hinhchunhat
    {
        public double a, b;
        public double chuvi {get;private set; }
        public double dientich { get; private set; }
        public bool ok { get; private set; }
        public void Xuly()

        {

            if (a > 0 && b > 0 && a > b)
            {
                chuvi = (a + b) * 2;
                dientich = (a * b);
              

                ok = true;
            }
            else
            {
                //Console.WriteLine("lỗi !!! ");
                ok = false;
            }
        }
    }
}

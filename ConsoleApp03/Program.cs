using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("phần mềm tính chu vi và diện tích hình chữ nhật-consleApp03");
            Console.WriteLine("nhập 2 cạnh của hình chữ nhật : ");
            string s = Console.ReadLine();
            string cv = Console.ReadLine();
            string[] items = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            

            if (items.Length == 2 )
            {
                double a = double.Parse(items[0]);
                double b = double.Parse(items[1]);

                double S = 0;
                double CV = 0;
                bool ok = Xuly(a,b,ref S,ref CV);
                if (ok)
                { 
                    Console.WriteLine($" diện tích hinh chu nhat = {S}");
                    Console.WriteLine($" chu vi hinh chu nhat = {CV}");
                }
                else
                {
                    Console.WriteLine("lỗi !!! ");
                }


            }
            Console.ReadKey();
        }
        static bool Xuly(double a, double b,ref double CV ,ref double S)
       
        {

            if (a > 0 && b > 0 && a > b)
            {
                CV = (a + b) * 2;
                S = (a * b);
               

                return true;
            }
            else
            {
              
                return false;
            }
        }
    }
}

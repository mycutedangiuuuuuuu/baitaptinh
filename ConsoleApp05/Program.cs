using lib_hinhhoc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp05
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


            if (items.Length == 2)
            {
                double a = double.Parse(items[0]);
                double b = double.Parse(items[1]);
                lib_hinhhoc.hinhchunhat hcn = new lib_hinhhoc.hinhchunhat();
                hcn.a = a;
                hcn.b = b;
                hcn.Xuly();
                if (hcn.ok)
                {
                    Console.WriteLine($" diện tích hinh chu nhat = {hcn.dientich}");
                    Console.WriteLine($" chu vi hinh chu nhat = {hcn.chuvi}");
                }
                else
                {
                    Console.WriteLine("lỗi !!! ");
                }


            }
            Console.ReadKey();
        }
    }
}

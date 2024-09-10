using System;
using System.Collections.Generic;
using System.Text;

namespace consoleApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.InputEncoding = Encoding.UTF8;
           Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("phần mềm tính chu vi và diện tích hình chữ nhật-consoleApp02");
            Console.WriteLine("nhập 2 cạnh của hình chữ nhật : ");
            string s = Console.ReadLine();
            string cv = Console.ReadLine();
            string[] items = s.Split(new char[] { ' ' ,'\t'}, StringSplitOptions.RemoveEmptyEntries);
            

            if (items.Length == 2)
            { 
                double a = double.Parse(items[0]);
                double b = double.Parse(items[1]);
                if (a > 0 && b > 0 && a > b)
                {
                    double CV = (a + b) * 2;
                    double S = (a * b);
                    Console.WriteLine($"chu vi của hình chữ nhật là : {CV}");
                    Console.WriteLine($"diện tích của hình chữ nhật là : {S}");
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

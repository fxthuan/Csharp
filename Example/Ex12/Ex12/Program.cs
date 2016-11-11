using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, chuvi, dien_tich;
            double PI = 3.14;
            Console.Write("Nhap ban kinh duong tron: ");
            r = Convert.ToDouble(Console.Read());
            chuvi = 2 * PI * r;
            Console.WriteLine("\nChu vi duong trong la: {0}", chuvi);
            dien_tich = PI * r * r;
            Console.WriteLine("Dien tich duong tron la: {0}", dien_tich);
      

            Console.ReadKey();
        }
    }
}

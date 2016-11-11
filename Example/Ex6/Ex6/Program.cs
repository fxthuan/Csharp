using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter, letter1, letter2;

            Console.Write("Nhap chu cai thu nhat: ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Nhap chu cai thu hai: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Nhap chu cai thu ba: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Hien thi 2 chu cai theo chieu nguoc lai: ");
            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);

            Console.ReadKey();
        }
    }
}

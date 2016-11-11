using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, pass;
            int count = 0;
            Console.Write("Kiem tra ten dang nhap va mat khau:\n");
            Console.Write("Gia tri mac dinh la: user va password\n");
            Console.Write("---------------------------------------\n");

            do
            {
                Console.Write("Ten dang nhap: ");
                user = Console.ReadLine();

                Console.Write("Mat khau: ");
                pass = Console.ReadLine();

                count++;
            }
            while (((user != "user") || (pass != "password")) && (count != 3));

            if (count == 3)
                Console.Write("Dang nhap that bai!");
            else
                Console.Write("Mat khau chinh xac.Ban da dang nhap thanh cong!");

            Console.ReadKey();




        }
    }
}


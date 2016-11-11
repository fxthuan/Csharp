using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, password;
            Console.Write("Kiem tra ten dang nhap va mat khau:\n");
            Console.Write("Gia tri mac dinh la: user va password\n");
            Console.Write("-----------------------------------------\n
                ");

            do
            {
                Console.Write("Ten dang nhap: ");
                user = Console.ReadLine();

                Console.Write("Mat khau: ");
                password = Console.ReadLine();
            }
            while (user != "user" && password != "password");

            Console.WriteLine("Ten dang nhap va mat khau sai!");

            Console.ReadKey();

        }
    }
}

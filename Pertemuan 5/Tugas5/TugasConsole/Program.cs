using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLibraryUnitTest;

namespace TugasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Pertemuan 5 - Unit Testing";
            Day day = new Day();
            User user = new User();
            string inputUserName;
            string inputPassword;

            Console.WriteLine("Selamat Pagi, Sekarang Hari {0}", day.NameOfDay(1));
            Console.WriteLine("Silahkan Login Terlebih Dahulu!");
            Console.Write("Username: ");
        }
    }
}

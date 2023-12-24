using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculatorMachine;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";

            Console.Write("Inputkan Nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan Nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Membuat object calculator menggunakan keyword var
            var cal = new Calculator();

            Console.WriteLine();
            Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, cal.Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian: {0} x {1} = {2}", a, b, cal.Perkalian(a, b));

            // Khusus method pembagian dipanggil langsung dari class Calculator
            // Karena merupakan method static
            Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b));

            // Pertemuan 2
            Console.WriteLine("Hasil Pangkat: {0} ^ {1} = {2}", a, b, cal.Pangkat(a, b));
            Console.WriteLine("Hasil Modulus: {0} % {1} = {2}", a, b, Calculator.Modulo(a, b));

            Console.ReadKey();
        }
    }
}

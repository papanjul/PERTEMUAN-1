using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLibraryUnitTest
{
    public class Day
    {
        public string NameOfDay(int dayNum)
        {
            switch (dayNum)
            {
                case 1:
                    return "Senin";
                case 2:
                    return "Selasa";
                case 3:
                    return "Rabu";
                case 4:
                    return "Kamis";
                case 5:
                    return "Jumat";
                case 6:
                    return "Sabtu";
                case 7:
                    return "Minggu";
                default:
                    return "Salah";
            }
        }

        /*
        static void Main()
        {
            int dayNumber = 3;
            string dayName = NameOfDay(dayNumber);
            Console.WriteLine(dayName);
        }
        */
        
    }
}

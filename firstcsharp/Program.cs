using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goal
{
    class Prog
    {
        static void Main(string[] args)
        {
            int[] lucky = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for(int i = 0; i< lucky.Length; i++)
            {
                Console.WriteLine(lucky[i]);
            }

            
        }

        static string Daycheck(int DayNum)
        {
            string dayName;

            switch (DayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Invalid day number";
                    break;

            }
            return dayName;

        }


    }

}
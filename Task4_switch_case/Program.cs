using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {            
            Days();

            Console.ReadKey();
        }

        static int Enter()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static void Week()
        {
            int num = Enter();
            string day;
            switch(num)
            {
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
                default:
                    day = "Error.\nWeek have only 7 days !";
                    break;              

            }

            Console.WriteLine(day);
        }

        static void Month()
        {
            int num = Enter();
            string month;
            switch (num)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
                default:
                    month = "Error.\nYear have only 12 month !";
                    break;
            }
            Console.WriteLine(month);
        }

        static void Season()
        {
            int num = Enter();
            string season;
            switch (num)
            {
                case 1:
                    season = "Winter";
                    break;
                case 2:
                    goto case 1;
                case 3:
                    season = "Spring";
                    break;
                case 4:
                    goto case 3;
                case 5:
                    goto case 3;
                case 6:
                    season = "Summer";
                    break;
                case 7:
                    goto case 6;
                case 8:
                    goto case 6;
                case 9:
                    season = "Autumn";
                    break;
                case 10:
                    goto case 9;
                case 11:
                    goto case 9;
                case 12:
                    goto case 1; 
                default:
                    season = "Error.\nYear have only 12 month !";
                    break;
            }
            Console.WriteLine(season);
        }                static void Days()
        {
            Console.Write("Введите год: ");
            int year = Enter();
            Console.Write("Введите месяц: "); 
            int month = Enter();
            int days = 0;
            string mon;
            bool leap;

            if ((year % 100 == 0 && year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                leap = true;
                Console.WriteLine("\nIt`s leap year !");
            }
            else
            {
                leap = false;
                Console.WriteLine("\nIt`s NOT leap year !");
            }

            switch (month)
            {
                case 1:
                    mon = "January"; 
                    days = 31;
                    break;
                case 2:
                    mon = "February";

                    if (leap == true)
                    {
                        days = 29;
                    }
                    else days = 28;

                    break;
                case 3:
                    mon = "March";
                    days = 31;
                    break;
                case 4:
                    mon = "April";
                    days = 30;
                    break;
                case 5:
                    mon = "May";
                    days = 31;
                    break;
                case 6:
                    mon = "June";
                    days = 30;
                    break;
                case 7:
                    mon = "July";
                    days = 31;
                    break;
                case 8:
                    mon = "August";
                    days = 31;
                    break;
                case 9:
                    mon = "September";
                    days = 30;
                    break;
                case 10:
                    mon = "October";
                    days = 31;
                    break;
                case 11:
                    mon = "November";
                    days = 30;
                    break;
                case 12:
                    mon = "December";
                    days = 31;
                    break;
                default:
                    mon = "Error.\nYear have only 12 month !";
                    days = 0;
                    break;
            }

            Console.WriteLine("{0} have {1} days.", mon, days);

        }
    }
}

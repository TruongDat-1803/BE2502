using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LearnSwitchCase
{
    internal class Demo
    {
        public string GetMessage(int statusCode)
        {
            string message = statusCode switch
            {
                200 => "OK",
                404 => "Not Found",
                500 => "Internal Server Error",
                _ => "Unknown Status Code"
            };
            return message;
        }

        public string GetMessage2(string statusCode)
        {
            var message = string.Empty;
            switch (statusCode)
            {
                case "200": 
                    message = "Ok";
                    break;
                case "401":
                    message = "Unauthorize";
                    break;
                case "400": 
                    message = "bad request";
                    break;
                case "403": 
                    message = "forbiden";
                    break;
                case "500":
                    message = "server error";
                    break;
                default:
                    message = "status code not found";
                    break;
            }
            return message;
        }

        // viết hàm nhập vào 1 tháng => trả ra tháng đấy có bao nhiêu ngày , tạm thời tháng 2 có 28 ngày
        public int GetDaysOfMonth(int month)
        {
            int days = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31; break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30; break;
                case 2:
                    days = 28; break;
                default:
                    days = 0; break;
            }
            return days;
        }

        public int GetDaysOfMonth1(Month month)
        {
            int days = 0;
            switch (month)
            {
                case Month.January:
                case Month.March:
                case Month.May:
                case Month.July:
                case Month.August:
                case Month.October:
                case Month.December:
                    days = 31; break;
                case Month.April:
                case Month.June:
                case Month.September:
                case Month.November:
                    days = 30; break;
                case Month.February:
                    days = 28; break;
                default:
                    days = 0; break;
            }
            return days;
        }

        public int GetDaysOfMonthAndYear(Month month, int year)
        {
            int days = 0;
            switch (month)
            {
                case Month.January:
                case Month.March:
                case Month.May:
                case Month.July:
                case Month.August:
                case Month.October:
                case Month.December:
                    days = 31; break;
                case Month.April:
                case Month.June:
                case Month.September:
                case Month.November:
                    days = 30; break;
                case Month.February:
                    if (IsLeapYear(year))
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
                default:
                    days = 0; break;
            }
            return days;
        }

        public bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}

using System;
using System.Collections.Generic;

namespace eedwards_AssociateApplicationDeveloper
{
    public class Day
    {
        private static string previousDay = "";

        public int ChanceOfPercipitation { get; private set; }
        public int DayOfMonth { get; private set; }
        public string DayOfWeek { get; private set; }
        public int High { get; private set; }
        public int Low { get; private set; }


        public Day(string[] values)
        {
            if (values.Length > 1)
            {
                this.DayOfMonth = int.Parse(values[0]);
                this.DayOfWeek = GetDayOfWeek(values[1].Trim()); 
                this.High = ConvertToFahrenheit(int.Parse(values[2]));
                this.Low = ConvertToFahrenheit(int.Parse(values[3]));
                this.ChanceOfPercipitation = int.Parse(values[4]);
            }

        }

        private string GetDayOfWeek(string currentDayAbbreviation)
        {
            string dayOfWeek = string.Empty;


            if (currentDayAbbreviation == "m")
            {
                dayOfWeek = "Monday";
            }
            else if (currentDayAbbreviation == "t" && previousDay == "w")
            {
                dayOfWeek = "Thursday";
            }
            else if (currentDayAbbreviation == "s" && previousDay == "f")
            {
                dayOfWeek = "Saturday";
            }
            else if (currentDayAbbreviation == "t")
            {
                dayOfWeek = "Tuesday";
            }
            else if (currentDayAbbreviation == "w")
            {
                dayOfWeek = "Wednesday";

            }
            else if (currentDayAbbreviation == "f")
            {
                dayOfWeek = "Friday";
            }
            else if (currentDayAbbreviation == "s")
            {
                dayOfWeek = "Sunday";
            }


            previousDay = currentDayAbbreviation;
            return dayOfWeek;
        }

        private int ConvertToFahrenheit(int celsius)
        {
            return (celsius * 9 / 5) +32;
        }

        public void WriteToConsole()
        {
            Console.WriteLine($"{this.DayOfWeek} the {this.DayOfMonth}th day of the month is the best day for a picnic.");
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace eedwards_AssociateApplicationDeveloper
{
    public class Data
    {
        private List<Day> daysOfMonth; 

        public Data(string filePath)
        {
            daysOfMonth = new List<Day>(); 

            if (!System.IO.File.Exists(filePath))
            {
                Console.WriteLine("File Not Found");
            }

            string[] fileText = System.IO.File.ReadAllLines(filePath);

            ReadFileToClass(fileText);
        }

        private void ReadFileToClass(string[] fileData)
        {
            for (int i = 1; i < fileData.Length; i++)
            {
                var columns = SplitRowIntoColumns(fileData[i]);

                daysOfMonth.Add(new Day(columns));
            }
        }

        private string[] SplitRowIntoColumns(string row)
        {
            return row.Replace('\t', ' ').Split(' ').Where(r => !string.IsNullOrEmpty(r)).ToArray();
        }

        public List<Day> GetPerfectDays(int numberOfDays)
        { 
            return FilterData().Take(numberOfDays).ToList(); 
        }

        private List<Day> FilterData()
        { 
            var filteredData = daysOfMonth.Where(d => d.High <= 85 && d.Low >= 70).ToList();

            return filteredData.OrderBy(d => d.ChanceOfPercipitation).ToList(); 
        }




    }
}

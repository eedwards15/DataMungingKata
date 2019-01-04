namespace eedwards_AssociateApplicationDeveloper
{
    class Program
    {

        /*
         Write a program that picks the best day for a picnic, given the least amount of 
         precipitation and a temperature range between 70 to 85 degrees fahrenheit. 
         If there are more than one "best day" provide the answer as a list.

        The answer format should be as follows, e.g.,

        Monday the 11th day of the month is the best day for a picnic.


    */


        static void Main(string[] args)
        {
            var data = new Data("weather.txt"); 

            foreach(var days in data.GetPerfectDays(1))
            {
                days.WriteToConsole(); 
            }

        }
         

    }
}

using System;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
 
        }

        void Run()
        {
            double fee = CalculateFee();
            Console.WriteLine("Fee is {0}", fee);
            
        }
        
        private double CalculateFee(double dailyRate = 500, int noOfDays = 1)
        {
            Console.WriteLine("CalculateFee using two optional parameters");
            return dailyRate * noOfDays;
        }
        private double CalculateFee(double dailyRate = 500)
        {
            Console.WriteLine("CalculateFee using one optional parameter");
            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }

        private double CalculateFee()
        {
            Console.WriteLine("CalculateFee using hardcoded values");
            double defaultDailyRate = 400;
            int defaultNoOfDays = 1;
            return defaultDailyRate * defaultNoOfDays;
        }
    }
}

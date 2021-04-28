using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        public double GetSum(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }
        public int GetDiff(int num1, int num2)
        {
            return num1 - num2;
        }

        //multiplication
        //division

        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double TotalAgeinDays = ageSpan.TotalDays;
            double TotalAgeinYears = TotalAgeinDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(TotalAgeinYears));
            return years;
        }
    }
}

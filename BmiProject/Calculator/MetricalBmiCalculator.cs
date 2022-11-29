using System;

namespace BmiProject.Calculator
{
    public class MetricalBmiCalculator : IBmiCalculator
    {
        public double CalculateBmi(double weight, double height)
        {
            if (weight <= 0)
            {
                throw new ArgumentException($"Weight {weight} is not a valid number");
            }

            if (height <= 0)
            {
                throw new ArgumentException($"Height {height} is not a valid number");
            }
            
            var bmi = weight / Math.Pow((height / 100.0), 2);
            return Math.Round(bmi, 2);

        }
    }
}
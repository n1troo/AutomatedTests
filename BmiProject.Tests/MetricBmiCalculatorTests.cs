using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BmiProject.Calculator;

namespace BmiProject.Tests
{
    public class MetricBmiCalculatorTests
    {
        [Theory]
        [InlineData(180, 90, 35.4)]
        public void CalculateBmi_ForGivenHeightAndWeight_ReturnCorrectBmi(double height, double weight , double bmiResult)
        {
            //arrange
            MetricalBmiCalculator bmi = new MetricalBmiCalculator();
            //act
            var resultBmiValue = bmi.CalculateBmi(weight, height);

            //assert
            Assert.Equal(bmiResult, resultBmiValue);
        }

        [Theory]
        [InlineData(0, 90, 20)]
        [InlineData(22, 0, 20)]
        [InlineData(22, 2, 20)]
        public void CalculateBmi_ForGivenParametrWithZeroValue_ReturnException(double height, double weight, double bmiResult)
        {
            //arrane
            MetricalBmiCalculator bmiCalculator = new MetricalBmiCalculator();
            //act
            Action action = () => bmiCalculator.CalculateBmi(weight, height);
           
            //assert
            Assert.Throws<ArgumentException>(action);;
        }
    }
}

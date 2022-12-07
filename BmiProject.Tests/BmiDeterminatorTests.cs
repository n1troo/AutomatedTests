using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BmiProject.Model;

namespace BmiProject.Tests
{
    public class BmiDeterminatorTests
    {
        [Theory]
        [InlineData(18.5, BmiClassification.Normal)]
        [InlineData(5, BmiClassification.Normal)]
        [InlineData(45, BmiClassification.Normal)]
        [InlineData(33, BmiClassification.ExtremeObesity)]
        public void DetermineBmi_FotGivenBmi_ReturnsClassification(double bmi,BmiClassification classification)
        {
            //arrange
            BmiDeterminator bmiDeterminator = new BmiDeterminator();
            

            //act
            var result = bmiDeterminator.DetermineBmi(bmi);
            
            //assert
            Assert.Equal(classification, result);
            

        }

    }
}

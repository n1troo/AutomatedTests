using System;
using BmiProject.Model;

namespace BmiProject.Calculator;

public class BmiCalculatorFacade
{
    private readonly BmiUnitSystem _unitSystem;

    public BmiCalculatorFacade(BmiUnitSystem unitSystem)
    {
        _unitSystem = unitSystem;
        GetTypeOfCalculator(unitSystem);
    }

    private IBmiCalculator GetTypeOfCalculator(BmiUnitSystem unitSystem)
    {
        return unitSystem switch
        {
            BmiUnitSystem.Imperial => new ImperialBmiCalculator(),
            BmiUnitSystem.Metric => new MetricalBmiCalculator(),
            _ => throw new NotImplementedException()
        };
    }

    public BmiResult CalculateBmiResult(double weight, double height)
    {
        var calculator = GetTypeOfCalculator(_unitSystem);
        double bmi = calculator.CalculateBmi(weight, height);

        Console.WriteLine(bmi);
        
        var result = new BmiResult
        {
            BmiUnitSystem = _unitSystem,
            BmiClassification = new BmiDeterminator().DetermineBmi(bmi),
            Summary = $"Your bmi is: {bmi}"
        };

        return result;
    }
}
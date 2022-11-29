﻿using System.Threading.Tasks;
using BmiProject.Model;

namespace BmiProject.Service;

public class ResultService
{
    public BmiResult BmiResult { get; private set; }
    private readonly IResultRepository _resultRepository;

    public ResultService(IResultRepository resultRepository)
    {
        _resultRepository = resultRepository;
    }

    public void SetRecentOverweightResult(BmiResult result)
    {
        if (result.BmiClassification == BmiClassification.Overweight)
        {
            BmiResult = result;
        }
    }

    public async Task SaveUnderweightResultAsync(BmiResult result)
    {
        if (result.BmiClassification == BmiClassification.Underweight)
        {
            await _resultRepository.SaveResultAsync(result);
        }
    }
}
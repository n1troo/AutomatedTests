using System.Threading.Tasks;
using BmiProject.Model;

namespace BmiProject.Service;

public class ResultRepository : IResultRepository
{
    public Task SaveResultAsync(BmiResult result)
    {
        return Task.CompletedTask;
    }
}
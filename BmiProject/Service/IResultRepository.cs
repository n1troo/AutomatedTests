using System.Threading.Tasks;
using BmiProject.Model;

namespace BmiProject.Service;

public interface IResultRepository
{
    Task SaveResultAsync(BmiResult result);
}
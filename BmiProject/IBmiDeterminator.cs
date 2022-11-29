using BmiProject.Model;

namespace BmiProject
{
    public interface IBmiDeterminator
    {
        BmiClassification DetermineBmi(double bmi);
    }
}
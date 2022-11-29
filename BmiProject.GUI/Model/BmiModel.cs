using System.ComponentModel.DataAnnotations;
using BmiProject.Model;

namespace BmiProject.GUI.Model
{
    public class BmiModel
    {
        [Required]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Must me number")]
        public double Weight { get;set; }
        [Required]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Must me number")]
        public double Height { get;set; }
        public BmiUnitSystem BmiUnitSystem { get;set; }

    }
}

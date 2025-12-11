using Kpo.Business.Base;
using Kpo.Business.Enums;

namespace Kpo.Business.Entities
{
    public class User : BusinessObject
    {
        public string Name { get; set; }
        public double Weight { get; set; }   // kg
        public double Height { get; set; }   // cm
        public int Age { get; set; }
        public DailyActivity Activity { get; set; }

        public override void Validate()
        {
            ValidateLength(Name, 1, 50, "User Name");
            ValidateRange(Weight, 20, 350, "Weight");
            ValidateRange(Height, 100, 250, "Height");
            ValidateRange(Age, 5, 120, "Age");
        }
    }
}
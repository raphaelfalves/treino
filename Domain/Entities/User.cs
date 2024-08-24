using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class User : IdentityUser
    {
        public SexEnum Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Weight { get; set; }
        public decimal TargetWeight { get; set; }
        public decimal Height { get; set; }
        public bool DifferentHours { get; set; }
        public string? AllDaysHour { get; set; }
        public string? MondayTrainingHour { get; set; }
        public string? TuesdayTrainingHour { get; set; }
        public string? WednesdayTrainingHour { get; set; }
        public string? ThursdayTrainingHour { get; set; }
        public string? FridayTrainingHour { get; set; }
        public string? SaturdayTrainingHour { get; set; }
        public string? SundayTrainingHour { get; set; }
    }
}










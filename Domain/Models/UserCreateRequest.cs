using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class UserCreateRequest(string email, string password)
    {
        [Required(ErrorMessage = "Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        [Display(Name = "Email")]
        public string Email { get; set; } = email;
        [Required(ErrorMessage = "Senha é obrigatória.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*(),.?\":{}|<>]).{6,100}$", ErrorMessage = "A senha deve ter ao menos uma letra minúscula e maiúscula e um caractere especial.")]
        [StringLength(100, ErrorMessage = "A {0} deve ter ao menos {2} e no máximo {1} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; } = password;
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

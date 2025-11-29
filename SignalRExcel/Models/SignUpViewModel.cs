using System.ComponentModel.DataAnnotations;

namespace SignalRExcel.Models
{
        public record SignUpViewModel([Required] string Email, [Required] string Password, [Required] string ConfirmPassword);
}

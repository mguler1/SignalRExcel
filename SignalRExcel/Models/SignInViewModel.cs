using System.ComponentModel.DataAnnotations;

namespace SignalRExcel.Models
{
    public record SignInViewModel([Required] string Email, [Required] string Password);
}


using System.ComponentModel.DataAnnotations;

namespace API.Controllers;

public class RegisterDTO
{
    [Required]
    public required string UserName { get; set; }
    [Required]
    public required string Password { get; set; }
}

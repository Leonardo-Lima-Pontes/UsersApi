using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UsersApi.Models;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [MaxLength(100)]
    [MinLength(3)]
    [DisplayName("Primeiro Nome")]
    public string FirstName { get; set; } = default!;

    [Required]
    [MaxLength(100)]
    [MinLength(3)]
    [DisplayName("Sobrenome")]
    public string LastName { get; set; } = default!;
}
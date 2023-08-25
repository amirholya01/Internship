using System.ComponentModel.DataAnnotations;

namespace Internship.Datalayer.Entities.User;

public class User
{
    [Key]
    public long UserId { get; set; }
    
    [Display(Name = "username")]
    [Required(ErrorMessage = "The {0} must not be empty.")]
    [MaxLength(15, ErrorMessage = "The {0} can not be more than {1} characters.")]
    public string Username { get; set; }
    
    [Display(Name = "email")]
    [Required(ErrorMessage = "The {0} must not be empty.")]
    [MaxLength(100, ErrorMessage = "The {0} can not be more than {1} characters.")]
    [EmailAddress(ErrorMessage = "The {0} is not valid.")]
    public string Email { get; set; }
    
    [Display(Name = "password")]
    [Required(ErrorMessage = "The {0} must not be empty.")]
    [MaxLength(30, ErrorMessage = "The {0} can not be more than {1} characters.")]
    public string Password { get; set; }
    
    [Display(Name = "active code")]
    public string ActiveCode { get; set; }
    
    [Display(Name = "is active?")]
    public bool IsActive { get; set; }
    
    [Display(Name = "date of registration")]
    public DateTime RegisterDate { get; set; }
}
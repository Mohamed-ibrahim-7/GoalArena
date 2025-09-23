using System.ComponentModel.DataAnnotations;

namespace GoalArena.ViewModels
{
    public class UserProfileVM
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }

       [Required]
       [DataType(DataType.Password)]
       public string Password { get; set; } = string.Empty;
       [Required]
       [DataType(DataType.Password)]
       [Compare(nameof(Password))]
       public string ConfirmPassword { get; set; } = string.Empty;
    
        public string UserId { get; set; } = string.Empty;
    }
}

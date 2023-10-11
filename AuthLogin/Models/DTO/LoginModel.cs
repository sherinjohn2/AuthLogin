using System.ComponentModel.DataAnnotations;

namespace AuthLogin.Models.Domain
{
    public class LoginModel
    {
        [Key]
        public int userId { get; set; }

        [Required(ErrorMessage = "Username is requried!")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is requried!")]
        public string password { get; set; }
    }
}

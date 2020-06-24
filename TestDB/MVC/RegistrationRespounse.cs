using System.ComponentModel.DataAnnotations;

namespace TestDB.MVC
{
    public class RegistrationRespounse
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
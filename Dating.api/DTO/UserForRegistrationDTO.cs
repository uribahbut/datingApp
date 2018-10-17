using System.ComponentModel.DataAnnotations;

namespace Dating.api.DTO
{
    public class UserForRegistrationDTO
    {
        [Required]
        public string  UserName { get; set; }
        [Required]

        public string Passwor { get; set; }

    }
}
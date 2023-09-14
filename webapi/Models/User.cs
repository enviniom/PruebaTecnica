using System.ComponentModel.DataAnnotations;
using webapi.Dto;

namespace webapi.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre del usuario es requerido")]
        public string Name { get; set; } = string.Empty;
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "El apellido del usuario es requerido")]
        public string Lastname { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "El género del usuario es requerido")]
        public string Gender { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "El email del usuario es requerido")]
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = new DateTime();

        public User()
        {
            
        }

        public User(UserData data)
        {
            Name = data.Name;
            Lastname = data.Lastname;
            Gender = data.Gender;
            Email = data.Email;
        }
    }
}

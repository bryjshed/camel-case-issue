using System.ComponentModel.DataAnnotations;

namespace UserService
{
    public class UserDto
    {
        [Required]
        public long? UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        
    }
}
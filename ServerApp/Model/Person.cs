using System.ComponentModel.DataAnnotations;

namespace ServerApp.Model
{
    public abstract class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        [Required]
        [Range(0,102, ErrorMessage = "Invalid age")]
        public int Age { get; set; }
        public int Height { get; set; }
        public string Sex { get; set; }

    }
}
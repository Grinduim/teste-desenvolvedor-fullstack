using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using backend.Models;

namespace backend.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty; // Required

        [Required]
        [StringLength(100)]
        public bool Status { get; set; } = true; // Default to active

        //one to many relatioship
        public ICollection<User>? Users { get; set; }
    }

}

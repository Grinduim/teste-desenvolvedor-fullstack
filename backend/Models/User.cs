using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(14)] // CPF format: XXX.XXX.XXX-XX
        public string CPF { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public DateTime DateOfBirth { get; set; }

        public string? Language { get; set; } // Optional

        [Required]
        [JsonIgnore] // Ensure password is not serialized in responses
        [StringLength(100, MinimumLength = 8)] 
        public string Password { get; set; } = string.Empty;

        public bool Status { get; set; } = true; // Default to active

        [Required]
        public int ProfileId { get; set; } // Foreign key

        public Profile? Profile { get; set; } // Navigation property

        // History
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Central_Errors_1.Models
{
    public class User
    {
        [Key]
        [Column("id")]
        public int UserId { get; set; }

        [Column("name")]
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Column("email")]
        [Required]
        [StringLength(250)]
        [EmailAddress]
        public string Email { get; set; }

        [Column("password")]
        [Required]
        [StringLength(250)]
        public string Password { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        [Required]
        public DateTime UpdatedAt { get; set; }

    }
}

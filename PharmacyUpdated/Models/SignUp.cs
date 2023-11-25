using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PharmacyUpdated.Models
{
    public class SignUp
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string UserName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string UserEmail { get; set; }
    }
}

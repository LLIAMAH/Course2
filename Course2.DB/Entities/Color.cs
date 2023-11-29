using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Course2.DB.Entities
{
    [Index(nameof(Name))]
    public class Color
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
    }
}

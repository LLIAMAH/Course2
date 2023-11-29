using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Course2.DB.Entities
{
    [Index(nameof(Name), new [] { nameof(Surname) }, IsUnique = true)]
    public class User
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [Required]
        [MaxLength(128)]
        public string Surname { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}

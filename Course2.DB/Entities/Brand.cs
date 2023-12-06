using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Course2.DB.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    public class Brand
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public virtual ICollection<Model> Models { get; set; }
    }
}

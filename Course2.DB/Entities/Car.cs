using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course2.DB.Entities
{
    public class Car
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Vin { get; set; }

        [MaxLength(128)]
        public string Number { get; set; }

        [ForeignKey(nameof(Brand))]
        public long BrandId { get; set; }
        [Required]
        public virtual Brand Brand { get; set; }

        [ForeignKey(nameof(Owner))]
        public long UserId { get; set; }
        public virtual User Owner { get; set; }

        [ForeignKey(nameof(Color))]
        public long? ColorId { get; set; }
        public virtual Color? Color { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course2.DB.Entities
{
    public class Model
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [ForeignKey(nameof(Brand))]
        public long BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}

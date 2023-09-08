using System.ComponentModel.DataAnnotations;

namespace Inventory.Entity.obj
{
    public class ProductEntity
    {
        [Key]
        [StringLength(50)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        [StringLength(600)]

        public string ProductDescription { get; set; }

        public int TotalQuality { get; set; }

        
    }
}

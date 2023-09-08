using System.ComponentModel.DataAnnotations;

namespace Inventory.Entity
{
    public class StorageEntity
    {



        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }
        [Required]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string WherehouseId { get; set; }
    }
}

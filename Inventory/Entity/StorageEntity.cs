using Inventory.Entity.obj;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

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

        public WherehouseEntity wherehouse { get; set; }



        public ProductEntity Product { get; set; }



        public ICollection<InOutEntity> Inout { get; set; }
    }
}

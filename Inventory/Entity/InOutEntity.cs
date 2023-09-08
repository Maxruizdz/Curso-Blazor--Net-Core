using System.ComponentModel.DataAnnotations;

namespace Inventory.Entity
{
    public class InOutEntity
    {
        [Key]
        [StringLength(50)]
        public string InOutId { get; set; }
        [Required]
        public DateTime InOutDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool IsInput { get; set; }
        [Required] 
        [StringLength(50)]
        public string StorageId { get; set; }
    }
}

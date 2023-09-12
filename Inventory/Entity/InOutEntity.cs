using System.ComponentModel.DataAnnotations;

namespace Inventory.Entity
{
    public class InOutEntity
    {
        [Key]
        
        public string InOutId { get; set; }
        [Required]
        public DateTime InOutDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool IsInput { get; set; }
        [Required] 
        
        public string StorageId { get; set; }


        public StorageEntity Storage { get; set; }
    }
}

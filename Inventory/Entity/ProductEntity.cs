using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Inventory.Entity.obj
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        [StringLength(600)]

        public string ProductDescription { get; set; }
        public int TotalQuality { get; set; }

       public string CategoryId { get; set; }

        public CategoriaEntity Categoria { get; set; }


        public ICollection<StorageEntity> storageEntities { get; set; }

        
    }
}

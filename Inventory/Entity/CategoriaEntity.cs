using System.ComponentModel.DataAnnotations;

namespace Inventory.Entity
{
    public class CategoriaEntity
    {
        [Key]
        [StringLength(50)]

        public string CategoriaId { get; set; }


        public string CategoriaName { get; set; }


    }
}

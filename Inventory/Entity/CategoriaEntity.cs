﻿using Inventory.Entity.obj;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Entity
{
    public class CategoriaEntity
    {
        [Key]
        

        public string CategoriaId { get; set; }


        public string CategoriaName { get; set; }

        public ICollection<ProductEntity> Products { get; set; }
    }
}

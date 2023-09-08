using Inventory.Entity;
using Inventory.Entity.obj;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.DataAccess
{
    public class InventaryContext: DbContext
    { 
        public DbSet<ProductEntity> productEntities { get; set; }
        public DbSet<CategoriaEntity> categoriaEntities { get; set; }
        public DbSet<InOutEntity> inventaryEntities { get; set;}

        public DbSet<StorageEntity> storageEntities { get; set; }

        public DbSet<WherehouseEntity> wherehouseEntities { get; set; }


        public InventaryContext(DbContextOptions<InventaryContext> options) : base(options) {
        
        
        
        
        }


        protected override void OnModelCreating(ModelBuilder modelbuilder) {







            modelbuilder.Entity<ProductEntity>(producto =>
            {
               


            });
        
        
        
        
        
        
        
        
        
        }

    }
}

using Inventory.Entity;
using Inventory.Entity.obj;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;

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

            List<CategoriaEntity> categoriass=new List<CategoriaEntity>();
            List<WherehouseEntity>wherehouses=new List<WherehouseEntity>();

            wherehouses.Add(new WherehouseEntity { WherehouseId=Guid.NewGuid().ToString(),WherehouseName="Bodega Central",WherehouseAddress="Calle 8 con 2"});
            wherehouses.Add(new WherehouseEntity { WherehouseId = Guid.NewGuid().ToString(), WherehouseName = "Bodega Norte", WherehouseAddress = "Calle 6 con 47" });
            categoriass.Add(new CategoriaEntity { CategoriaId = "ASH", CategoriaName = "Aseo Hogar" });
            categoriass.Add(new CategoriaEntity { CategoriaId = "ASP", CategoriaName = "Aseo Personal" });
            categoriass.Add(new CategoriaEntity { CategoriaId = "HGR", CategoriaName = "Hogar" });
            categoriass.Add(new CategoriaEntity { CategoriaId = "PRF", CategoriaName = "Perfumeria" });
            categoriass.Add(new CategoriaEntity { CategoriaId = "SLD", CategoriaName = "Salud" });
            
            modelbuilder.Entity<ProductEntity>(producto =>
            {

              
        });








            modelbuilder.Entity<CategoriaEntity>(p => {

                p.HasData(categoriass);
            });


            modelbuilder.Entity<WherehouseEntity>(P => {
            
            P.HasData(wherehouses);
            
            
            });

        }
       
     

    }
}

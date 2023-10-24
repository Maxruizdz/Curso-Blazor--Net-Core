using Inventory.DataAccess;
using Inventory.Entity;
using Inventory.Entity.obj;

namespace Inventory.Business
{
    public static class B_Product
    {
        public static List<ProductEntity> Get()
        {

            using (var db = new InventaryContext())
            {


                return db.productEntities.ToList();


            }


        }


        public static void Create (ProductEntity product)
        {

            using (var db = new InventaryContext())
            {



                db.productEntities.Add(product);
                db.SaveChanges();

            }

        }


        public static void Update(ProductEntity product)
        {


            using (var db = new InventaryContext())
            {

                db.productEntities.Update(product);
                db.SaveChanges();


            }



        }


        public static ProductEntity product(string id_product) {
            using (var db = new InventaryContext()) {


                return db.productEntities.Where(p=>p.ProductId == id_product).FirstOrDefault();
            
            
            }
        
        
        
        
        }
        public static void Delete(ProductEntity product)
        {


            using (var db = new InventaryContext())
            {


                db.productEntities.Remove(product);



            }





        }

    }
}

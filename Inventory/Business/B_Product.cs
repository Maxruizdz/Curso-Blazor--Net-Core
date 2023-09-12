using Inventory.DataAccess;
using Inventory.Entity;
using Inventory.Entity.obj;

namespace Inventory.Business
{
    public class B_Product
    {
        public List<ProductEntity> Get()
        {

            using (var db = new InventaryContext())
            {


                return db.productEntities.ToList();


            }


        }


        public void Create (ProductEntity product)
        {

            using (var db = new InventaryContext())
            {



                db.productEntities.Add(product);
                db.SaveChanges();

            }

        }


        public void Update(ProductEntity product)
        {


            using (var db = new InventaryContext())
            {

                db.productEntities.Update(product);
                db.SaveChanges();


            }



        }
        public void Delete(ProductEntity product)
        {


            using (var db = new InventaryContext())
            {


                db.productEntities.Remove(product);



            }





        }

    }
}

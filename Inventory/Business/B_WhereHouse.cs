using Inventory.DataAccess;
using Inventory.Entity;
using Inventory.Entity.obj;

namespace Inventory.Business
{
    public class B_WhereHouse
    {
        public List<WherehouseEntity> Get()
        {

            using (var db = new InventaryContext())
            {


                return db.wherehouseEntities.ToList();


            }


        }


        public void Create(WherehouseEntity wherehouse)
        {

            using (var db = new InventaryContext())
            {



                db.wherehouseEntities.Add(wherehouse);
                db.SaveChanges();

            }

        }


        public void Update(WherehouseEntity wherehouse)
        {


            using (var db = new InventaryContext())
            {

                db.wherehouseEntities.Update(wherehouse);
                db.SaveChanges();


            }



        }
        public void Delete(WherehouseEntity wherehouse)
        {


            using (var db = new InventaryContext())
            {


                db.wherehouseEntities.Remove(wherehouse);



            }





        }
    }


}

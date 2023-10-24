using Inventory.DataAccess;
using Inventory.Entity;
using Inventory.Entity.obj;

namespace Inventory.Business
{
    public static class B_WhereHouse
    {
        public static List<WherehouseEntity> Get()
        {

            using (var db = new InventaryContext())
            {


                return db.wherehouseEntities.ToList();


            }


        }


        public static void Create(WherehouseEntity wherehouse)
        {

            using (var db = new InventaryContext())
            {



                db.wherehouseEntities.Add(wherehouse);
                db.SaveChanges();

            }

        }


        public static void Update(WherehouseEntity wherehouse)
        {


            using (var db = new InventaryContext())
            {

                db.wherehouseEntities.Update(wherehouse);
                db.SaveChanges();


            }



        }
        public static void Delete(WherehouseEntity wherehouse)
        {


            using (var db = new InventaryContext())
            {


                db.wherehouseEntities.Remove(wherehouse);



            }





        }
        public static WherehouseEntity buscar_wherehouse(string wherehouse_id)
        {


            using (var db = new InventaryContext())
            {




                return db.wherehouseEntities.Where(p => p.WherehouseId == wherehouse_id).FirstOrDefault();

            }




        }
    }


}

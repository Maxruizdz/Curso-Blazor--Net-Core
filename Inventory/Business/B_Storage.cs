using Inventory.DataAccess;
using Inventory.Entity;
using Inventory.Entity.obj;

namespace Inventory.Business
{
    public class B_Storage
    {
        public List<StorageEntity> Get()
        {

            using (var db = new InventaryContext())
            {


                return db.storageEntities.ToList();


            }


        }


        public void Create(StorageEntity storage)
        {

            using (var db = new InventaryContext())
            {



                db.storageEntities.Add(storage);
                db.SaveChanges();

            }

        }


        public void Update(StorageEntity storage)
        {


            using (var db = new InventaryContext())
            {

                db.storageEntities.Update(storage);
                db.SaveChanges();


            }



        }
        public void Delete(StorageEntity storageEntity)
        {


            using (var db = new InventaryContext())
            {


                db.storageEntities.Remove(storageEntity);



            }





        }
    }
}

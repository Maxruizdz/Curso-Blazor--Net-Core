using Inventory.DataAccess;
using Inventory.Entity;
using Inventory.Entity.obj;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Extensions.Msal;
using System.Xml.Serialization;

namespace Inventory.Business
{
    public static class B_Storage
    {
        public  static List<StorageEntity> Get()
        {

            using (var db = new InventaryContext())
            {


                return db.storageEntities.ToList();


            }


        }
        public static Boolean get_verified_dupli(string id_storage) {

            using (var db = new InventaryContext())
            {

                var product = db.storageEntities.Where(x => x.StorageId== id_storage).ToList();
              

                   
                   var x=   product.Any();
                

                    return x;
               


            }
        }

        public static List<StorageEntity> GetStorages_wherehouse(string id_wherehouse) {



            using (var db = new InventaryContext()) {
            
            
            
            return db.storageEntities.Where(p=> p.WherehouseId == id_wherehouse).Include(p=>p.wherehouse ).Include(p=> p.Product).ToList();
            }
        
        }

        public static void Create(StorageEntity storage)
        {

            using (var db = new InventaryContext())
            {


                
                    db.storageEntities.Add(storage);
                    db.SaveChanges();
                
            }

        }


        public static void Update(StorageEntity storage)
        {


            using (var db = new InventaryContext())
            {

                db.storageEntities.Update(storage);
                db.SaveChanges();


            }



        }
        public static void Delete(StorageEntity storageEntity)
        {


            using (var db = new InventaryContext())
            {


                db.storageEntities.Remove(storageEntity);



            }





        }
    }
}

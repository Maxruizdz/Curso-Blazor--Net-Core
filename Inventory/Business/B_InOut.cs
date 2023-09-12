using Inventory.DataAccess;
using Inventory.Entity;

namespace Inventory.Business
{
    public class B_InOut
    {



        public List<InOutEntity> GetB_InOuts()
        {

            using (var db = new InventaryContext()) {
            
            
            
            return db.inventaryEntities.ToList();

            }



        }


        public void Create(InOutEntity inOutEntity) {


            using (var db= new InventaryContext()) {
            
            
            db.inventaryEntities.Add(inOutEntity);

                db.SaveChanges();
            
            }
        
        
        }

        public void Update(InOutEntity inOutEntity)
        {


            using (var db = new InventaryContext())
            {


                db.inventaryEntities.Update(inOutEntity);

                db.SaveChanges();

            }


        }


        public void Delete(InOutEntity inOutEntity) {


            using (var db= new InventaryContext()) {


                db.inventaryEntities.Remove(inOutEntity);
            
            
            
            }
        
        
        
        
        
        }

    }
}

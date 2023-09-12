using Inventory.DataAccess;
using Inventory.Entity;


namespace Inventory.Business
{
    public class B_Category
    {

       
        public List<CategoriaEntity> cattegoria() {

            using (var db = new InventaryContext()) { 
            
            
           return db.categoriaEntities.ToList();
            
            
            } 
        
       
        }


        public void Create_category(CategoriaEntity Ocategory) {

            using (var db= new InventaryContext()) {
            
            
            
           db.Add(Ocategory);
                db.SaveChanges();
            
            }
        
        }


        public void Update(CategoriaEntity Ocategory) {


            using (var db = new InventaryContext()) { 
            
            db.categoriaEntities.Update(Ocategory);
            db.SaveChanges();
            
            
            }
        
        
        
        }
        public void Delete(CategoriaEntity categoriaEntity)
        {


            using (var db = new InventaryContext()) {


                db.categoriaEntities.Remove(categoriaEntity);



            }





        }



    }
}

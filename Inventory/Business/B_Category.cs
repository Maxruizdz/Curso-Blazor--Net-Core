using Inventory.DataAccess;
using Inventory.Entity;


namespace Inventory.Business
{
    public static class B_Category
    {

       
        public static List<CategoriaEntity> cattegoria() {

            using (var db = new InventaryContext()) { 
            
            
           return db.categoriaEntities.ToList();
            
            
            } 
        
       
        }


        public static void Create_category(CategoriaEntity Ocategory) {

            using (var db= new InventaryContext()) {
            
            
            
           db.Add(Ocategory);
                db.SaveChanges();
            
            }
        
        }


        public static void Update(CategoriaEntity Ocategory) {


            using (var db = new InventaryContext()) { 
            
            db.categoriaEntities.Update(Ocategory);
            db.SaveChanges();
            
            
            }
        
        
        
        }
        public static  void Delete(CategoriaEntity categoriaEntity)
        {


            using (var db = new InventaryContext()) {


                db.categoriaEntities.Remove(categoriaEntity);



            }





        }


        public static CategoriaEntity buscar_categoria(string categoria_id) {


            using (var db = new InventaryContext()) {




                return db.categoriaEntities.Where(p => p.CategoriaId == categoria_id).FirstOrDefault();
            
            }
        
        
        
        
        }



    }
}

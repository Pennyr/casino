using System.Data.Entity;

namespace core_manager.Repositories
{
    public class GenericRepository<Context, Model> 
        where Model : class 
        where Context : DbContext, new()
    {
        public void Create(Model data)
        {
            using (var context = new Context())
            {
                var dbSet = context.Set<Model>();

                dbSet.Add(data);
                context.SaveChanges();
            }
        }

        public void GetAll()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}
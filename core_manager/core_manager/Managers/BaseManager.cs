using core_manager.Contexts;
using core_manager.Repositories;

namespace core_manager.Managers
{
    public class BaseManager<Model> : IManager<Model>
        where Model : class
    {
        public void Create(Model data)
        {
            var repo = new GenericRepository<_dbContext, Model>();
            repo.Create(data);
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

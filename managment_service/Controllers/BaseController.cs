using core_manager.Managers;
using System.Web.Mvc;

namespace managment_service.Controllers
{
    public class BaseController<Manager, Model> : Controller 
        where Manager : IManager<Model>, new()
        where Model : class
    {
        [HttpPost]
        public string Index(Model data)
        {
            Manager manager = new Manager();
            manager.Insert(data);

            return "success";
        }
    }
}
using managment_service.Contexts;
using managment_service.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace managment_service.Controllers
{
    public class CountriesController : Controller
    {
        [HttpPost]
        public string Index(Country data)
        {
            using (var context = new _dbContext())
            {
                var countries = context.Countries.Add(new Country() { Name = data.Name });
                context.SaveChanges();
            }

            return "success";
        }
    }
}
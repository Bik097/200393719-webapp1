using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _200393719_webapp1.Models;

namespace _200393719_webapp1.Controllers
{
    public class CarsController : Controller
    {

        List<Cars> carList = new List<Cars>()
        {
        new Cars { Id = 1, Brand = "Toyota", Model = "Corolla", Type = "Compact", Year = 2017},
        new Cars { Id = 2, Brand = "Ford", Model = "F-150", Type = "Truck", Year = 2018},
        new Cars { Id = 3, Brand = "Dodge", Model = "Caravan", Type = "Minivan", Year = 2019}
        };
        // GET: Cars
        public ActionResult Index()
        {
            //var content = "/Cars - this is a list of cars from Content()";
            return View(carList);
        }

        //Get:Cars/Details - Single Car
        public ActionResult Details(int? id)
        {
            if (id == null || id > carList.Count)
            {
                return Content("Invalid car id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);

}
    }
}


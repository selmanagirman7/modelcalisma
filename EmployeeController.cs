using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController:Controller
    {
        public String Index()
        {
            return "ss";


        }
        public ViewResult Index2()
        {
            return View();

        }
        public IActionResult Index3(){
            return Content("employee");
        }
    }
}
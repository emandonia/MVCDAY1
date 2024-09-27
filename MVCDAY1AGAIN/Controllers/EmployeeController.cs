using Microsoft.AspNetCore.Mvc;
using MVCDAY1AGAIN.DAL.DB;

namespace MVCDAY1AGAIN.Controllers
{
    public class EmployeeController : Controller
    {
        Applicationcontext db = new Applicationcontext();
        public IActionResult Index()
        {
            var result= db.Employees.ToList();
            return View(result);
        }
    }
}

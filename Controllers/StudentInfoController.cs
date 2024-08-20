using Microsoft.AspNetCore.Mvc;

namespace WebApplicationNew_ADONET.Controllers
{
    public class StudentInfoController : Controller
    {
        public IActionResult Index()
        {
            StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();


            var d = studentDataAccessLayer.GetAllStudent();
            return View(d);
        }
    }
}

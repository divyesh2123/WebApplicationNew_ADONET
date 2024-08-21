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

        public IActionResult AddStudent()
        {

            return View();

        }

        public IActionResult Edit(int id)
        {
            StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();


            var d = studentDataAccessLayer.GetStudentData(id);
            return View("AddStudent",d);

        }

        public ActionResult Delete(int id)
        {
            StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();
            studentDataAccessLayer.DeleteStudent(id);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();
            Student student = studentDataAccessLayer.GetStudentData(id);
            return View(student);
        }


        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();
            try
            {
                // TODO: Add insert logic here  
                studentDataAccessLayer.AddStudent(student);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVCNO1.Models;

namespace MVCNO1.Controllers
{
    public class DeptController : Controller
    {
        ITIDbContext db = new ITIDbContext();

        // get all 
        public IActionResult Index()
        {
            List<Department> deptList = db.Departments.ToList();
            return View("Index",deptList);
        }
        public IActionResult Details(int id)
        {
            var dept = db.Departments.FirstOrDefault(s => s.Id == id);
            return View(dept);
        }

        public IActionResult GetStudents(int id)
        {
            List<Student> std =db.Students.Where(s=> s.DeptId ==id ).ToList();
            return View("GetStd",std);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //if (id == null | id == 0)
            //{
            //    NotFound();
            //}
            // Department department =new Department();
            Department dept = db.Departments.FirstOrDefault(s=> s.Id == id);
            return View(dept);           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult SaveEdit(int id, Department newdept)
        {
            if (ModelState.IsValid)
            {
                // Fetch the department from the database
                Department dept = db.Departments.FirstOrDefault(s => s.Id == id);

                // Check if the department was found
                if (dept == null)
                {
                    // Return a not found view or handle the error appropriately
                    return NotFound();
                }

                // Update the department properties
                dept.Name = newdept.Name;
                dept.ManagerName = newdept.ManagerName;
                dept.Address = newdept.Address;
                dept.Age = newdept.Age;

                // Save changes to the database
                db.Departments.Update(dept);
                db.SaveChanges();

                // Redirect to the index page
                return RedirectToAction("Index");
            }

            // If the model state is not valid, return the edit view
            return View("Edit");
        }

        [HttpGet]
        public IActionResult NewDept()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveNewDept(Department dept)
        {
            if (ModelState.IsValid==true)
            {
                db.Departments.Add(dept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("NewDept");
        }

        public IActionResult DetailsUsingPartial(int id)
        {
            var dept = db.Departments.FirstOrDefault(s => s.Id == id);
            return PartialView("_CardPartial",dept);
        }
        [Route("show/{msg:alpha}")]
        public IActionResult showmsg(string msg)
        {
            return Content(msg);    
        }

        public IActionResult delete (int id)
        {
            var dept =db.Departments.FirstOrDefault(s => s.Id == id);
            db.Departments.Remove(dept);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using MVCNO1.Models;
using MVCNO1.ViewModel;

namespace MVCNO1.Controllers
{
    public class StudentController : Controller
    {
        ITIDbContext con = new ITIDbContext();
        public IActionResult details()
        {
           List<string> branchs = new List<string>();
            branchs.Add("Asiuut");
            branchs.Add("cairo");
            branchs.Add("Alex");

            //ViewData["brch"] = branchs;
            //ViewData["Age"] = 20;

            ViewBag.brch = branchs;
            Student std = con.Students.FirstOrDefault();

            return View("details",std);

        } 


        public IActionResult detailswithVM()
        {
            List<string> branchs = new List<string>();
            branchs.Add("Asiuut");
            branchs.Add("cairo");
            branchs.Add("Alex");

            Studentwithbranchlist std2 = new Studentwithbranchlist();
            std2.Branchs = branchs;
            Student std = con.Students.FirstOrDefault();

            std2.Name = std.Name;
            std2.Age = std.Age;

            return View("detailswithVM", std2);


        }
        public IActionResult Index()
        {
            var std = con.Students.ToList();
            return View("Index",std);
        }
    }
}

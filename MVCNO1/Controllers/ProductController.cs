using Microsoft.AspNetCore.Mvc;
using MVCNO1.Models;
using MVCNO1.Models;
namespace MVCNO1.Controllers
{
    public class ProductController : Controller
    {
        ProductBL BL = new ProductBL();

      ///  List<Product> products = BL.GetAll();
        
        //public IActionResult Index()
        //{
        //   return View("viewproduct",products);
        //}
      
    }
}

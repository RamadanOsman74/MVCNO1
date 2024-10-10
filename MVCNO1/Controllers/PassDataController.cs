using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace MVCNO1.Controllers
{
    public class PassDataController : Controller
    {
        public IActionResult setcookie()
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires= DateTimeOffset.Now.AddDays(1);   
            Response.Cookies.Append("name", "ramadan", cookieOptions);
            return Content("cookie saved");

        }
        // get cookie >>>> request.cookies["kay"]
        public IActionResult setsession()
        {
            HttpContext.Session.SetString("name", "ramadan osman");
            HttpContext.Session.SetInt32("age", 22);
            return Content("data saved");
        }

        public IActionResult getsession()
        {

            string name = HttpContext.Session.GetString("name");
            int? age = HttpContext.Session.GetInt32("age");
            return Content($"{name}, {age}");
        
        
        
        }


        public IActionResult first()
        {
            TempData["msg"] = "Hello ramadan from first action"; // set   // default in cookie at client

            return Content("data saved");
        }
        public IActionResult second()
        {
            string msg = "Empty";
           // string msg = TempData["msg"].ToString();
            if (TempData.ContainsKey("msg"))
            {
               // msg = TempData["msg"].ToString();
                TempData.Peek("msg");
            }
            return Content($" second+ {msg}");

        }
        public IActionResult third()
        {
            string msg = TempData["msg"].ToString();
            TempData.Keep("msg");

            return Content($"third +{msg}");
        }

    }
}

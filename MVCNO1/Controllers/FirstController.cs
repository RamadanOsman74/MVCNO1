using Microsoft.AspNetCore.Mvc;

namespace MVCNO1.Controllers
{
	public class FirstController : Controller
	{   //


		public string Welcome()
		{
			return "Welcome Developers";
		}



		//Action >> Method // public // cant be overload
		
		public JsonResult Js()
		{
			JsonResult json = new JsonResult(new { Id = 1, Name = "Ahmed" }) ;
			return json ;
		}
		public ViewResult GetView()
		{
			ViewResult v1 = new ViewResult() ;
			v1.ViewName = "ViewOne";
			return v1;
		}

		public IActionResult getmix()
		{
			if (DateTime.Now.Day==19)
			{
				return Content("Closed");
				//ContentResult c1 = new ContentResult() ;
				//c1.Content = "CLOSED";
				//return c1;

			}else
			{

				return View("ViewOne");
			//	ViewResult v1 = new ViewResult();
			//	v1.ViewName = "ViewOne";
			//	return v1;

			}
		}


		public IActionResult Index()
		{
			return View();
		}
	}
}

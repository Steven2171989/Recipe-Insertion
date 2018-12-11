using System.Web.Mvc;


namespace RecipeWebSite.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			Recipe recipe = new Recipe();
			return View(recipe);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
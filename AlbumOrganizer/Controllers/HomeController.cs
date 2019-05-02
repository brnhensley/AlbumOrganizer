using Microsoft.AspNetCore.Mvc;

namespace AlbumOrganizer.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}

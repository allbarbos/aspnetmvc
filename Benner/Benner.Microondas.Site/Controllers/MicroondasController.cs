using Benner.Microondas.Site.Models;
using System.Web.Mvc;

namespace Benner.Microondas.Site.Controllers
{
  public class MicroondasController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Esquentar(MicroondasModel model)
    {
      if (!ModelState.IsValid)
        return View("Index", model);


      return View();
    }
  }
}
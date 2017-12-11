using Benner.MicroondasOnline.Domain.Interfaces.Application;
using Benner.MicroondasOnline.Site.Models;
using System;
using System.Web.Mvc;

namespace Benner.MicroondasOnline.Site.Controllers
{
  public class MicroondasController : Controller
  {
    private readonly IMicroondasApplication _microondasApplication;

    public MicroondasController(IMicroondasApplication microondasApplication)
    {
      _microondasApplication = microondasApplication;
    }

    public ActionResult Index()
    {
      ViewBag.Programas = _microondasApplication.BuscaProgramas();

      return View();
    }

    [HttpPost]
    public ActionResult Esquentar(MicroondasModel model)
    {
      if (!model.Rapido && !ModelState.IsValid)
        return View("Index", model);

      try
      {
        model.Status = _microondasApplication.Esquenta(model.Rapido, model.Tempo, model.Potencia);
      }
      catch (Exception e)
      {
        ModelState.AddModelError("MicroondasErro", e.Message);
        return View("Index", model);
      }

      ModelState.Clear();
      return View("Index", model);
    }






    //public ActionResult AquecimentoAsync(MicroondasModel model)
    //{
    //  try
    //  {
    //    var micro = new Domain.Entities.Microondas(model.Rapido, model.Tempo, model.Potencia);
    //    micro.ValidaPotencia();
    //    micro.ValidaTempo();

    //    AsyncManager.OutstandingOperations.Increment();

    //    Task.Factory.StartNew(task =>
    //    {
    //      for (int i = 0; i < model.Tempo.TotalSeconds; i++)
    //      {
    //        Thread.Sleep(1000);

    //        var potencias = _microondasApplication.Potencias();

    //        HttpContext.Application["task" + task] = potencias[model.Potencia - 1];
    //      }

    //      //var msg = " aquecida";
    //      AsyncManager.OutstandingOperations.Decrement();
    //      //AsyncManager.Parameters["msg"] = msg;
    //      //return msg;

    //    }, model.Potencia);

    //    return Json(new
    //    {
    //      Progress = HttpContext.Application["task" + model.Potencia]
    //    }, JsonRequestBehavior.AllowGet);
    //  }
    //  catch (Exception e)
    //  {
    //    ModelState.AddModelError("MicroondasErro", e.Message);
    //  }

    //  return View("Esquentar", model);
    //}

    //public ActionResult AquecimentoCompleted(string msg)
    //{
    //  return Content(msg, "text/plain");
    //}

    //public ActionResult AquecimentoProgress(int id)
    //{
    //  return Json(new
    //  {
    //    Progress = HttpContext.Application["task" + id]
    //  }, JsonRequestBehavior.AllowGet);
    //}
  }
}
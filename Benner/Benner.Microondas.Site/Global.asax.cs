using Microsoft.Practices.Unity;
using System.Web.Mvc;
using System.Web.Routing;

namespace Benner.Microondas.Site
{
  public class MvcApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {
      var container = new UnityContainer();
      CrossCutting.DependencyResolver.SiteResolve(container);

      AreaRegistration.RegisterAllAreas();
      RouteConfig.RegisterRoutes(RouteTable.Routes);
    }
  }
}

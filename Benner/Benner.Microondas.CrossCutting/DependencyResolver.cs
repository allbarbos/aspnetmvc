using Benner.Microondas.Application.Application;
using Benner.Microondas.Domain.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;

namespace Benner.Microondas.CrossCutting
{
  public static class DependencyResolver
  {
    public static void SiteResolve(UnityContainer container)
    {
      container.RegisterType<IMicroondasApplication, MicroondasApplication>(new HierarchicalLifetimeManager());

      System.Web.Mvc.DependencyResolver.SetResolver(new UnityDependencyResolver(container));
    }
  }
}

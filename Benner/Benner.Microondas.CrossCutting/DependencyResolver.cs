using Benner.MicroondasOnline.Application.Application;
using Benner.MicroondasOnline.Domain.Interfaces.Application;
using Benner.MicroondasOnline.Domain.Interfaces.Repository;
using Benner.MicroondasOnline.Repository.Repository;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;

namespace Benner.MicroondasOnline.CrossCutting
{
  public static class DependencyResolver
  {
    public static void SiteResolve(UnityContainer container)
    {
      container.RegisterType<IMicroondasApplication, MicroondasApplication>(new HierarchicalLifetimeManager());

      container.RegisterType<IMicroondasRepository, MicroondasRepository>(new HierarchicalLifetimeManager());

      System.Web.Mvc.DependencyResolver.SetResolver(new UnityDependencyResolver(container));
    }
  }
}

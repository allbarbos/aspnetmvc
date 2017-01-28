using System.Web.Mvc;
using System.Web.Routing;
using WebMatrix.WebData;

namespace Financas
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Inicialização do Simple MemberShip
            WebSecurity.InitializeDatabaseConnection("FinancasContext", "Usuarios", "ID", "Email", true);
        }
    }
}

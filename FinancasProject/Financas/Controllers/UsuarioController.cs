using Financas.DAO;
using Financas.Entidades;
using Financas.Models;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace Financas.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioDAO usuarioDAO;

        public UsuarioController(UsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(UsuarioModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //Usuario usuario = new Usuario();
                    //usuario.Nome = model.Nome;
                    //usuario.Email = model.Email;

                    //usuarioDAO.Adiciona(usuario);

                    //WebSecurity.CreateAccount(model.Nome, model.Senha);


                    //Cria user e Conta (Evitando o caso acima em que pode ser adicionado e depois visto que já existia o usuario no Simple Membership
                    //Argumentos: Login, Senha, Objeto Anônimo (Com as infos que serão adicionadas na tabela)
                    WebSecurity.CreateUserAndAccount(model.Nome, model.Senha, new { Email = model.Email });

                    return RedirectToAction("Index");
                }
                catch (MembershipCreateUserException e)
                {
                    ModelState.AddModelError("usuario.Invalido", e.Message);
                    return View("Form", model);
                }
            }
            else
            {
                return View("Form", model);
            }
        }

        public ActionResult Index()
        {
            return View(usuarioDAO.Lista());
        }
    }
}
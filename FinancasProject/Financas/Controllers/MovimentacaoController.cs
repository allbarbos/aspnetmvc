using Financas.DAO;
using Financas.Entidades;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Financas.Controllers
{
    [Authorize]
    public class MovimentacaoController : Controller
    {
        private MovimentacaoDAO movDAO;
        private UsuarioDAO userDAO;

        public MovimentacaoController(MovimentacaoDAO movimentacaoDAO, UsuarioDAO usuarioDAO)
        {
            movDAO = movimentacaoDAO;
            userDAO = usuarioDAO;
        }

        public ActionResult Form()
        {
            ViewBag.Usuarios = userDAO.Lista();
            return View();
        }

        public ActionResult Adiciona(Movimentacao movimentacao)
        {
            if (ModelState.IsValid)
            {
                movDAO.Adiciona(movimentacao);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Usuarios = userDAO.Lista();
                return View("Form", movimentacao);
            }
        }

        public ActionResult Index()
        {
            IList<Movimentacao> movimentacoes = movDAO.Lista();
            return View(movimentacoes);
        }
    }
}
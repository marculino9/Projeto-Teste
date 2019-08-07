//using Projeto02.DAO;
//using Projeto02.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace Projeto02.Controllers
//{
//    public class UsuarioController : Controller
//    {
//        // GET: Usuario
//        public ActionResult Index()
//        {
//            return View();
//        }

//        public ActionResult Autentica(String login, String senha)
//        {
//            UsuarioDAO dao = new UsuarioDAO();
//            Usuario usuario = dao.Busca(login, senha);
//            if (usuario != null)
//            {
//                Session["usuarioLogado"] = usuario;
//                return RedirectToAction("Index");
//            }
//            else
//            {
//                return RedirectToAction("index");
//            }
//        }
//    }
//}
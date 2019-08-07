//using Projeto02.DAO;
//using Projeto02.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace Projeto02.Controllers
//{
//    public class FuncionarioController : Controller
//    {
//        // GET: Funcionario
//        public ActionResult Index()
//        {
//            return View();
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Adiciona(Funcionario funcionario)
//        {
//                var dao = new FuncionarioDAO();
//                dao.Adiciona(funcionario);
//                return View();
//        }

//        public ActionResult Remover(int id)
//        {
//            var dao = new FuncionarioDAO();
//            Funcionario funcionarios = dao.BuscaPorIdWhere(id);
//            dao.Remover(funcionarios);
//            return RedirectToAction("Index");
//        }


//        //[Route("usuarios/{id}")]
//        public ActionResult Visualiza(int id)
//        {
//            var FuncionarioDAO = new FuncionarioDAO();
//            Funcionario funcionarios = FuncionarioDAO.BuscaPorIdWhere(id);
//            ViewBag.Funcionario = funcionarios;
//            return View(funcionarios);
//        }


//        public ActionResult Alterar(int id)
//        {
//            var FuncionarioDAO = new FuncionarioDAO();
//            Funcionario funcionarios = FuncionarioDAO.BuscaPorIdWhere(id);
//            ViewBag.Funcionario = funcionarios;
//            return View(funcionarios);

//        }
//    }
//}

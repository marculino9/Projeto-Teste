//using Microsoft.EntityFrameworkCore;
//using Projeto02.Contexto;
//using Projeto02.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace Projeto02.DAO
//{
//    public class FuncionarioDAO
//    {
//        public void Adiciona(Funcionario funcionario)
//        {
//            using (var context = new Context())
//            {
//                context.Add(funcionario);
//                context.SaveChanges();
//            }
//        }
//        public void Remover(Funcionario funcionario)
//        {
//            using (var context = new Context())
//            {
//                context.Funcionarios.Remove(funcionario);
//                context.SaveChanges();
//            }
//        }

//        public IList<Funcionario> Lista()
//        {
//            using (var contexto = new Context())
//            {
//                return contexto.Funcionarios.ToList();
//            }
//        }

//        public Funcionario BuscaPorId(int id)
//        {
//            using (var contexto = new Context())
//            {
//                return contexto.Funcionarios.Find(id);
//            }
//        }

//        public Funcionario BuscaPorIdWhere(int id)
//        {
//            using (var contexto = new Context())
//            {
//                return contexto.Funcionarios.Where(u => u.Id == id).FirstOrDefault();
//            }
//        }

//        public void Atualiza(Funcionario funcionario)
//        {
//            using (var contexto = new Context())
//            {
//                contexto.Entry(funcionario).State = EntityState.Modified;
//                contexto.Funcionarios.Update(funcionario);
//                contexto.SaveChanges();
//            }
//        }

//        public Funcionario Busca(string nome, string maquina)
//        {
//            using (var contexto = new Context())
//            {
//                return contexto.Funcionarios.FirstOrDefault(u => u.Nome == nome && u.Maquina == maquina);
//            }
//        }
//    }
//}
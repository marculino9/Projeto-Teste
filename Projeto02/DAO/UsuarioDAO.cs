//using Microsoft.EntityFrameworkCore;
//using Projeto02.Contexto;
//using Projeto02.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace Projeto02.DAO
//{
//    public class UsuarioDAO
//    {
//        public void Adiciona(Usuario usuario)
//        {
//            using (var context = new Context())
//            {
//                context.Add(usuario);
//                context.SaveChanges();
//            }
//        }

//        public void Remover(Usuario usuario)
//        {
//            using (var context = new Context())
//            {
//                context.Usuarios.Remove(usuario);
//                context.SaveChanges();
//            }
//        }

//        public IList<Usuario> Lista()
//        {
//            using (var contexto = new Context())
//            {
//                return contexto.Usuarios.ToList();
//            }
//        }

//        public Usuario BuscaPorId(int id)
//        {
//            using (var contexto = new Context())
//            {
//                return contexto.Usuarios.Find(id);
//            }
//        }

//        public void Atualiza(Usuario usuarios)
//        {
//            using (var contexto = new Context())
//            {
//                contexto.Entry(usuarios).State = EntityState.Modified;
//                contexto.Usuarios.Update(usuarios);
//                contexto.SaveChanges();
//            }
//        }

//        public Usuario Busca(string login, string senha)
//        {
//            using (var contexto = new Context())
//            {
//                return contexto.Usuarios.FirstOrDefault(u => u.Login == login && u.Senha == senha);
//            }
//        }

//        public Usuario BuscaPorIdWhere(int id)
//        {
//            using (var contexto = new Context())
//            {
//                return contexto.Usuarios.Where(u => u.Id == id).FirstOrDefault();
//            }
//        }
//    }
//}
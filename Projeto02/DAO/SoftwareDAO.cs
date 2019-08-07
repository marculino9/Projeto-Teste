//using Microsoft.EntityFrameworkCore;
//using Projeto02.Contexto;
//using Projeto02.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace Projeto02.DAO
//{
//    public class SoftwareDAO
//    {
//        public void Adiciona(Software software)
//        {
//            using (var context = new Context())
//            {
//                context.Softwares.Add(software);
//                context.SaveChanges();
//            }
//        }

//        public IList<Software> Lista()
//        {
//            using (var contexto = new Context())
//            {
//                return contexto.Softwares.Include("Categoria").ToList();
//            }
//        }

//        public Software BuscaPorId(int id)
//        {
//            using (var contexto = new Context())
//            {
//                return contexto.Softwares.Include("Categoria")
//                    .Where(p => p.Id == id)
//                    .FirstOrDefault();
//            }
//        }

//        //public void Atualiza(Software software)
//        //{
//        //    using (var contexto = new Context())
//        //    {
//        //        contexto.Entry(software).State = System.Data.Entity.EntityState.Modified;
//        //        contexto.SaveChanges();
//        //    }
//        //}
//    }
//}
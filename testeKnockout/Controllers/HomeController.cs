using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testeKnockout.Models;

namespace testeKnockout.Controllers
{
    public class HomeController : Controller
    {
        private ProdutoContex banco = new ProdutoContex();
                    
        public ActionResult Index()
        {
             return View();
        }

        public JsonResult GetLista()
        {
            return Json(banco.Produtos.ToList());
        }

        public ActionResult Create(Produtos p)
        {
            //db.Add(new { Nome = nome, Valor = valor });

            if (p.ID == -1)
            {
                banco.Produtos.Add(p);
                banco.SaveChanges();
            }
            else {

                var entity = banco.Produtos.FirstOrDefault(item => item.ID == p.ID);
                if (entity != null)
                {
                    entity.Nome = p.Nome;
                    entity.Valor = p.Valor;
                    banco.SaveChanges();
                }

            }
            return new HttpStatusCodeResult(200);
        }

        public ActionResult Editar(Produtos p)
        {
            //db.Add(new { Nome = nome, Valor = valor });

            //banco.Entry(p).State = EntityState.Modified;
            //banco.SaveChanges();

            return new HttpStatusCodeResult(200);
        }

        public ActionResult Apagar(Produtos p)
        {
           banco.Configuration.ValidateOnSaveEnabled = false;

            Produtos aux = banco.Produtos.Find(p.ID);
            banco.Produtos.Remove(aux);
            banco.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}
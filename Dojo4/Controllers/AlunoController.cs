using Dojo4.Models;
using Dojo4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Dojo4.Controllers
{
    public class AlunoController : Controller
    {
        private ApplicationDbContext _context;

        public AlunoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        //
        // GET: /Aluno/
        public ActionResult Index()
        {
            var aluno = _context.Alunos.Include(a => a.Faixa).Include(a => a.TipoDeAssociacao);
            return View(aluno);
        }

        public ActionResult Details(int id)
        {
            foreach (var aluno in _context.Alunos.ToList())
            {
                if (aluno.Id == id)
                {
                    return View(aluno);
                }
            }
            return HttpNotFound();
        }
    }
}
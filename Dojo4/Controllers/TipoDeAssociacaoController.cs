using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dojo4.Models;
using Dojo4.ViewModels;

namespace Dojo4.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {
        private ApplicationDbContext _context;

        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: /TipoDeAssociacao/
        public ActionResult Index()
        {
            var viewModel = _context.TipoDeAssociacoes.ToList();
            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            foreach (var tipo in _context.TipoDeAssociacoes.ToList())
            {
                if (tipo.Id == id)
                {
                    return View(tipo);
                }
            }
            return HttpNotFound();
        }
	}
}
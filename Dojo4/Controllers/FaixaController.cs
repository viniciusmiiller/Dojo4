using Dojo4.Models;
using Dojo4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dojo4.Controllers
{
    public class FaixaController : Controller
    {
        private ApplicationDbContext _context;

        public FaixaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //
        // GET: /Faixa/
        public ActionResult Index()
        {
            var viewModel = _context.Faixas.ToList();
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            foreach (var faixa in _context.Faixas.ToList())
            {
                if (faixa.Id == id)
                {
                    return View(faixa);
                }
            }
            return HttpNotFound();
        }
	}
}
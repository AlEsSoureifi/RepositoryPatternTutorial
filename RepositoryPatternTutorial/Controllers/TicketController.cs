using RepositoryPatternTutorial.Interfaces;
using RepositoryPatternTutorial.Services;
using RepositoryPatternTutorial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryPatternTutorial.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
        private readonly ITicketService _ticketService;
        private readonly FinancialsService _financialService;

        public TicketController()
        {
            _ticketService = new TicketService();
            _financialService = new FinancialsService();
        }

        public ActionResult Index()
        {
            var viewmodel = new TicketWithStatsViewModel();
            viewmodel.TicketsSold = _ticketService.GetAllSold();
            viewmodel.Stats = _financialService.GetStats();

            return View(viewmodel);
        }
    }
}
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
    public class FoodController : Controller
    {
        // GET: Food
        private readonly IFoodService _foodService;
        private readonly FinancialsService _financialService;


        public FoodController()
        {
            _foodService = new FoodService();
            _financialService = new FinancialsService();
        }

        public ActionResult Index()
        {
            var viewModel = new FoodWithStatsViewModel();
            viewModel.Stats = _financialService.GetStats();
            viewModel.FoodItemsSold = _foodService.GetAllSold();
            
            return View(viewModel);
        }
    }
}
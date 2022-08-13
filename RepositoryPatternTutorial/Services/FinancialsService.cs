using RepositoryPatternTutorial.Interfaces;
using RepositoryPatternTutorial.Models;
using RepositoryPatternTutorial.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternTutorial.Services
{
    public class FinancialsService : IFinancialService
    {
        private readonly ITicketRepository _ticketRepo;
        private readonly IFoodRepository _foodRepo;

        public FinancialsService()
        {
            _ticketRepo = new TicketRepository();
            _foodRepo = new FoodRepository();
        }

        public FinancialStats GetStats()
        {
            FinancialStats stats = new FinancialStats();
            var foodSold = _foodRepo.GetAllSold();
            var ticketsSold = _ticketRepo.GetAllSold();

            //Calculate Average Stats
            stats.AverageTicketProfit =
              ticketsSold.Sum(x => x.Profit) / ticketsSold.Sum(x => x.Quantity);
            stats.AverageFoodItemProfit =
              foodSold.Sum(x => x.Profit) / foodSold.Sum(x => x.Quantity);

            return stats;
        }
    }
}
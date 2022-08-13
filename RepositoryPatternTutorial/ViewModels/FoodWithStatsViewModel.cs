using RepositoryPatternTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternTutorial.ViewModels
{
    public class FoodWithStatsViewModel
    {
        public ICollection<FoodItem> FoodItemsSold { get; set; }
        public FinancialStats Stats { get; set; }

    }
}
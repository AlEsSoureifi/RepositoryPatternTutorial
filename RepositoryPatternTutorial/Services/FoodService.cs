using RepositoryPatternTutorial.Interfaces;
using RepositoryPatternTutorial.Models;
using RepositoryPatternTutorial.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternTutorial.Services
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepo;

        public FoodService()
        {
            _foodRepo = new FoodRepository();
        }

        public List<FoodItem> GetAllSold() => _foodRepo.GetAllSold();
    }
}
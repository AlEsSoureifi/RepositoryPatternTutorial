using RepositoryPatternTutorial.Interfaces;
using RepositoryPatternTutorial.Models;
using RepositoryPatternTutorial.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternTutorial.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepo;

        public TicketService()
        {
            _ticketRepo = new TicketRepository();
        }

        public List<Ticket> GetAllSold() => _ticketRepo.GetAllSold();
    }
}
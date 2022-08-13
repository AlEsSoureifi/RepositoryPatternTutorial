using RepositoryPatternTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternTutorial.ViewModels
{
    public class TicketWithStatsViewModel
    {
        public ICollection<Ticket> TicketsSold { get; set; }
        public FinancialStats Stats { get; set; }
    }
}
using RepositoryPatternTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternTutorial.Interfaces
{
    public interface ITicketService
    {
        List<Ticket> GetAllSold();
    }
}

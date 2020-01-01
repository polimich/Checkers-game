using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers_game.Models
{
    public class ApplicationUser : IdentityDbContext
    {
        public int GameId { get; set; }
        public int PlayerNumber { get; set; }
    }
}

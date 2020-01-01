using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checkers_game.Data;
using Checkers_game.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Checkers_game.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<PrivacyModel> _logger;
        public PrivacyModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Board> Boards { get; set; }
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            Boards = await _db.Boards.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Coborzan_Tudor_Lab2.Data;
using Coborzan_Tudor_Lab2.Models;

namespace Coborzan_Tudor_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Coborzan_Tudor_Lab2.Data.Coborzan_Tudor_Lab2Context _context;

        public IndexModel(Coborzan_Tudor_Lab2.Data.Coborzan_Tudor_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}

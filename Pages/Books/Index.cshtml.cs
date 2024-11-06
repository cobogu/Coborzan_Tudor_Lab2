using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Coborzan_Tudor_Lab2.Data;
using Coborzan_Tudor_Lab2.Models;

namespace Coborzan_Tudor_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Coborzan_Tudor_Lab2.Data.Coborzan_Tudor_Lab2Context _context;

        public IndexModel(Coborzan_Tudor_Lab2.Data.Coborzan_Tudor_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}

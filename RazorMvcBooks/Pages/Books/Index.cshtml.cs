using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMvcBooks.Models;

namespace RazorMvcBooks.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly RazorMvcBooks.Models.BookContext _context;

        public IndexModel(RazorMvcBooks.Models.BookContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}

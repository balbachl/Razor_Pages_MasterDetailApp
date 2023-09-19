using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JellyPagesMasterDetailApp.Data;
using JellyPagesMasterDetailApp.Models;

namespace JellyPagesMasterDetailApp.Pages.Shane
{
    public class IndexModel : PageModel
    {
        private readonly JellyPagesMasterDetailApp.Data.JellyPagesMasterDetailAppContext _context;

        public IndexModel(JellyPagesMasterDetailApp.Data.JellyPagesMasterDetailAppContext context)
        {
            _context = context;
        }

        public IList<Phonebook> Phonebook { get;set; }

        public async Task OnGetAsync()
        {
            Phonebook = await _context.Phonebook.ToListAsync();
        }
    }
}

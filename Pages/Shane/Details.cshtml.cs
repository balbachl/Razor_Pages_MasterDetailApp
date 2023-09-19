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
    public class DetailsModel : PageModel
    {
        private readonly JellyPagesMasterDetailApp.Data.JellyPagesMasterDetailAppContext _context;

        public DetailsModel(JellyPagesMasterDetailApp.Data.JellyPagesMasterDetailAppContext context)
        {
            _context = context;
        }

        public Phonebook Phonebook { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Phonebook = await _context.Phonebook.FirstOrDefaultAsync(m => m.ID == id);

            if (Phonebook == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

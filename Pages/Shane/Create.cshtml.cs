using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JellyPagesMasterDetailApp.Data;
using JellyPagesMasterDetailApp.Models;

namespace JellyPagesMasterDetailApp.Pages.Shane
{
    public class CreateModel : PageModel
    {
        private readonly JellyPagesMasterDetailApp.Data.JellyPagesMasterDetailAppContext _context;

        public CreateModel(JellyPagesMasterDetailApp.Data.JellyPagesMasterDetailAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Phonebook Phonebook { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Phonebook.Add(Phonebook);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

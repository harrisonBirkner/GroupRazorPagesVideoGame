using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GroupRazorPagesVideoGame.Data;
using GroupRazorPagesVideoGame.Models;

namespace GroupRazorPagesVideoGame.Pages.CustomerInfos
{
    public class CreateModel : PageModel
    {
        private readonly GroupRazorPagesVideoGame.Data.GroupRazorPagesVideoGameContext _context;

        public CreateModel(GroupRazorPagesVideoGame.Data.GroupRazorPagesVideoGameContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CustomerInfo CustomerInfo { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CustomerInfo.Add(CustomerInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

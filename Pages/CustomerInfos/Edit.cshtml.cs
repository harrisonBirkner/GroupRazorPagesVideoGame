using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroupRazorPagesVideoGame.Data;
using GroupRazorPagesVideoGame.Models;

namespace GroupRazorPagesVideoGame.Pages.CustomerInfos
{
    public class EditModel : PageModel
    {
        private readonly GroupRazorPagesVideoGame.Data.GroupRazorPagesVideoGameContext _context;

        public EditModel(GroupRazorPagesVideoGame.Data.GroupRazorPagesVideoGameContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CustomerInfo CustomerInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CustomerInfo = await _context.CustomerInfo.FirstOrDefaultAsync(m => m.ID == id);

            if (CustomerInfo == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CustomerInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerInfoExists(CustomerInfo.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CustomerInfoExists(int id)
        {
            return _context.CustomerInfo.Any(e => e.ID == id);
        }
    }
}

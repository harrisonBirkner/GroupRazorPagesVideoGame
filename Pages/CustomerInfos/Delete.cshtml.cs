using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GroupRazorPagesVideoGame.Data;
using GroupRazorPagesVideoGame.Models;

namespace GroupRazorPagesVideoGame.Pages.CustomerInfos
{
    public class DeleteModel : PageModel
    {
        private readonly GroupRazorPagesVideoGame.Data.GroupRazorPagesVideoGameContext _context;

        public DeleteModel(GroupRazorPagesVideoGame.Data.GroupRazorPagesVideoGameContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CustomerInfo = await _context.CustomerInfo.FindAsync(id);

            if (CustomerInfo != null)
            {
                _context.CustomerInfo.Remove(CustomerInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

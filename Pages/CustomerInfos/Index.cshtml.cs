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
    public class IndexModel : PageModel
    {
        private readonly GroupRazorPagesVideoGame.Data.GroupRazorPagesVideoGameContext _context;

        public IndexModel(GroupRazorPagesVideoGame.Data.GroupRazorPagesVideoGameContext context)
        {
            _context = context;
        }

        public IList<CustomerInfo> CustomerInfo { get;set; }

        public async Task OnGetAsync()
        {
            CustomerInfo = await _context.CustomerInfo.ToListAsync();
        }
    }
}

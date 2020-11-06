using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Soft.Data;

namespace Soft.Tests.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Soft.Data.SoftContext _context;

        public IndexModel(Soft.Data.SoftContext context)
        {
            _context = context;
        }

        public IList<TestData> TestData { get;set; }

        public async Task OnGetAsync()
        {
            TestData = await _context.TestData.ToListAsync();
        }
    }
}

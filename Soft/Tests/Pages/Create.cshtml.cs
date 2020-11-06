﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Soft.Data;

namespace Soft.Tests.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Soft.Data.SoftContext _context;

        public CreateModel(Soft.Data.SoftContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TestData TestData { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TestData.Add(TestData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using razors_beginner.Models;
using razors_beginner.Repo;

namespace razors_beginner.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public Category Category { get; set; } = default!;

        public EditModel(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> OnGetAsync(int? id)
        {
            ViewData["Title"] = "Edit";
            if (id == null)
            {
                return NotFound();
            }

            var category =  await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            Category = category;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Category).State = EntityState.Modified; 
            if (!CategoryExists(Category.Id))
            {
                return NotFound();
            }
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZooCode.Data;
using ZooCode.Models;

namespace ZooCode.Pages.ZooAnimals
{
    public class DeleteModel : PageModel
    {
        private readonly ZooCode.Data.ZooProjectContext _context;

        public DeleteModel(ZooCode.Data.ZooProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ZooAnimal ZooAnimal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ZooAnimal = await _context.ZooAnimal
                .Include(z => z.Animal)
                .Include(z => z.Zoo).FirstOrDefaultAsync(m => m.ZooAnimalID == id);

            if (ZooAnimal == null)
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

            ZooAnimal = await _context.ZooAnimal.FindAsync(id);

            if (ZooAnimal != null)
            {
                _context.ZooAnimal.Remove(ZooAnimal);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

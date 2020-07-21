using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using toDoApp.Data;
using toDoApp.Models;

namespace toDoApp.Pages.ToDos
{
    public class EditModel : PageModel
    {
        private readonly toDoApp.Data.ToDoContext _context;

        public EditModel(toDoApp.Data.ToDoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ToDoItem ToDoItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDoItem = await _context.ToDoItem.FirstOrDefaultAsync(m => m.id == id);

            if (ToDoItem == null)
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

            _context.Attach(ToDoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoItemExists(ToDoItem.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("../Index");
        }

        private bool ToDoItemExists(int id)
        {
            return _context.ToDoItem.Any(e => e.id == id);
        }
    }
}

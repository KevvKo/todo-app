using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using toDoApp.Data;
using toDoApp.Models;

namespace toDoApp.Pages.ToDos
{
    public class CreateModel : PageModel
    {
        private readonly toDoApp.Data.ToDoContext _context;

        public CreateModel(toDoApp.Data.ToDoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ToDoItem ToDoItem { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ToDoItem.Add(ToDoItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        }
    }
}

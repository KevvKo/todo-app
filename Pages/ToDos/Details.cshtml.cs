using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using toDoApp.Data;
using toDoApp.Models;

namespace toDoApp.Pages.ToDos
{
    public class DetailsModel : PageModel
    {
        private readonly toDoApp.Data.ToDoContext _context;

        public DetailsModel(toDoApp.Data.ToDoContext context)
        {
            _context = context;
        }

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
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using toDoApp.Models;

namespace toDoApp.Pages.ToDos
{
    public class IndexModel : PageModel
    {
        private readonly toDoApp.Data.ToDoContext _context;

        public IndexModel(toDoApp.Data.ToDoContext context)
        {
            _context = context;
        }

        public IList<ToDoItem> ToDoList { get;set; }

        [BindProperty]
        public ToDoItem ToDoForm { get; set; }

        // will be executed, if 
        public async Task OnGetAsync()
        {   
            
            ToDoList = await _context.ToDoItem.ToListAsync();
        }

        // will be executed, after the form was submitted for a new toDo
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //process to handle a given id and delete the toDoItem
            if (id != null)
            {   

                if (id == null){
                    return NotFound();
                }
    
                ToDoForm = await _context.ToDoItem.FindAsync(id);

                if (ToDoForm != null)
                {
                    _context.ToDoItem.Remove(ToDoForm);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("/Index");
                }
            }

            //if no item should be delete, add the new toDoitem
            ToDoForm.isDone = false;
            _context.ToDoItem.Add(ToDoForm);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}

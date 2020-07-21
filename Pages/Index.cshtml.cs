using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public IList<ToDoItem> ToDoItem { get;set; }

        public async Task OnGetAsync()
        {
            ToDoItem = await _context.ToDoItem.ToListAsync();
        }

    }
}

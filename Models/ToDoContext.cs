using Microsoft.EntityFrameworkCore;

namespace toDoApp.Data{
    public class ToDoContext : DbContext{
        public ToDoContext (
            DbContextOptions <ToDoContext> options)
            : base(options)
        {
        }

        public DbSet<toDoApp.Models.ToDoItem> ToDoItem { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;

namespace TodoApp.Models{
    //ToDoContext manage the relative database and inserts the tasks
    public class ToDoContext : DbContext{
        public ToDoContext(DbContextOptions <ToDoContext> options) : base(options){

        }

        public DbSet <ToDoItem> ToDoItems {get; set;}
    }
}
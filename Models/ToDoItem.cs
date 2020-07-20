using System;
using System.ComponentModel.DataAnnotations;

namespace toDoApp.Models{
    public class ToDoItem{
        public int id { get; set; }
        public string name { get; set; }
        public bool isDone {get; set;  }
        
        [DataType(DataType.Date)]
        public DateTime creationDate { get; set; }

    }
}
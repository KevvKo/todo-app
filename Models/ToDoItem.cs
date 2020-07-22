using System;
using System.ComponentModel.DataAnnotations;

namespace toDoApp.Models{
    public class ToDoItem{
        public int id { get; set; }

        [Display(Name = "To Do")]
        public string name { get; set; }

        [Display(Name = "Status")]
        public bool isDone {get; set;  }
        
        [Required (ErrorMessage = "A date by when it has be done is required.")]
        [Display(Name = "To do date")]
        [DataType(DataType.Date)]
        public DateTime creationDate { get; set; }

    }
}
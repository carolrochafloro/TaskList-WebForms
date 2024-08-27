using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebFormsPractice.Models
{
    public class TasksContext :  DbContext
    {
        public TasksContext() : base("WebFormsPractice") { }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; } 
    }
}
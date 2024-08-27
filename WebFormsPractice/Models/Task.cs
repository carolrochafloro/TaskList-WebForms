using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebFormsPractice.Models
{
    public class Task
    {
        [ScaffoldColumn(false)]
        public Guid Id { get; set; }
        [Required, StringLength(100), Display(Name = "Task")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name = "Completed")]
        public bool IsCompleted { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
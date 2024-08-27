using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebFormsPractice.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public Guid Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }


    }
}
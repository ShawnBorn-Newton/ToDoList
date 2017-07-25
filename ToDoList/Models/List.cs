﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class List
    {
        [Key]
        public int ListID { get; set; }
        public string ListTitle { get; set; }
        public DateTime ListCreatDate { get; set; }

        [Display(Name = "List")]
        public string Name { get; set; }
        public virtual ICollection<Task> IsDone { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public partial class Users
    {
        public Users()
        {
            TodoItems = new HashSet<TodoItems>();
        }

        public int IdUser { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TodoItems> TodoItems { get; set; }
    }
}
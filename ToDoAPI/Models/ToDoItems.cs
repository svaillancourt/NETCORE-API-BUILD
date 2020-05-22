
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAPI.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool Completed { get; set; }
    }
}
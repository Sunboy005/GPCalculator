using AppModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppData.InMemory
{
    interface InMemoryStore
    {
        public static List<Courses> Courses { get; set; } = new List<Courses>();

       // public static List<Grades> IdCards { get; set; } = new List<Grade>();
    }
}

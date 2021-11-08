using AppModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppData.InMemory
{
    interface InMemoryStore
    {
        public static List<Course> Courses { get; set; } = new List<Course>();

     
    }
}

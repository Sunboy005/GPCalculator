using AppLibrary.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.Services.Interfaces
{
    interface ICourse
    {
        public bool Save(CoursesToAdd model);
        public void ListCourses();
    }
}

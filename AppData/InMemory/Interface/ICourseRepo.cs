using System.Collections.Generic;
using AppModel.Models;

namespace AppData.InMemory.Interface
{
    public interface ICourseRepo:ICRUDRepo
    {
        Course SelectCourse(string Id);
        List<Course> SelectUsers();
    }
}
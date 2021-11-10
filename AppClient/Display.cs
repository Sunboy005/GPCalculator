using AppLibrary.Services.Implementations;
using System;

namespace AppClient
{
    internal class Display
    {
        public void GetResult()
        {
            var inputrecord = new InputRecord();
            var calculator = new Calculations();
            var Content = inputrecord.NewCourseConstruct(inputrecord.GetData());
            var GPAVal = calculator.GPACalc(Content);
            Console.WriteLine("-|-----------------|-----------------|-----------------|----------------------|");
            Console.WriteLine("-|  Course &Code   |   Course Unit   |       Grade     |      Grade Unit      |");
            Console.WriteLine("-|-----------------|-----------------|-----------------|----------------------|");

            foreach (var item in Content)
            {
                Console.WriteLine($"-|      {item.CourseName}     |        {item.CourseUnit}        |         {item.Grade}       |           {item.GradePoint}          |");
                Console.WriteLine("-|-----------------|-----------------|-----------------|----------------------|");
            }
            Console.WriteLine($"Your GPA is {GPAVal.ToString("0.00")}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.Services.Interfaces
{
    interface ICalculations : ICourse
    {

        public string GetGrade(int score, int courseUnit);
    }
}

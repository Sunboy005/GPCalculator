using AppLibrary.Services.Implementations;
using AppModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.Services.Interfaces
{
    interface ICalculations
    {

        public double GPACalc(List<Course> newModel);
    }
}

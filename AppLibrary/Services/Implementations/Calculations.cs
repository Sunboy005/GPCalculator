using AppLibrary.Services.Interfaces;
using AppModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.Services.Implementations
{
    public class Calculations:ICalculations
    {
        public double GPACalc(List<Course> newModel)
        {
            double TotalQP = 0;
            double TotalGP = 0;
            foreach (var item in newModel)
            {
                TotalQP += item.QualityPoint;
                TotalGP += item.GradePoint;
            }
            return TotalQP / TotalGP; ;
        }

    }
}

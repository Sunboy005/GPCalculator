using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.Services.Implementations
{
    static class Calculation
    {
        static string GetGrade(int score, int courseUnit)
        {
            string Grade;
            int scoredUnit;
            if (score >= 70)
            {
                Grade = "A";
                scoredUnit = 5;
            }
            else if (score >= 60)
            {
                Grade = "B";
                scoredUnit = 4;
            }
            else if (score >= 50)
            {
                Grade = "C";
                scoredUnit = 3;
            }
            else if (score >= 45)
            {
                Grade = "D";
                scoredUnit = 2;
            }
            else if (score >= 40)
            {
                Grade = "E";
                scoredUnit = 1;
            }
            else
            {
                Grade = "F";
                scoredUnit = 0;
            }
            int qualityPoint= scoredUnit * courseUnit;
            //List<int> scoredUnitList = new List<int> { };
            //scoredUnitList.Add(scoredUnit);
            return Grade;
        }

    }
}

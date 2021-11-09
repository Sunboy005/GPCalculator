namespace Commons
{
    public static class Utils
    {

        public static char GetGrade(int score)
        {
            char Grade;

            if (score >= 70)
            {
                Grade = 'A';
            }
            else if (score >= 60)
            {
                Grade = 'B';
            }
            else if (score >= 50)
            {
                Grade = 'C';
            }
            else if (score >= 45)
            {
                Grade = 'D';
            }
            else if (score >= 40)
            {
                Grade = 'E';
            }
            else
            {
                Grade = 'F';
            }
            return Grade;
        }

        public static int GetGradeUnit(char Grade)
        {
            if (Grade == 'A') return 5;
            
            if (Grade == 'B') return  4;

            if (Grade == 'C') return 3;

            if (Grade == 'D') return 2;
            
            if (Grade == 'E') return 1;
            
            return 0;
        }

    }
}

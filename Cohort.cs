using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public string CohortName { get; set; }
        public List<string> Students = new List<string>();
        public List<string> Instructors = new List<string>();

        public Cohort(string cohortname)
        {
            CohortName = cohortname;
        }

    }
}
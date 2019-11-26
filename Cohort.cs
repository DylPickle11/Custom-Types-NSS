using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public string CohortName { get; set; }
        public List<Student> Students = new List<Student>();
        public List<string> Instructors = new List<string>();

        public Cohort(string cohortname)
        {
            CohortName = cohortname;
        }

    }
}
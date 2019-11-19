using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int CohortNumber { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();

        public Student(string first, string last, string slack, int num)
        {
            FirstName = first;
            LastName = last;
            SlackHandle = slack;
            CohortNumber = num;
        }
    }
}
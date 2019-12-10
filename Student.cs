using System.Collections.Generic;

namespace StudentExercises
{
    public class Student : NSSPerson P
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override string SlackHandle { get; set; }
        public override int CohortNumber { get; set; }
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
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int CohortNumber { get; set; }
        public string Speciality { get; set; }
        public void assign(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }

        public Instructor(string first, string last, string slack, int num, string special)
        {
            FirstName = first;
            LastName = last;
            SlackHandle = slack;
            CohortNumber = num;
            Speciality = special;

        }

    }
}
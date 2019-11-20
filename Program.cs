using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            List<Exercise> exercises = new List<Exercise>();

            //  Create 4, or more, exercises.
            Exercise exercise1 = new Exercise("Website", "HTML");
            Exercise exercise2 = new Exercise("Paint by Number", "CSS");
            Exercise exercise3 = new Exercise("Nutshell", "Javascript");
            Exercise exercise4 = new Exercise("Planets", "C#");

            // Create 3, or more, cohorts.
            Cohort cohort1 = new Cohort("Cohort 76");
            Cohort cohort2 = new Cohort("Cohort 77");
            Cohort cohort3 = new Cohort("Cohort 78");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student student1 = new Student("Sam", "Samson", "SamSam", 77);
            Student student2 = new Student("Kim", "Kimson", "KimKim", 78);
            Student student3 = new Student("Bob", "Bobson", "BobBob", 76);
            Student student4 = new Student("Ned", "Nedson", "NedNed", 77);

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor instructor1 = new Instructor("Mo", "Moson", "MoMo", 77, "Being Mo-mazing");
            Instructor instructor2 = new Instructor("Madie", "Madson", "MadMad", 78, "Being Mad-mazing");
            Instructor instructor3 = new Instructor("Adam", "Adamson", "AdAd", 77, "Being Ad-mazing");
            Instructor instructor4 = new Instructor("Brenda", "Brendson", "BrenBren", 76, "Being Bren-mazing");

            // Have each instructor assign 2 exercises to each of the students.
            instructor1.assign(student1, exercise1);
            instructor1.assign(student1, exercise3);
            instructor1.assign(student4, exercise2);
            instructor1.assign(student4, exercise4);

            instructor2.assign(student2, exercise2);
            instructor2.assign(student2, exercise4);

            instructor3.assign(student1, exercise2);
            instructor3.assign(student1, exercise4);
            instructor3.assign(student4, exercise3);
            instructor3.assign(student4, exercise1);

            instructor4.assign(student2, exercise1);
            instructor4.assign(student2, exercise3);

            students.ForEach(student =>
            {
                // for each  over exercises pushed up
                // look at the contains methods

                student.Exercises.ForEach(exercise =>
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is working on exercises {exercise.Name}");
                });

            });

        }
    }
}
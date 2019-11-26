using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            List<Exercise> exercises = new List<Exercise>();
            List<Instructor> instructors = new List<Instructor>();
            List<Cohort> cohorts = new List<Cohort>();

            //  Create 4, or more, exercises.
            Exercise exercise1 = new Exercise("Website", "HTML");
            Exercise exercise2 = new Exercise("Paint by Number", "CSS");
            Exercise exercise3 = new Exercise("Nutshell", "Javascript");
            Exercise exercise4 = new Exercise("Planets", "C#");
            Exercise exercise5 = new Exercise("OverlyExcited", "C#");
            Exercise exercise6 = new Exercise("SolarSystem", "C#");
            Exercise exercise7 = new Exercise("Carlot", "C#");
            Exercise exercise8 = new Exercise("DyanmicCards", "C#");
            exercises.Add(exercise1);
            exercises.Add(exercise2);
            exercises.Add(exercise3);
            exercises.Add(exercise4);
            exercises.Add(exercise5);
            exercises.Add(exercise6);
            exercises.Add(exercise7);
            exercises.Add(exercise8);

            // Create 3, or more, cohorts.
            Cohort cohort1 = new Cohort("Cohort 76");
            Cohort cohort2 = new Cohort("Cohort 77");
            Cohort cohort3 = new Cohort("Cohort 78");
            cohorts.Add(cohort1);
            cohorts.Add(cohort2);
            cohorts.Add(cohort3);


            // Create 4, or more, students and assign them to one of the cohorts.
            Student student1 = new Student("Sam", "Samson", "SamSam", 77);
            Student student2 = new Student("Kim", "Kimson", "KimKim", 78);
            Student student3 = new Student("Bob", "Bobson", "BobBob", 76);
            Student student4 = new Student("Ned", "Nedson", "NedNed", 77);
            Student student5 = new Student("Larry", "Larson", "LarLar", 77);
            Student student6 = new Student("Kristin", "Kristson", "KrisKris", 78);
            Student student7 = new Student("Loshanna", "Losson", "LosLos", 76);
            Student student8 = new Student("Tre", "Treson", "TreTre", 77);

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);
            students.Add(student7);
            students.Add(student8);

            cohort2.Students.Add(student1);
            cohort3.Students.Add(student2);
            cohort1.Students.Add(student3);
            cohort2.Students.Add(student4);
            cohort2.Students.Add(student5);
            cohort3.Students.Add(student6);
            cohort1.Students.Add(student7);
            cohort2.Students.Add(student8);


            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor instructor1 = new Instructor("Mo", "Moson", "MoMo", 77, "Being Mo-mazing");
            Instructor instructor2 = new Instructor("Madie", "Madson", "MadMad", 78, "Being Mad-mazing");
            Instructor instructor3 = new Instructor("Adam", "Adamson", "AdAd", 77, "Being Ad-mazing");
            Instructor instructor4 = new Instructor("Brenda", "Brendson", "BrenBren", 76, "Being Bren-mazing");

            instructors.Add(instructor1);
            instructors.Add(instructor2);
            instructors.Add(instructor3);
            instructors.Add(instructor4);


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
            instructor4.assign(student2, exercise4);
            instructor4.assign(student2, exercise5);
            instructor4.assign(student2, exercise6);

            // students.ForEach(student =>
            // {
            //     // for each  over exercises pushed up
            //     // look at the contains methods

            //     student.Exercises.ForEach(exercise =>
            //     {
            //         Console.WriteLine($"{student.FirstName} {student.LastName} is working on exercises {exercise.Name}");
            //     });

            // });


            /////////////////////////////////////////////////////////
            //**************Student Exercise/Part2****************//
            ///////////////////////////////////////////////////////

            // List exercises for the JavaScript language by using the Where() LINQ method.

            List<Exercise> javascriptExercise = exercises.Where(exercise => exercise.Language == "Javascript").ToList();

            javascriptExercise.ForEach(exercise =>
            {
                Console.WriteLine($"Javascript Exercise: {exercise.Name}");
            });
            Console.WriteLine("/////////////////////////////////////");

            // List students in a particular cohort by using the Where() LINQ method.
            List<Cohort> cohortNumber = cohorts.Where(cohort => cohort.CohortName == "Cohort 76").ToList();


            cohortNumber.ForEach(cohort =>
            {
                Console.WriteLine($"Cohort group: {cohort.CohortName}");

                cohort.Students.ForEach(student =>
                {
                    Console.WriteLine($"Students:{student.FirstName} {student.LastName}");
                });
            });
            Console.WriteLine("/////////////////////////////////////");

            // List instructors in a particular cohort by using the Where() LINQ method.
            List<Instructor> cohortInstructor = instructors.Where(instructor => instructor.CohortNumber == 77).ToList();

            cohortInstructor.ForEach(instructor =>
                       {
                           Console.WriteLine($"Instructors in {instructor.CohortNumber}: {instructor.FirstName} {instructor.LastName}");
                       });

            Console.WriteLine("/////////////////////////////////////");
            // Sort the students by their last name.

            List<Student> Lstudent = students.Where(student => student.LastName.StartsWith("L")).ToList();

            Lstudent.ForEach(student =>
            {
                Console.WriteLine($"Lstudents: {student.LastName}, {student.FirstName}");
            });
            Console.WriteLine("/////////////////////////////////////");

            // Display any students that aren't working on any exercises

            List<Student> noExercises = students.Where(student => student.Exercises.Count == 0).ToList();

            noExercises.ForEach(student =>
            {
                Console.WriteLine($"All Students without an exercise: {student.LastName}, {student.FirstName}");
            });
            Console.WriteLine("/////////////////////////////////////");

            // Which student is working on the most exercises?

            List<Student> mostExercises = students.Where(student => student.Exercises.Count > 0).ToList();

            var busiestStudents = mostExercises.OrderBy(student => student.Exercises.Count).Last();
            Console.WriteLine($"Student with most exercises: {busiestStudents.FirstName} {busiestStudents.LastName}");
            Console.WriteLine("/////////////////////////////////////");

            // How many students in each cohort?
            var byCohort = students.GroupBy(student => student.CohortNumber).ToList();
            var byCohortCount = byCohort.Count;
            Console.WriteLine(byCohortCount);


            byCohort.ForEach(cohort =>
            {
                Console.WriteLine($"There are {cohort.Count()} students in cohort {cohort.Key}");
            });


        }
    }
}
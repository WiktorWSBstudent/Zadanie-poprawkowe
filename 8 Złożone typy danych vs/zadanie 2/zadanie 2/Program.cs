using System;

namespace Zad2
{
    struct Student
    {
        public int StudentID;
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;
        public string Major;
    }

    struct Subject
    {
        public string Name;
        public int Credits;
        public string Department;
    }

    struct AcademicTeacher
    {
        public int TeacherID;
        public string FirstName;
        public string LastName;
        public string Department;
        public string Title;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1;
            student1.StudentID = 12345;
            student1.FirstName = "Grzegorz";
            student1.LastName = "Brzęczyszczykiewicz";
            student1.BirthDate = new DateTime(2000, 5, 10);
            student1.Major = "Informatyka";

            Subject subject1;
            subject1.Name = "Podstawy programowania";
            subject1.Credits = 3;
            subject1.Department = "Informatyka";

            AcademicTeacher teacher1;
            teacher1.TeacherID = 54321;
            teacher1.FirstName = "Hans";
            teacher1.LastName = "Gutfreund";
            teacher1.Department = "Informatyka";
            teacher1.Title = "Profesor";

            Console.WriteLine("Informacje studenta:");
            Console.WriteLine($"ID: {student1.StudentID}");
            Console.WriteLine($"Imię: {student1.FirstName} {student1.LastName}");
            Console.WriteLine($"Data urodzenia: {student1.BirthDate}");
            Console.WriteLine($"Kierunek: {student1.Major}");

            Console.WriteLine("\nInformacje o przedmiocie:");
            Console.WriteLine($"Przedmiot: {subject1.Name}");
            Console.WriteLine($"ECTS: {subject1.Credits}");
            Console.WriteLine($"Wydział: {subject1.Department}");

            Console.WriteLine("\nInformacje nauczyciela:");
            Console.WriteLine($"ID: {teacher1.TeacherID}");
            Console.WriteLine($"Imię: {teacher1.FirstName} {teacher1.LastName}");
            Console.WriteLine($"Wydział: {teacher1.Department}");
            Console.WriteLine($"Tytuł: {teacher1.Title}");
        }
    }
}
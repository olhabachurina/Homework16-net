// See https://aka.ms/new-console-template for more information
using Homework16_net;
using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Exersice 2");
        string[] cities = { "Ananyev", "Mirgorod", "Nemirov", "Mukachevo", "Novovolynsk", "Andrusevka","Sarata","Novovdnistrovsk", "Arcyz","Nicolaev" };

       
        var allCities = cities;
            
        int targetLength = 6;
        var citiesWithTargetLength = cities.Where(city => city.Length == targetLength);

       
        var citiesStartingWithA = cities.Where(city => city.StartsWith("A", StringComparison.OrdinalIgnoreCase));
                
        var citiesEndingWithM = cities.Where(city => city.EndsWith("M", StringComparison.OrdinalIgnoreCase));

        
        var citiesStartingWithNAndEndingWithK = cities.Where(city => city.StartsWith("N", StringComparison.OrdinalIgnoreCase) && city.EndsWith("K", StringComparison.OrdinalIgnoreCase));

        var citiesStartingWithNeDescending = cities
            .Where(city => city.StartsWith("Ne", StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(city => city);

       
        Console.WriteLine("All cities: " + string.Join(", ", allCities));
        Console.WriteLine($"Cities with length {targetLength}: " + string.Join(", ", citiesWithTargetLength));
        Console.WriteLine("Cities starting with A: " + string.Join(", ", citiesStartingWithA));
        Console.WriteLine("Cities ending with M: " + string.Join(", ", citiesEndingWithM));
        Console.WriteLine("Cities starting with N and ending with K: " + string.Join(", ", citiesStartingWithNAndEndingWithK));
        Console.WriteLine("Cities starting with Ne, sorted descending: " + string.Join(", ", citiesStartingWithNeDescending));
        Console.WriteLine("Exersice 3");


        List<Student> students = new List<Student>
            {
                new Student { FirstName = "Petro", LastName = "Dovbush", Age = 19, University = "OMNU" },
                new Student { FirstName = "Boris", LastName = "Petrenko", Age = 20, University = "Oxford" },
                new Student { FirstName = "Olha", LastName = "Rubak", Age = 18, University = "OMNU" },
                new Student { FirstName = "Oksana", LastName = "Savina", Age = 18, University = "Oxford" },
                new Student { FirstName = "Natalya", LastName = "Shevchenko", Age = 21, University = "ONEU" },
                new Student { FirstName = "Boris", LastName = "Boronin", Age = 22, University = "Oxford" },
            };

        var allStudents = students;
        var borisStudents = students.Where(student => student.FirstName == "Boris").ToList();
        var broStudents = students.Where(student => student.LastName.StartsWith("Bro")).ToList();
        var olderThan19 = students.Where(student => student.Age > 19).ToList();
        var between20and23 = students.Where(student => student.Age > 20 && student.Age < 23).ToList();
        var mitStudents = students.Where(student => student.University == "OMNU").ToList();
        var oxfordStudentsOver18 = students
            .Where(student => student.University == "Oxford" && student.Age > 18)
            .OrderByDescending(student => student.Age)
            .ToList();

        // Вывод результатов
        Console.WriteLine("All students: ");
        PrintStudents(allStudents);

        Console.WriteLine("\nBoris students: ");
        PrintStudents(borisStudents);

        Console.WriteLine("\nBro students: ");
        PrintStudents(broStudents);

        Console.WriteLine("\nOlder than 19 students: ");
        PrintStudents(olderThan19);

        Console.WriteLine("\nBetween 20 and 23 students: ");
        PrintStudents(between20and23);

        Console.WriteLine("\nOMNU students: ");
        PrintStudents(mitStudents);

        Console.WriteLine("\nOxford students over 18, sorted descending: ");
        PrintStudents(oxfordStudentsOver18);
    }

    static void PrintStudents(List<Student> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.FirstName} {student.LastName}, Age: {student.Age}, University: {student.University}");
        }
    }
}

    

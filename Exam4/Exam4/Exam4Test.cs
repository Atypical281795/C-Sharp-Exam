using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

class Exam4Test
{
    static void Main()
    {
        Exam4 std1 = new Exam4("A01","Mary",60,90);
        Exam4 std2 = new Exam4("A02", "John", 80,70);

        Console.WriteLine("Student information");
        Console.WriteLine($"Student ID: {std1.Id}");
        Console.WriteLine($"Student Name: {std1.Name}");
        Console.WriteLine($"Subject1: {std1.Score1}");
        Console.WriteLine($"Subject2: {std1.Score2}");
        Console.WriteLine($"Aggregate: {std1.GetAggregate()}");
        Console.WriteLine($"Percentage: {std1.GetPercentage():F}\n");

        std1.Id = "A110";
        std1.Score1 = 120;
        Console.WriteLine("Student with changed information");
        Console.WriteLine($"Student ID: {std1.Id}");
        Console.WriteLine($"Student Name: {std1.Name}");
        Console.WriteLine($"Subject1: {std1.Score1}");
        Console.WriteLine($"Subject2: {std1.Score2}");
        Console.WriteLine($"Aggregate: {std1.GetAggregate()}");
        Console.WriteLine($"Percentage: {std1.GetPercentage():F}\n");

        Console.WriteLine("Original Student information");
        Console.WriteLine($"Student ID: {std2.Id}");
        Console.WriteLine($"Student Name: {std2.Name}");
        Console.WriteLine($"Subject1: {std2.Score1}");
        Console.WriteLine($"Subject2: {std2.Score2}");
        Console.WriteLine($"Aggregate: {std2.GetAggregate()}");
        Console.WriteLine($"Percentage: {std2.GetPercentage():F}\n");

        std2.Id = "A220";
        std2.Score2 = 105;
        Console.WriteLine("Update Student information");
        Console.WriteLine($"Student ID: {std2.Id}");
        Console.WriteLine($"Student Name: {std2.Name}");
        Console.WriteLine($"Subject1: {std2.Score1}");
        Console.WriteLine($"Subject2: {std2.Score2}");
        Console.WriteLine($"Aggregate: {std2.GetAggregate()}");
        Console.WriteLine($"Percentage: {std2.GetPercentage():F}\n");

        Console.Read();
    }
}

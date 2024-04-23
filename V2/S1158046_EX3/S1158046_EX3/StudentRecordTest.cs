using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentRecordTest
{
    static void Main()
    {
        StudentRecord StudentRecord1 = new StudentRecord("A01", "Mary", 60, 90);

        Console.WriteLine("Student information");
        Console.WriteLine($"Student ID: {StudentRecord1.Id}");
        Console.WriteLine($"Student Name: {StudentRecord1.Name}");
        Console.WriteLine($"Subject1: {StudentRecord1.Score1}");
        Console.WriteLine($"Subject2: {StudentRecord1.Score2}");
        Console.WriteLine(value: $"Aggregate: {StudentRecord1.GetAggregate()}");
        Console.WriteLine(value: $"Percentage: {StudentRecord1.GetPercentage():F}");

        StudentRecord StudentRecord3 = new StudentRecord("A110", "Mary", 120, 90);

        Console.WriteLine("\nStudent with changed information");
        Console.WriteLine($"Student ID: {StudentRecord3.Id}");
        Console.WriteLine($"Student Name: {StudentRecord3.Name}");
        Console.WriteLine($"Subject1: {StudentRecord3.Score1}");
        Console.WriteLine($"Subject2: {StudentRecord3.Score2}");
        Console.WriteLine(value: $"Aggregate: {StudentRecord3.GetAggregate()}");
        Console.WriteLine(value: $"Percentage: {StudentRecord3.GetPercentage():F}");

        StudentRecord StudentRecord2 = new StudentRecord("A02", "John", 80, 70);

        Console.WriteLine("\nOriginal Student information");
        Console.WriteLine($"Student ID: {StudentRecord2.Id}");
        Console.WriteLine($"Student Name: {StudentRecord2.Name}");
        Console.WriteLine($"Subject1: {StudentRecord2.Score1}");
        Console.WriteLine($"Subject2: {StudentRecord2.Score2}");
        Console.WriteLine(value: $"Aggregate: {StudentRecord2.GetAggregate()}");
        Console.WriteLine(value: $"Percentage: {StudentRecord2.GetPercentage():F}");

        StudentRecord StudentRecord4 = new StudentRecord("A220", "John", 80, 105);

        Console.WriteLine("\nUpdated Student information");
        Console.WriteLine($"Student ID: {StudentRecord4.Id}");
        Console.WriteLine($"Student Name: {StudentRecord4.Name}");
        Console.WriteLine($"Subject1: {StudentRecord4.Score1}");
        Console.WriteLine($"Subject2: {StudentRecord4.Score2}");
        Console.WriteLine(value: $"Aggregate: {StudentRecord4.GetAggregate()}");
        Console.WriteLine(value: $"Percentage: {StudentRecord4.GetPercentage():F}");
        Console.Read();
    }
}

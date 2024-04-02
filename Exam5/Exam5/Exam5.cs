using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exam5
{
    static void Main()
    {
        Console.Write($"Enter times: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i=1;i<=num;i++)
        {
            Console.Write("Enter grade: ");
            int grade = int.Parse(Console.ReadLine());
            sum = sum + grade;
        }
        float average = (float)sum / num;
        Console.WriteLine($"Total of all 3 grades is {sum}");
        Console.Write($"Class average is {average:F}");

        Console.Read();
    }
}

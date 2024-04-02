using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exam2
{
    static void Main()
    {
        int []number = new int[5];
        for(int i = 0;i < 5;i++)
        {
            Console.Write("Enter number: ");
            number[i] = int.Parse(Console.ReadLine());
        }
        int max = number[0];
        int secmax = number[1];
        for(int i = 0;i < 5;i++)
        {
            if (number[i]>max)
            {
                max = number[i];
            }
            if (number[i] < max && number[i] > secmax)
            {
                secmax = number[i];
            }
        }

        Console.WriteLine($"\nLargest is {max}\nSecond largest is {secmax}");
        Console.Read();
    }
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class S1158046_EX1
{
    static void Main()
    {
        int[] number = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number: ");
            number[i] = int.Parse(Console.ReadLine());
        }
        int L = number[0];
        int S = number[1];
        if (number[0] < number[1])
        {
            L = number[1];
            S = number[0];
        }
        for (int i = 0; i < 5; i++)
        {
            if (number[i] > L)
            {
                L = number[i];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            if (number[i] < L && number[i] > S)
            {
                S = number[i];
            }
        }

        Console.WriteLine($"\nLargest is {L}");
        Console.WriteLine($"Second largest is {S}");
        Console.Read();
    }
}

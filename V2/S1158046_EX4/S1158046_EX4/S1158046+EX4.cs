using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class S1158046_EX4
{ 
    static void Main()
    {
        int odd = 0;
        int even = 0;
        int all = 0;


        Console.Write("Enter initial value for for-loop: ");
        int ivalue = int.Parse(Console.ReadLine());
        Console.Write("Enter final value for for-loop: ");
        int fvalue = int.Parse(Console.ReadLine());

        for(int i = ivalue;i<=fvalue;i++)
        {
            if(i % 2 == 0)
            {
                even = even + i;
            }
            if (i % 2 != 0)
            {
                odd = odd + i;
            }
        }

        all = odd + even;

        Console.WriteLine($"Sum of odd numbers is {odd}");
        Console.WriteLine($"Sum of even numbers is {even}");
        Console.WriteLine($"Sum of all numbers is {all}");

        Console.Read();
    }
}
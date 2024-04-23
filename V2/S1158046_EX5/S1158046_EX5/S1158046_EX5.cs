using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class S1158046_EX5
{
    static void Main()
    {
        Random randomNumbers = new Random();
        int count = randomNumbers.Next(1, 10);
        for(int i = 1; i <= 10; ++i)
        {
            if(i == count)
            {
                continue;
            }
            Console.Write($"{i} ");
        }

        Console.WriteLine($"\nUsed continue to skip displaying {count}");
        Console.Read();
    }
}

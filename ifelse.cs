using System;
using System.Data;

public class bharat
{
    static void Main()
    {
        int age = 17;

        if (age >= 18)
        {
            Console.WriteLine("Valid");
        } else
        {
            Console.WriteLine("Invalid");
        }
        int a = 30;
        for (int i=1; i<=a; i++)
        {
            Console.WriteLine(i);
        }

        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
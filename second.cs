using System;

public class bharat
{
    static void Main()
    {
        Console.Write("Enter Your Name ");
        string name = Console.ReadLine();
        Console.Write("Enter Your Age ");
        int age;
        int.TryParse(Console.ReadLine(), out age);
        Console.Write("Enter Double Number ");
        double doub;
        double.TryParse(Console.ReadLine(), out doub);
        Console.Write("Enter A Floot Number ");
        float flot;
        float.TryParse(Console.ReadLine(), out flot);
        Console.Write("Enter Your Bool ");
        bool boolean;
        bool.TryParse(Console.ReadLine(), out boolean);


        Console.WriteLine($"All Are Print Case : {name}, {age}, {doub}, {flot}, {boolean}");


    }
}
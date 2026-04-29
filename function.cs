using System;
public class Bharat
{

// Function create and Print output 
// Function call Greet();
    static void Greet()
    {
        Console.WriteLine("I am Bharat Rathore");
    }

// Function create and value insert in function (string name) finction call Greet("Bharat Rathore");
    static void Greeet(string name)
    {
        Console.WriteLine($"My Name is {name}");
    }


    static void UserProfile()
    {
        Console.WriteLine("======== User Profile System =========");

        //input user 
        Console.Write("Enter Your Name : ");
        string name = Console.ReadLine();

        //User age With Validation;
        int age;
        Console.Write("Enter Your Age : ");
        while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
        {
            Console.Write("Invalid Age ! Enter Again");   
        }


        //Salary Inputs
        Double salary;
        Console.Write("Enter Your monthly Salary : ");
        while(!double.TryParse(Console.ReadLine(), out salary) || salary < 0)
        {
            Console.Write("Invalid Salary ! Please Enter Again");
        }


        //Boolean Input 
        bool isStudent;
        Console.Write("Are you a Student? (true/false) : ");
        while(!bool.TryParse(Console.ReadLine(), out isStudent))
        {
            Console.Write("Invalid Input! Enter true/false");
        }


        //Login (Calculation)
        double yearlyIncome = salary * 12;

        string category;
        if (yearlyIncome > 1000000)
            category = "High Income";
        else if (yearlyIncome > 500000)
            category = "Medium Income";
        else 
            category = "Low Income";

        
        //All Outputs

        Console.WriteLine("\n===== RESULT =====");
        Console.WriteLine($"Name        : {name}");
        Console.WriteLine($"Age         : {age}");
        Console.WriteLine($"Student     : {isStudent}");
        Console.WriteLine($"Monthly Pay : {salary}");
        Console.WriteLine($"Yearly Pay  : {yearlyIncome}");
        Console.WriteLine($"Category    : {category}");
    }


    static void Main()
    {   Greet();
        Greeet("Bharat Rathore");
        UserProfile();
    }
}
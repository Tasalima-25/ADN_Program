using System;   // Namespace

class PracticeDay1   // Class
{
    static void Main()   // Main method
    {
        // Single-line comment

        /* 
           Multi-line comment
           This is c# language
        */

        //Variables
        int age = 20;
        double price = 3500000;
        char grade = 'A';
        string name = "Taslima";

        //Constant variables
        const int year = 2026;

        //Multiple variables
        int a = 10, b = 20, c = 30;

        // Output
        Console.WriteLine("Hello C#");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Year: " + year);

        //multiple variables result
        Console.WriteLine("Sum = " + (a + b + c));
    }
}

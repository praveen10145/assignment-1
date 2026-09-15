using System;

class Program
{
    static void Main()
    {
        int a = 20;
        int b = 10;

        // Arithmetic Operators
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));

        // Relational Operators
        Console.WriteLine(a > b);
        Console.WriteLine(a < b);
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
        Console.WriteLine(a >= b);
        Console.WriteLine(a <= b);

        // Logical Operators 
        bool x = true, y = false;
        Console.WriteLine("-- Logical Operators --");
        Console.WriteLine($"x && y : {x && y}"); // AND 
        Console.WriteLine($"x || y : {x || y}"); // OR 
        Console.WriteLine($"!x     : {!x}");     // NOT 
        Console.WriteLine();

        // Assignment Operators
        int num = 10;
        Console.WriteLine("-- Assignment Operators --");
        Console.WriteLine($"num = {num}");
        num += 5; // num = num + 5 
        Console.WriteLine($"After num += 5 -> {num}");
        num -= 3; // num = num - 3 
        Console.WriteLine($"After num -= 3 -> {num}");
        num *= 2; // num = num * 2 
        Console.WriteLine($"After num *= 2 -> {num}");

        // ================================================== 
        Console.WriteLine("=== STRING OPERATIONS IN C# ===\n");

        string str1 = "Hello";
        string str2 = "World";
        string str3 = "   C# Programming   ";

        Console.WriteLine("-- Basic String Operations --");
        Console.WriteLine("Concatenation:" + str1 + " " + str2);
        //    Console.WriteLine($"Concatenation: {str1 + " " + str2}"); 
        Console.WriteLine($"Interpolation: {$"{str1}, {str2}!"}");
        Console.WriteLine($"Length of str1: {str1.Length}");
        Console.WriteLine($"Uppercase: {str1.ToUpper()}");
        Console.WriteLine($"Lowercase: {str2.ToLower()}");
        Console.WriteLine($"Substring (0, 3): {str1.Substring(0, 3)}");
        Console.WriteLine($"Contains 'llo'? {str1.Contains("llo")}");
        Console.WriteLine($"Replace 'World' with 'C#': {str2.Replace("World","C#")}");
        Console.WriteLine($"Trim spaces: '{str3.Trim()}'");

        Console.WriteLine("-- for loop --");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }

        // 7️ while loop — repeats as long as condition is true 
        Console.WriteLine("\n-- while loop --");
        int count = 1;
        while (count <= 3)
        {
            Console.WriteLine($"Count: {count}");
            count++;
        }

        // 8️ do-while loop — executes at least once before checking condition 
        Console.WriteLine("\n-- do-while loop --");
        int j = 1;
        do
        {
            Console.WriteLine($"j = {j}");
            j++;
        } while (j <= 3);

        //10 break and continue inside loops 
        Console.WriteLine("\n-- break and continue example --");
        for (int numLoop = 1; numLoop <= 10; numLoop++)
        {
            if (numLoop == 5)
            {
                Console.WriteLine("Breaking loop when num = 5");
                break; // exits the loop immediately 
            }
            if (numLoop % 2 == 1) // for 6 --- not executed - loop already broken 
            {
                continue; // skips odd numbers 
            }
            Console.WriteLine($"Even number: {numLoop}");
        }

        Console.WriteLine("\n=== END OF PROGRAM ===");
        Console.Read();
    }
} 

using System.Security.Cryptography.X509Certificates;

namespace CSExercise;

internal class SumOfNumbers
{
    internal static void Run()
    {
        string instruction = @"Write a C# program to compute the sum of the two numerical values. 
If the two values are the same, return triple their sum.";
        string[] sampleInput = {"1,2 = 3", "3,2 = 5", "2,2 = 12"};

        Exercise.Print(instruction, sampleInput);

        Console.WriteLine();
            
        Console.WriteLine(SumOfTwoNumbers(1,2));
        Console.WriteLine(SumOfTwoNumbers(3,2));
        Console.WriteLine(SumOfTwoNumbers(2,2));

        Console.WriteLine();
    }

    private static int SumOfTwoNumbers(int x, int y)
    {
        return int.Equals(x,y) ? (x + y) * 3 : (x + y);
    }
    
}
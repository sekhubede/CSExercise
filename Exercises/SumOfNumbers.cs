namespace CSExercise;

internal class SumOfNumbers
{
    internal static void Run()
    {
         Console.WriteLine("Write a C# program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.");
         Console.WriteLine("\t1,2 = 3");
         Console.WriteLine("\t3,2 = 5");
         Console.WriteLine("\t2,2 = 12");
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
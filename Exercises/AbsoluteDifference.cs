using System.Runtime.CompilerServices;

namespace CSExercise;

internal class AbsoluteDifference
{
    internal static void Run()
    {
        Console.WriteLine("Write a program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.");
        Console.WriteLine("\t53 = 6");
        Console.WriteLine("\t30 = 21");
        Console.WriteLine("\t51 = 0");
        Console.WriteLine();

        Console.WriteLine(DifferenceOfnAnd51(53));
        Console.WriteLine(DifferenceOfnAnd51(30));
        Console.WriteLine(DifferenceOfnAnd51(51));

        Console.WriteLine();
    }

    private static int DifferenceOfnAnd51(int n)
    {
        const int x = 51;

        return n > x ? (n - x) * 3 : x - n;
    }
}
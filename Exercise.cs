namespace CSExercise;

using CSExercise;

internal class Exercise
{
    internal void Start()
    {
        
        SumOfNumbers.Run();
        
        AbsoluteDifference.Run();

    }

    internal static void Print(string instruction, string[] sampleInput)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(instruction);
        Array.ForEach(sampleInput, Console.WriteLine);

        Console.ResetColor();
    }
}
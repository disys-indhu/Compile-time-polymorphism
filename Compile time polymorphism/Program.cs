using System;
public class Calculation
{
    public static int AddNumbers(int numberOne, int numberTwo)
    {
        return numberOne + numberTwo;
    }
    public static float AddNumbers(float numberOne, float numberTwo)
    {
        return numberOne + numberTwo;
    }
}
public class Overloading
{
    public static void Main()
    {
        Console.WriteLine(Calculation.AddNumbers(11, 12));
        Console.WriteLine(Calculation.AddNumbers(11.4f, 12.3f));
    }
}


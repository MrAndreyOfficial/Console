namespace GameEngine.Math;

public static class Randomizer
{
    private static readonly Random s_random = new Random();

    public static int Generate(int min, int max)
    {
        var generatedNumber = s_random.Next(min, max + 1);

        return generatedNumber;
    }

    public static float Generate(float min, float max)
    {
        var generatedNumber = s_random.NextSingle() * max + min;

        return generatedNumber;
    }

    public static double Generate(double min, double max)
    {
        var random = new Random();
        var generatedNumber = s_random.NextDouble() * max + min;

        return generatedNumber;
    }

    public static long Generate(long min, long max)
    {
        var generatedNumber = s_random.NextInt64(min, max + 1);

        return generatedNumber;
    }
}

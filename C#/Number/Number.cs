using System.Numerics;

namespace Numbers;

public static class Number
{
    public static T Sum<T>(this T number, params T[] numbers) where T : INumber<T>
    {
        foreach (T item in numbers)
            number += item;

        return number;
    }

    public static T Sum<T>(params T[] numbers) where T : INumber<T>
    {
        T sum = default!;

        foreach (T item in numbers)
            sum += item;

        return sum;
    }
}

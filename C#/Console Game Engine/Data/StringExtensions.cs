using System.Text;

namespace ConsoleGameEngine.Data;

public static class StringExtensions
{
    public static string Reverse(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new NullReferenceException("Value is null");

        int strLength = value.Length;

        var builder = new StringBuilder(strLength);

        for (int i = strLength - 1; i >= 0; i--)
            builder.Append(value[i]);

        return builder.ToString();
    }
}

WriteTip("Press CTRL + C to exit", true);

while (true)
{
    var length = Input("Enter the length of the array: ");

    if (int.TryParse(length, out int arrayLength))
    {
        string[] array = new string[arrayLength];

        for (int i = 0; i < arrayLength; i++)
            array[i] = Input($"Enter element by index {i}: ")!;

        foreach (var element in array)
            WriteTip(element?.ToString(), true);

        continue;
    }

    WriteTip("Enter the number!", true);
}

static void WriteTip(string? tip = "", bool useNewLine = false)
{
    if (useNewLine)
    {
        Console.WriteLine(tip);
        return;
    }

    Console.Write(tip);
}

static string? Input(string tip = "", bool useNewLine = false)
{
    WriteTip(tip);

    var input = Console.ReadLine();

    return input;
}

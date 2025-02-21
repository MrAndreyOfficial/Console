namespace GameEngine.Main;

public static class MapGenerator
{
    private static char[,] s_map =
    {
        {'#', '#', '#', '#', '#', '#', '#', '#'},
        {'#', 'x', ' ', 'x', '#', ' ', ' ', '#'},
        {'#', ' ', '#', '#', 'x', ' ', '#', '#'},
        {'#', ' ', ' ', ' ', '#', ' ', ' ', '#'},
        {'#', ' ', '#', ' ', ' ', ' ', '#', '#'},
        {'#', '#', '#', ' ', '#', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', '#', 'x', '#', '#'},
        {'#', '#', '#', '#', '#', '#', '#', '#'},
    };

    public static void Generate()
    {
        int firstDimensionLength = s_map.GetLength(0);
        int secondDimensionLength = s_map.GetLength(1);

        for (int i = 0; i < firstDimensionLength; i++)
        {
            for (int j = 0; j < secondDimensionLength; j++)
                Console.Write(s_map[i, j]);

            Console.WriteLine();
        }
    }

    public static void SetNewChar(int y, int x, char symbol) => s_map[y, x] = symbol;
    public static char GetChar(int y, int x) => s_map[y, x];

    public static void ChangeMap(char[,] map) => s_map = map;
}

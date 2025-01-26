using Newtonsoft.Json;

namespace GameEngine.Data;

public class JsonStorage<T>(string pathToFile) where T : GameData, new()
{
    public void Save(T data)
    {
        var json = JsonConvert.SerializeObject(data);

        File.WriteAllText(pathToFile, json);
    }

    public object Load()
    {
        if (File.Exists(pathToFile) == false)
            return new T();

        var content = File.ReadAllText(pathToFile);
        var json = JsonConvert.DeserializeObject(content, typeof(T));

        return json!;
    }
}

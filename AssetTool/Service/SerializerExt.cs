using System.Text.Json;

namespace AssetTool.Service
{
    public static class SerializerExt
    {
        public static T ReadJson<T>(string path)
        {
            JsonSerializerOptions options = new()
            {
                IncludeFields = true,
            };
            return JsonSerializer.Deserialize<T>(File.ReadAllText(path), options);
        }

        public static string ToJson(this object self)
        {
            JsonSerializerOptions options = new()
            {
                IncludeFields = true,
                WriteIndented = true,
            };
            string json = JsonSerializer.Serialize(self, options);
            return json;
        }


    }
}

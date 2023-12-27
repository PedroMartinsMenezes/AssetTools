using System.Text.Json;

namespace AssetTool.Service
{
    public static class SerializerExt
    {
        public static void SaveJson(this object self, string path)
        {
            string json = JsonSerializer.Serialize(self);
            File.WriteAllText(path, json);
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

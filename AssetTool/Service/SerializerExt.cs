using System.Text.Json;

namespace AssetTool.Service
{
    public static class SerializerExt
    {
        public static T ReadObject<T>(this string path)
        {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(path), options);
        }

        public static string ToJson(this object self)
        {
            string json = JsonSerializer.Serialize(self, options);
            return json;
        }

        public static T ToObject<T>(this string json)
        {

            return JsonSerializer.Deserialize<T>(json, options);
        }

        private static JsonSerializerOptions options = new()
        {
            IncludeFields = true,
            WriteIndented = true,
        };
    }
}

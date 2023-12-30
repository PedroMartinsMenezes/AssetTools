using System.Text.Encodings.Web;
using System.Text.Json;

namespace AssetTool.Service
{
    public static class SerializerExt
    {
        static SerializerExt()
        {
            options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true,
                IncludeFields = true,
            };
        }

        public static T ReadJson<T>(this string path)
        {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(path), options);
        }

        public static T BinToObject<T>(this string path, int offset, Func<BinaryReader, T> callback)
        {
            using var fileStream = new FileStream(path, FileMode.Open);
            fileStream.Seek(offset, SeekOrigin.Begin);
            using var reader = new BinaryReader(fileStream);
            return callback(reader);
        }

        public static string ToJson(this object self)
        {
            string json = JsonSerializer.Serialize(self, options);
            return json;
        }

        public static void SaveToJson(this object self, string path)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(self, options));
        }

        public static T ToObject<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json, options);
        }

        private static JsonSerializerOptions options;
    }
}

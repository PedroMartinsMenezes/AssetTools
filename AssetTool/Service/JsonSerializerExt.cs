using System.Text.Json;

namespace AssetTool
{
    public static class JsonSerializerExt
    {
        static readonly object _lock = new object();

        public static T ReadJson<T>(this string path, Transfer transfer)
        {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(path), transfer.options);
        }

        public static string ToJson(this object self, Transfer transfer)
        {
            string json = JsonSerializer.Serialize(self, transfer.options);
            return json;
        }

        public static byte[] ToBytes(this AssetPackage self, Transfer transfer)
        {
            using MemoryStream outputStream = new();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using TransferWriter transferWriter = new TransferWriter(writer, transfer, true);
            self.Move(transferWriter, "Writing");
            outputStream.Position = 0;
            return outputStream.ToArray();
        }

        public static bool ToJsonThenToObject(this AssetPackage self, TransferWriter transfer, string context)
        {
            string json = JsonSerializer.Serialize(self, transfer.options);
            string folder = "";
            if (AppConfig.DebugSaveJson)
            {
                folder = json.Length < 1_000_000 ? "1MB" : json.Length < 10_000_000 ? "10MB" : "100MB";
                string path = "";
                lock (_lock)
                {
                    path = $"C:/Temp/{folder}/{transfer.GlobalObjects.FileName}.json";
                    if (File.Exists(path)) path = path.Replace(".json", $".{Guid.NewGuid()}.json");
                    if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                File.WriteAllText(path, json);
            }
            AssetPackage asset = json.ToObject<AssetPackage>(transfer);
            bool success = asset.Move(transfer, context);
            if (AppConfig.DebugSaveUasset)
            {
                folder = json.Length < 1_000_000 ? "1MB" : json.Length < 10_000_000 ? "10MB" : "100MB";
                string path = "";
                lock (_lock)
                {
                    path = $"C:/Temp/{folder}/{transfer.GlobalObjects.FileName}.uasset";
                    if (File.Exists(path)) path = path.Replace(".uasset", $".{Guid.NewGuid()}.uasset");
                    if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                File.WriteAllBytes(path, asset.ToBytes(transfer));
            }
            return success;
        }

        public static async Task<bool> ToJsonThenToObjectAsync(this AssetPackage self, TransferWriter transfer, string context)
        {
            string json = JsonSerializer.Serialize(self, transfer.options);
            string folder = "";
            if (AppConfig.DebugSaveJson)
            {
                folder = json.Length < 1_000_000 ? "1MB" : json.Length < 10_000_000 ? "10MB" : "100MB";
                string path = "";
                lock (_lock)
                {
                    path = $"C:/Temp/{folder}/{transfer.GlobalObjects.FileName}.json";
                    if (File.Exists(path)) path = path.Replace(".json", $".{Guid.NewGuid()}.json");
                    if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                await File.WriteAllTextAsync(path, json);
            }
            AssetPackage asset = json.ToObject<AssetPackage>(transfer);
            bool success = await asset.MoveAsync(transfer, context);
            if (AppConfig.DebugSaveUasset)
            {
                folder = json.Length < 1_000_000 ? "1MB" : json.Length < 10_000_000 ? "10MB" : "100MB";
                string path = "";
                lock (_lock)
                {
                    path = $"C:/Temp/{folder}/{transfer.GlobalObjects.FileName}.uasset";
                    if (File.Exists(path)) path = path.Replace(".uasset", $".{Guid.NewGuid()}.uasset");
                    if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                await File.WriteAllTextAsync(path, json);
            }
            return success;
        }

        public static T ToJsonDocumentThenToObject<T>(this T self, Transfer transfer)
        {
            return JsonSerializer.SerializeToDocument(self, transfer.options).ToObject<T>(transfer);
        }

        public static bool ToJsonDocumentThenToObject(this AssetPackage self, Transfer transfer, string context)
        {
            return JsonSerializer.SerializeToDocument(self, transfer.options).ToObject<AssetPackage>(transfer).Move(transfer, context);
        }

        public static void SaveToJson(this object self, string path, Transfer transfer)
        {
            string outputDir = string.IsNullOrEmpty(Path.GetDirectoryName(path)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(path);
            Directory.CreateDirectory(outputDir);
            File.WriteAllText(path, JsonSerializer.Serialize(self, transfer.options));
        }

        public static T ToObject<T>(this string json, Transfer transfer)
        {
            return JsonSerializer.Deserialize<T>(json, transfer.options);
        }

        public static T ToObject<T>(this JsonDocument doc, Transfer transfer)
        {
            return doc.Deserialize<T>(transfer.options);
        }

        public static T ToObject<T>(this object obj, Transfer transfer) where T : new()
        {
            if (obj == default)
            {
                return new T();
            }
            else if (obj is T t)
            {
                return t;
            }
            else if (obj is string str)
            {
                return str.ToObject<T>(transfer);
            }
            else if (obj is JsonElement jstr && jstr.ValueKind == JsonValueKind.String && typeof(T) == typeof(FString))
            {
                return jstr.Deserialize<T>(transfer.options);
            }
            else if (obj is JsonElement json && json.ValueKind == JsonValueKind.String)
            {
                return json.Deserialize<T>(transfer.options);
            }
            else if (obj is JsonElement jobj)
            {
                return jobj.Deserialize<T>(transfer.options);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static T ToObject<T>(this object obj, Type type, Transfer transfer) where T : new()
        {
            if (obj == default)
            {
                return new T();
            }
            else if (obj is string s)
            {
                return (T)JsonSerializer.Deserialize(s, type, transfer.options);
            }
            else if (obj is JsonElement jstr && jstr.ValueKind == JsonValueKind.String)
            {
                return (T)JsonSerializer.Deserialize($"\"{obj}\"", type, transfer.options);
            }
            else if (obj is JsonElement jobj && jobj.ValueKind == JsonValueKind.Object)
            {
                return (T)jobj.Deserialize(type, transfer.options);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}

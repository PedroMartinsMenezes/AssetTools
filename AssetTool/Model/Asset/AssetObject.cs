using System.Text.Json.Serialization;

namespace AssetTool
{
    public class AssetObject
    {
        public long Offset;

        [JsonIgnore] public long NextOffset => Offset + Size;

        public long Index;
        public long Size;
        public string Type;
        public EObjectFlags ObjectFlags;
        public UObject Obj;

        public T Get<T>() where T : new()
        {
            T obj = new T();
            Obj = obj as UObject;
            return obj;
        }
    }

    public static class AssetObjectExt
    {
        [Location("void FLinkerLoad::LoadAllObjects(bool bForcePreload)")]
        public static void ReadAssetObject(this BinaryReader reader, string type, AssetObject item)
        {
            if (GlobalObjects.AssetReaders.TryGetValue(type, out var func))
            {
                func(reader, item);
            }
            else if (item.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                reader.ReadDefault(item.Get<UObject>());
            }
            else
            {
                reader.Read(item.Get<UObject>());
            }
        }
        public static void WriteAssetObject(this BinaryWriter writer, string type, AssetObject item)
        {
            if (GlobalObjects.AssetWriters.TryGetValue(type, out var func))
            {
                func(writer, item);
            }
            else if (item.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                writer.WriteDefault(item.Obj);
            }
            else
            {
                writer.Write(item.Obj);
            }
        }
    }
}

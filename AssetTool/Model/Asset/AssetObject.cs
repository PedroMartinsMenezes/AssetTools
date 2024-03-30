using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Type}")]
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
                item.Get<UObject>().ReadDefault(reader);
            }
            else
            {
                item.Get<UObject>().Read(reader);
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
                item.Obj.WriteDefault(writer);
            }
            else
            {
                item.Obj.Write(writer);
            }
        }
    }
}

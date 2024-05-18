using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Type}")]
    public class AssetObject
    {
        public bool EnableLog;
        public long Offset;
        public long Index;
        public long Size;
        public string Type;
        public EObjectFlags ObjectFlags;
        public UObject Obj;

        [JsonIgnore] public long NextOffset => Offset + Size;

        public UObject Get<T>() where T : new()
        {
            if (Obj is null)
            {
                T obj = new T();
                Obj = obj as UObject;
            }
            return Obj;
        }
    }

    public static class AssetObjectExt
    {
        [Location("void FLinkerLoad::LoadAllObjects(bool bForcePreload)")]
        public static void MoveAssetObject(this Transfer transfer, string type, AssetObject item)
        {
            if (GlobalObjects.AssetMovers.TryGetValue(type, out var func))
            {
                func(transfer, item);
            }
            else if (item.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                if (transfer.IsReading)
                    item.Get<UObject>().ReadDefault(transfer.reader);
                else
                    item.Obj.WriteDefault(transfer.writer);
            }
            else
            {
                item.Get<UObject>().Move(transfer);
            }
        }
    }
}

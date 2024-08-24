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
        [JsonIgnore] public int ClassIndex;
        public long Size;
        public string Type;
        public EObjectFlags ObjectFlags;
        public UObject Obj;

        [JsonIgnore] public long NextOffset => Offset + Size;

        public UObject Get<T>() where T : new()
        {
            return Obj = Obj ?? (new T() as UObject);
        }
    }

    public static class AssetObjectExt
    {
        [Location("void FLinkerLoad::Preload( UObject* Object )")]
        public static void MoveAssetObject(this Transfer transfer, string type, AssetObject item)
        {
            if (item.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                ReadDefaultObject(transfer, item);
            }
            else if (GlobalObjects.AssetMovers.TryGetValue(type, out var func))
            {
                func(transfer, item);
            }
            else
            {
                item.Get<UObject>().Move(transfer);
            }
        }

        [Location("if (Object->HasAnyFlags(RF_ClassDefaultObject))")]
        private static void ReadDefaultObject(Transfer transfer, AssetObject item)
        {
            item.Get<UObject>().MoveDefault(transfer);
        }
    }
}

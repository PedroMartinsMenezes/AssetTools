using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Type}")]
    public class AssetObject : Transferible<AssetObject>
    {
        public bool EnableLog;
        public long Offset;
        public int Index;
        [JsonIgnore] public int ClassIndex;
        public long Size;
        public string Type;
        [JsonIgnore] public string Name;
        [JsonIgnore] public string ObjectName;
        [JsonIgnore] public string ClassName;
        public EObjectFlags ObjectFlags;
        public UObject Obj;

        [JsonIgnore] public long NextOffset => Offset + Size;

        public T Get<T>() where T : UObject, new()
        {
            Obj = Obj ?? new T();
            return (T)Obj;
        }

        [Location("void FLinkerLoad::Preload( UObject* Object )")]
        public override ITransferible Move(Transfer transfer)
        {
            if (ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                Obj ??= (UClass)Activator.CreateInstance(System.Type.GetType($"AssetTool.U{ObjectName}"));
                ((UClass)Obj).SerializeDefaultObject(transfer);
            }
            else if (GlobalObjects.AssetMovers.TryGetValue(Type, out var func))
            {
                func(transfer, this);
            }
            else
            {
                Get<UObject>().Move(transfer);
            }
            return this;
        }
    }
}

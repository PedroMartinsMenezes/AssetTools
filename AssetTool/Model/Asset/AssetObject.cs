using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Type}")]
    public class AssetObject : Transferible<AssetObject>
    {
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
        public List<FPackageIndex> SerializationBeforeSerializationDependencies;
        public List<FPackageIndex> SerializationBeforeCreateDependencies;

        [Description("Names and sizes of 'ArrayProperty' tags read by UObject")]
        [JsonIgnore] public Dictionary<string, int> ArrayNames { get; } = new();

        [JsonIgnore] public long NextOffset => Offset + Size;

        public T Get<T>(bool isUClass = false) where T : UObject, new()
        {
            Obj = Obj ?? new T();
            Obj.bIsUClass = isUClass;
            return (T)Obj;
        }

        [Location("void FLinkerLoad::Preload( UObject* Object )")]
        public override ITransferible Move(Transfer transfer)
        {
            if (ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                Obj ??= (UClass)Activator.CreateInstance(System.Type.GetType($"AssetTool.U{ObjectName}"));
                Obj.bIsUClass = true;
                ((UClass)Obj).SerializeDefaultObject(transfer);
            }
            else if (GlobalObjects.AssetMovers.TryGetValue(Type, out var func))
            {
                func(transfer, this);
            }
            else if (GlobalObjects.AssetMovers.ContainsKey(ClassName))
            {
                Type = ClassName;
                Get<UObject>(true).Move(transfer);
            }
            else
            {
                Get<UObject>().Move(transfer);
            }
            return this;
        }
    }
}

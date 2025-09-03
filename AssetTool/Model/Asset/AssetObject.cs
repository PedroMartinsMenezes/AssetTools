using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AssetTool
{

    [DebuggerDisplay("{ClassName}")]
    public class AssetObject : ITransferible
    {
        public long Offset;
        public int Index;
        public long Size;
        public string ObjectName;
        public string ClassName;
        public string SuperName;
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
        public ITransferible Move(Transfer transfer)
        {
            if (ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                Obj ??= (UClass)Activator.CreateInstance(System.Type.GetType($"AssetTool.U{ClassName}"));
                Obj.bIsUClass = true;
                ((UClass)Obj).SerializeDefaultObject(transfer);
            }
            else if (GlobalObjects.AssetMovers.TryGetValue(ClassName, out var func))
            {
                func(transfer, this);
            }
            else
            {
                Get<UObject>(true).Move(transfer);

                #region Workaround
                if (transfer.GetRemainingSize() == 4)
                {
                    transfer.Position += 4;
                }
                #endregion

            }
            return this;
        }
    }
}

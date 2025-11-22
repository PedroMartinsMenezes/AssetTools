using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{ClassName}")]
    public class AssetObject : ITransferable
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
        public FObjectPtr Pad;

        [Description("Names and sizes of 'ArrayProperty' tags read by UObject")]
        [JsonIgnore] public Dictionary<string, int> ArrayNames { get; } = new();

        [JsonIgnore] public long NextOffset => Offset + Size;

        public T Get<T>() where T : UObject, new()
        {
            Obj = Obj ?? new T();
            return (T)Obj;
        }

        [Location("void FLinkerLoad::Preload( UObject* Object )")]
        public ITransferable Move(Transfer transfer)
        {
            if (ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                var type = System.Type.GetType($"AssetTool.U{ClassName}");
                if (type is { })
                {
                    Obj ??= (UClass)Activator.CreateInstance(type);
                    Obj.bIsUClass = true;
                    ((UClass)Obj).SerializeDefaultObject(transfer);
                }
                else
                {
                    Obj ??= new UClass();
                    Obj.bIsUClass = true;
                    ((UClass)Obj).SerializeDefaultObject(transfer);
                }
            }
            else if (GlobalObjects.AssetMovers.TryGetValue(ClassName, out var func))
            {
                func(transfer, this);
            }
            else if (ClassName.EndsWith(UBlueprintGeneratedClass.TypeName))
            {
                ClassName = UBlueprintGeneratedClass.TypeName;
                GlobalObjects.AssetMovers[ClassName](transfer, this);
            }
            else
            {
                func = GlobalObjects.GetRecognizedMover(ClassName);
                if (func is { })
                {
                    func(transfer, this);
                }
                else
                {
                    var obj = Get<UObject>();
                    obj.bIsUClass = true;
                    obj.Move(transfer);
                }
            }
            #region Workaround
            if (transfer.GetRemainingSize() == 4)
            {
                transfer.Move(ref Pad);
            }
            #endregion
            return this;
        }
    }
}

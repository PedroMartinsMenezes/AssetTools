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
        public EObjectFlags ObjectFlags;
        public UObject Obj;

        [JsonIgnore] public long NextOffset => Offset + Size;

        public UObject Get<T>(int index) where T : new()
        {
            var obj = Obj = Obj ?? (new T() as UObject);
            return obj;
        }

        [Location("void FLinkerLoad::Preload( UObject* Object )")]
        public override ITransferible Move(Transfer transfer)
        {
            if (ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                MoveDefault(transfer);
            }
            else if (GlobalObjects.AssetMovers.TryGetValue(Type, out var func))
            {
                func(transfer, this);
            }
            else
            {
                Get<UObject>(Index - 1).Move(transfer);
            }
            return this;
        }

        [Location("if (Object->HasAnyFlags(RF_ClassDefaultObject))")]
        private void MoveDefault(Transfer transfer)
        {
            Get<UObject>(Index - 1).MoveDefault(transfer);
        }
    }
}

using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonPolymorphic]
    public class UObject
    {
        [JsonIgnore] public Dictionary<string, object> Members = new();
        [JsonPropertyOrder(-9)] public List<object> Tags = new();
        [JsonPropertyOrder(-9)] public FBool HasGuid = new();
        [JsonPropertyOrder(-9)] public FGuid Guid;
        [JsonPropertyOrder(-9)] public FPackageIndex Index;
        [JsonPropertyOrder(-9)] public UScriptStruct SerializedSparseClassDataStruct;

        [Location("void UObject::Serialize(FStructuredArchive::FRecord Record)")]
        public virtual UObject Move(Transfer transfer)
        {
            transfer.MoveTags(Tags, 0, this);
            PossiblySerializeObjectGuid(transfer);
            return this;
        }

        [Location("void FLazyObjectPtr::PossiblySerializeObjectGuid(UObject *Object, FStructuredArchive::FRecord Record)")]
        private void PossiblySerializeObjectGuid(Transfer transfer)
        {
            transfer.Move(ref HasGuid);
            if (HasGuid?.Value == true)
            {
                transfer.Move(ref Guid);
            }
        }
    }
}

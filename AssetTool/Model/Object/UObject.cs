using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void UObject::Serialize(FStructuredArchive::FRecord Record)")]
    [JsonPolymorphic]
    public class UObject
    {
        [JsonIgnore][JsonPropertyOrder(-9)] public Dictionary<string, object> Members = new();

        [JsonPropertyOrder(-9)] public List<object> Tags = new();
        [JsonPropertyOrder(-9)] public FBool HasGuid = new();
        [JsonPropertyOrder(-9)] public FGuid Guid;
        [JsonPropertyOrder(-9)] public FPackageIndex Index;
        [JsonPropertyOrder(-9)] public UScriptStruct SerializedSparseClassDataStruct;

        public virtual UObject Move(Transfer transfer)
        {
            transfer.MoveTags(Tags, 0, this);
            transfer.Move(ref HasGuid);
            if (HasGuid?.Value == true)
            {
                transfer.Move(ref Guid);
            }
            return this;
        }

        public UObject MoveDefault(Transfer transfer)
        {
            transfer.MoveTags(Tags, 0, this);
            if (GlobalObjects.CustomVer(FUE5MainStreamObjectVersion.Guid) >= (int)FUE5MainStreamObjectVersion.Enums.SparseClassDataStructSerialization)
            {
                Index ??= new();
                Index.Move(transfer);

                SerializedSparseClassDataStruct ??= new();
                SerializedSparseClassDataStruct.MoveTags(transfer, SerializedSparseClassDataStruct.Tags);
            }

            return this;
        }
    }
}

using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonPolymorphic]
    public class UObject
    {
        #region Extra
        public Dictionary<string, object> Members;
        [JsonIgnore] public Dictionary<string, Func<Transfer, object, object>> ArrayMovers = [];
        [JsonIgnore] public Dictionary<string, Action<Transfer>> ArrayNotifiers = [];
        #endregion

        [JsonPropertyOrder(-9)] public FBool HasGuid = new();
        [JsonPropertyOrder(-9)] public FGuid Guid;
        [JsonPropertyOrder(-9)] public FPackageIndex Index;
        [JsonPropertyOrder(-9)] public UScriptStruct SerializedSparseClassDataStruct;

        [Location("void UObject::Serialize(FStructuredArchive::FRecord Record)")]
        public virtual UObject Move(Transfer transfer)
        {
            Members ??= [];
            transfer.MoveTags(Members, 0, this);
            PossiblySerializeObjectGuid(transfer);
            return this;
        }

        [Location("void FLazyObjectPtr::PossiblySerializeObjectGuid(UObject *Object, FStructuredArchive::FRecord Record)")]
        private void PossiblySerializeObjectGuid(Transfer transfer)
        {
            transfer.Move(ref HasGuid);
            if (HasGuid)
            {
                transfer.Move(ref Guid);
            }
        }
    }
}

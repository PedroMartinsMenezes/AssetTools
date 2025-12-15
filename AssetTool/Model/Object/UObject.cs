using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonPolymorphic]
    [JsonAsset("Object")]
    public class UObject : ITransferable
    {
        #region Extra
        [JsonPropertyOrder(-9)] public Dictionary<string, object> Members;
        [JsonIgnore] public Dictionary<string, Func<Transfer, object, object>> ArrayMovers = [];
        [JsonIgnore] public Dictionary<string, (Func<Transfer, object, object>, Func<Transfer, object, object>)> MapMovers = [];
        [JsonIgnore] public Dictionary<string, Action<Transfer>> ArrayNotifiers = [];
        [JsonIgnore] public bool bIsUClass;
        #endregion

        [JsonPropertyOrder(-9)] public FBool? HasGuid;
        [JsonPropertyOrder(-9)] public FGuid? Guid;
        [JsonPropertyOrder(-9)] public EClassSerializationControlExtension SerializationControl;

        [Location("void UObject::Serialize(FStructuredArchive::FRecord Record)")]
        public virtual ITransferable Move(Transfer transfer)
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
            if (HasGuid is { } && HasGuid.Value)
            {
                transfer.Move(ref Guid);
            }
        }

        public T GetMember<T>(string name) where T : new()
        {
            return Members[name].ToObject<T>();
        }

        public string GetMemberString(string name)
        {
            if (Members.TryGetValue(name, out var value))
            {
                return value.ToString();
            }
            return null;
        }

        public string GetMemberString(string name1, string name2)
        {
            if (Members.TryGetValue(name1, out object dict1) && dict1.ToObject<Dictionary<string, object>>() is var obj1)
            {
                if (obj1.TryGetValue("Value", out object dict2) && dict2.ToObject<Dictionary<string, object>>() is var obj2)
                {
                    return obj2[name2].ToString();
                }
            }
            return null;
        }
    }
}

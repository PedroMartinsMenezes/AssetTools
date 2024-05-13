using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void FField::Serialize(FArchive& Ar)")]
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FProperty), "FProperty")]
    [JsonDerivedType(typeof(FIntProperty), "FIntProperty")]
    [JsonDerivedType(typeof(FFloatProperty), "FFloatProperty")]
    [JsonDerivedType(typeof(FDoubleProperty), "FDoubleProperty")]
    [JsonDerivedType(typeof(FEnumProperty), "FEnumProperty")]
    [JsonDerivedType(typeof(FOptionalProperty), "FOptionalProperty")]
    [JsonDerivedType(typeof(FBoolProperty), "FBoolProperty")]
    [JsonDerivedType(typeof(FObjectPropertyBase), "FObjectPropertyBase")]
    [JsonDerivedType(typeof(FStructProperty), "FStructProperty")]
    [JsonDerivedType(typeof(FMulticastDelegateProperty), "FMulticastDelegateProperty")]
    [JsonDerivedType(typeof(FInterfaceProperty), "FInterfaceProperty")]
    [JsonDerivedType(typeof(FStrProperty), "FStrProperty")]
    public class FField
    {
        public virtual string TypeName { get; }

        public FName NamePrivate;
        public UInt32 FlagsPrivate;
        public FBool HasMetaData;
        public Dictionary<FName, FString> MetaDataMap = [];

        public FField Move(Transfer transfer)
        {
            transfer.Move(ref NamePrivate);
            transfer.Move(ref FlagsPrivate);
            transfer.Move(ref HasMetaData);
            if (HasMetaData?.Value == true)
            {
                MetaDataMap.Resize(transfer);
                foreach (var pair in MetaDataMap)
                {
                    transfer.Move(pair.Key);
                    transfer.Move(pair.Value);
                }
            }
            return this;
        }
    }
}

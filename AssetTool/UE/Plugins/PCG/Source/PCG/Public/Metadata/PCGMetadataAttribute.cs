using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<TFloat>), "FPCGMetadataAttributeTFloat")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<TDouble>), "FPCGMetadataAttributeTDouble")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<TInt32>), "FPCGMetadataAttributeTInt32")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<TInt64>), "FPCGMetadataAttributeTInt64")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<FVector2D>), "FPCGMetadataAttributeFVector2D")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<FVector>), "FPCGMetadataAttributeFVector")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<FVector4>), "FPCGMetadataAttributeFVector4")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<FQuat>), "FPCGMetadataAttributeFQuat")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<FTransform>), "FPCGMetadataAttributeFTransform")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<FString>), "FPCGMetadataAttributeFString")]
    //[JsonDerivedType(typeof(FPCGMetadataAttribute<bool>), "FPCGMetadataAttributeFBool")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<FRotator>), "FPCGMetadataAttributeFRotator")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<FName>), "FPCGMetadataAttributeFName")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<FSoftObjectPath>), "FPCGMetadataAttributeFSoftObjectPath")]
    [JsonDerivedType(typeof(FPCGMetadataAttribute<FSoftClassPath>), "FPCGMetadataAttributeFSoftClassPath")]
    [JsonDerivedType(typeof(FPCGMetadataAttributeBool), "FPCGMetadataAttributeBool")]
    public class FPCGMetadataAttributeBase : ITransferable
    {
        public Dictionary<TInt64, TInt32> EntryToValueKeyMap;
        public int32 ParentAttributeId;
        public FName Name;
        public int32 AttributeId;

        [Location("void FPCGMetadataAttributeBase::Serialize(UPCGMetadata* InMetadata, FArchive& InArchive)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref EntryToValueKeyMap);
            transfer.Move(ref ParentAttributeId);
            transfer.Move(ref Name);
            transfer.Move(ref AttributeId);
            return this;
        }
    }
}
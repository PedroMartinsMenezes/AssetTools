using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void FField::Serialize(FArchive& Ar)")]
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    ///[JsonDerivedType(typeof(FOptionalProperty), "FOptionalProperty")]
    [JsonDerivedType(typeof(FProperty), "FProperty")]
    [JsonDerivedType(typeof(FNumericProperty), "FNumericProperty")]
    [JsonDerivedType(typeof(FIntProperty), "FIntProperty")]
    [JsonDerivedType(typeof(FNameProperty), "FNameProperty")]
    [JsonDerivedType(typeof(FObjectPropertyBase), "FObjectPropertyBase")]
    [JsonDerivedType(typeof(FObjectProperty), "FObjectProperty")]
    [JsonDerivedType(typeof(FStructProperty), "FStructProperty")]
    [JsonDerivedType(typeof(FBoolProperty), "FBoolProperty")]
    [JsonDerivedType(typeof(FSetProperty), "FSetProperty")]
    [JsonDerivedType(typeof(FArrayProperty), "FArrayProperty")]
    [JsonDerivedType(typeof(FStrProperty), "FStrProperty")]
    [JsonDerivedType(typeof(FEnumProperty), "FEnumProperty")]
    [JsonDerivedType(typeof(FByteProperty), "FByteProperty")]
    [JsonDerivedType(typeof(FDoubleProperty), "FDoubleProperty")]
    [JsonDerivedType(typeof(FFloatProperty), "FFloatProperty")]
    [JsonDerivedType(typeof(FInt64Property), "FInt64Property")]
    [JsonDerivedType(typeof(FTextProperty), "FTextProperty")]
    [JsonDerivedType(typeof(FMapProperty), "FMapProperty")]
    [JsonDerivedType(typeof(FSoftObjectProperty), "FSoftObjectProperty")]
    [JsonDerivedType(typeof(FUInt32Property), "FUInt32Property")]
    [JsonDerivedType(typeof(FUInt64Property), "FUInt64Property")]
    [JsonDerivedType(typeof(FInterfaceProperty), "FInterfaceProperty")]
    [JsonDerivedType(typeof(FClassProperty), "FClassProperty")]
    [JsonDerivedType(typeof(FMulticastDelegateProperty), "FMulticastDelegateProperty")]
    [JsonDerivedType(typeof(FMulticastSparseDelegateProperty), "FMulticastSparseDelegateProperty")]
    [JsonDerivedType(typeof(FSoftClassProperty), "FSoftClassProperty")]
    [JsonDerivedType(typeof(FDelegateProperty), "FDelegateProperty")]
    [JsonDerivedType(typeof(FFieldPathProperty), "FFieldPathProperty")]
    [JsonDerivedType(typeof(FInt8Property), "FInt8Property")]
    [JsonDerivedType(typeof(FClassPtrProperty), "FClassPtrProperty")]
    [JsonDerivedType(typeof(FInt16Property), "FInt16Property")]
    [JsonDerivedType(typeof(FUInt16Property), "FUInt16Property")]
    [JsonDerivedType(typeof(FLazyObjectProperty), "FLazyObjectProperty")]

    public class FField
    {
        public const string TYPE_NAME = "Field";
        public virtual string TypeName { get; }

        public FName NamePrivate;
        public UInt32 FlagsPrivate;
        public FBool HasMetaData;
        public Dictionary<FName, FString> MetaDataMap = [];

        public virtual FField Move(Transfer transfer)
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

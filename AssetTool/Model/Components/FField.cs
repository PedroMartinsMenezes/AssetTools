using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{NamePrivate.ToString()}")]
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
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
    [JsonDerivedType(typeof(FMulticastInlineDelegateProperty), "FMulticastInlineDelegateProperty")]
    public class FField : ITransferible
    {
        public const string TYPE_NAME = "Field";
        public virtual string TypeName { get; }

        public FName NamePrivate;
        public EObjectFlags FlagsPrivate;
        public FBool HasMetaData;
        public Dictionary<FName, FString> MetaDataMap = [];

        [Location("void FField::Serialize(FArchive& Ar)")]
        public virtual FField Move(Transfer transfer)
        {
            transfer.Move(ref NamePrivate);
            FlagsPrivate = (EObjectFlags)transfer.Move((uint)FlagsPrivate);
            transfer.Move(ref HasMetaData);
            if (HasMetaData)
            {
                transfer.Move(ref MetaDataMap);
            }
            return this;
        }

        ITransferible ITransferible.Move(Transfer transfer)
        {
            Move(transfer);
            return this;
        }
    }
}

using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{TypeName} {NamePrivate?.ToString()}")]
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FProperty), nameof(FProperty))]

    [JsonDerivedType(typeof(FArrayProperty), nameof(FArrayProperty))]
    [JsonDerivedType(typeof(FBoolProperty), nameof(FBoolProperty))]
    [JsonDerivedType(typeof(FByteProperty), nameof(FByteProperty))]
    [JsonDerivedType(typeof(FClassProperty), nameof(FClassProperty))]
    [JsonDerivedType(typeof(FClassPtrProperty), nameof(FClassPtrProperty))]
    [JsonDerivedType(typeof(FDelegateProperty), nameof(FDelegateProperty))]
    [JsonDerivedType(typeof(FDoubleProperty), nameof(FDoubleProperty))]
    [JsonDerivedType(typeof(FEnumProperty), nameof(FEnumProperty))]
    [JsonDerivedType(typeof(FFieldPathProperty), nameof(FFieldPathProperty))]
    [JsonDerivedType(typeof(FFloatProperty), nameof(FFloatProperty))]
    [JsonDerivedType(typeof(FInt16Property), nameof(FInt16Property))]
    [JsonDerivedType(typeof(FInt64Property), nameof(FInt64Property))]
    [JsonDerivedType(typeof(FInt8Property), nameof(FInt8Property))]
    [JsonDerivedType(typeof(FInterfaceProperty), nameof(FInterfaceProperty))]
    [JsonDerivedType(typeof(FIntProperty), nameof(FIntProperty))]
    [JsonDerivedType(typeof(FLazyObjectProperty), nameof(FLazyObjectProperty))]
    [JsonDerivedType(typeof(FMapProperty), nameof(FMapProperty))]
    [JsonDerivedType(typeof(FMulticastDelegateProperty), nameof(FMulticastDelegateProperty))]
    [JsonDerivedType(typeof(FMulticastInlineDelegateProperty), nameof(FMulticastInlineDelegateProperty))]
    [JsonDerivedType(typeof(FMulticastSparseDelegateProperty), nameof(FMulticastSparseDelegateProperty))]
    [JsonDerivedType(typeof(FNameProperty), nameof(FNameProperty))]
    [JsonDerivedType(typeof(FNumericProperty), nameof(FNumericProperty))]
    [JsonDerivedType(typeof(FObjectProperty), nameof(FObjectProperty))]
    [JsonDerivedType(typeof(FObjectPropertyBase), nameof(FObjectPropertyBase))]
    [JsonDerivedType(typeof(FObjectPtrProperty), nameof(FObjectPtrProperty))]
    [JsonDerivedType(typeof(FSetProperty), nameof(FSetProperty))]
    [JsonDerivedType(typeof(FSoftClassProperty), nameof(FSoftClassProperty))]
    [JsonDerivedType(typeof(FSoftObjectProperty), nameof(FSoftObjectProperty))]
    [JsonDerivedType(typeof(FStrProperty), nameof(FStrProperty))]
    [JsonDerivedType(typeof(FStructProperty), nameof(FStructProperty))]
    [JsonDerivedType(typeof(FTextProperty), nameof(FTextProperty))]
    [JsonDerivedType(typeof(FUInt16Property), nameof(FUInt16Property))]
    [JsonDerivedType(typeof(FUInt32Property), nameof(FUInt32Property))]
    [JsonDerivedType(typeof(FUInt64Property), nameof(FUInt64Property))]
    [JsonDerivedType(typeof(FWeakObjectProperty), nameof(FWeakObjectProperty))]
    [JsonDerivedType(typeof(FOptionalProperty), nameof(FOptionalProperty))]
    public class FField : ITransferable
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
            transfer.MoveEnum(ref FlagsPrivate);
            if (!transfer.GlobalObjects.IsFilterEditorOnly() && !transfer.GlobalObjects.HasCooked())
            {
                transfer.Move(ref HasMetaData);
                if (HasMetaData)
                {
                    transfer.Move(ref MetaDataMap);
                }
            }
            return this;
        }

        ITransferable ITransferable.Move(Transfer transfer)
        {
            Move(transfer);
            return this;
        }

        [Location("FField* FField::Construct(const FName& FieldTypeName, const FFieldVariant& InOwner, const FName& InName, EObjectFlags InFlags)")]
        public static FField Construct(FName FieldTypeName)
        {
            if (FFieldClass.GetNameToFieldClassMap().TryGetValue(FieldTypeName.Value, out var FieldClassPtr))
            {
                return FieldClassPtr();
            }
            else
            {
                string msg = $"\nField type {FieldTypeName.Value} does not exist\n";
                Log.Error(msg);
                throw new InvalidOperationException(msg);
            }
        }

        [Location("inline void SerializeSingleField(FArchive& Ar, FieldType*& Field, FFieldVariant Owner)")]
        public static void SerializeSingleField(Transfer transfer, ref FName PropertyTypeName, ref FField Field)
        {
            transfer.Move(ref PropertyTypeName);
            if (PropertyTypeName.IsFilled())
            {
                Field = Field ?? FField.Construct(PropertyTypeName);
                Field.Move(transfer);
            }
        }
    }
}

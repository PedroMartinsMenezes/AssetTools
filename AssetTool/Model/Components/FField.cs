using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{TypeName} {NamePrivate.ToString()}")]
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FProperty), "FProperty")]

    [JsonDerivedType(typeof(FArrayProperty), "ArrayProperty")]
    [JsonDerivedType(typeof(FBoolProperty), "BoolProperty")]
    [JsonDerivedType(typeof(FByteProperty), "ByteProperty")]
    [JsonDerivedType(typeof(FClassProperty), "ClassProperty")]
    [JsonDerivedType(typeof(FClassPtrProperty), "ClassPtrProperty")]
    [JsonDerivedType(typeof(FDelegateProperty), "DelegateProperty")]
    [JsonDerivedType(typeof(FDoubleProperty), "DoubleProperty")]
    [JsonDerivedType(typeof(FEnumProperty), "EnumProperty")]
    [JsonDerivedType(typeof(FFieldPathProperty), "FieldPathProperty")]
    [JsonDerivedType(typeof(FFloatProperty), "FloatProperty")]
    [JsonDerivedType(typeof(FInt16Property), "Int16Property")]
    [JsonDerivedType(typeof(FInt64Property), "Int64Property")]
    [JsonDerivedType(typeof(FInt8Property), "Int8Property")]
    [JsonDerivedType(typeof(FInterfaceProperty), "InterfaceProperty")]
    [JsonDerivedType(typeof(FIntProperty), "IntProperty")]
    [JsonDerivedType(typeof(FLazyObjectProperty), "LazyObjectProperty")]
    [JsonDerivedType(typeof(FMapProperty), "MapProperty")]
    [JsonDerivedType(typeof(FMulticastDelegateProperty), "MulticastDelegateProperty")]
    [JsonDerivedType(typeof(FMulticastInlineDelegateProperty), "MulticastInlineDelegateProperty")]
    [JsonDerivedType(typeof(FMulticastSparseDelegateProperty), "MulticastSparseDelegateProperty")]
    [JsonDerivedType(typeof(FNameProperty), "NameProperty")]
    [JsonDerivedType(typeof(FNumericProperty), "NumericProperty")]
    [JsonDerivedType(typeof(FObjectProperty), "ObjectProperty")]
    [JsonDerivedType(typeof(FObjectPropertyBase), "ObjectPropertyBase")]
    [JsonDerivedType(typeof(FObjectPtrProperty), "ObjectPtrProperty")]
    [JsonDerivedType(typeof(FSetProperty), "SetProperty")]
    [JsonDerivedType(typeof(FSoftClassProperty), "SoftClassProperty")]
    [JsonDerivedType(typeof(FSoftObjectProperty), "SoftObjectProperty")]
    [JsonDerivedType(typeof(FStrProperty), "StrProperty")]
    [JsonDerivedType(typeof(FStructProperty), "StructProperty")]
    [JsonDerivedType(typeof(FTextProperty), "TextProperty")]
    [JsonDerivedType(typeof(FUInt16Property), "UInt16Property")]
    [JsonDerivedType(typeof(FUInt32Property), "UInt32Property")]
    [JsonDerivedType(typeof(FUInt64Property), "UInt64Property")]
    [JsonDerivedType(typeof(FWeakObjectProperty), "WeakObjectProperty")]

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
            if (PropertyTypeName.IsFilled)
            {
                Field = Field ?? FField.Construct(PropertyTypeName);
                Field.Move(transfer);
            }
        }
    }
}

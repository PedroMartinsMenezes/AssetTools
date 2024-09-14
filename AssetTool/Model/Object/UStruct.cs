using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void UStruct::Serialize(FArchive& Ar)")]
    [JsonAsset("Struct")]
    public class UStruct : UField
    {
        [JsonPropertyOrder(-8)] public FObjectPtr AccessTrackedObjectPtr = new();
        [JsonPropertyOrder(-8)] public UInt32 Children;
        [JsonPropertyOrder(-8)] public FStructScriptLoader ScriptLoadHelper = new();

        [JsonPropertyOrder(-8)][Sized] public List<FPackageIndex> ChildArray;
        [JsonPropertyOrder(-8)][Sized] public List<FField> ChildProperties;

        private static Dictionary<string, Func<FField>> NameToFieldClassMap = [];

        static UStruct()
        {
            NameToFieldClassMap[FField.TYPE_NAME] = () => new FField();
            NameToFieldClassMap[FProperty.TYPE_NAME] = () => new FProperty();
            NameToFieldClassMap[FNumericProperty.TYPE_NAME] = () => new FNumericProperty();
            NameToFieldClassMap[FIntProperty.TYPE_NAME] = () => new FIntProperty();
            NameToFieldClassMap[FNameProperty.TYPE_NAME] = () => new FNameProperty();
            NameToFieldClassMap[FObjectPropertyBase.TYPE_NAME] = () => new FObjectPropertyBase();
            NameToFieldClassMap[FObjectProperty.TYPE_NAME] = () => new FObjectProperty();
            NameToFieldClassMap[FStructProperty.TYPE_NAME] = () => new FStructProperty();
            NameToFieldClassMap[FBoolProperty.TYPE_NAME] = () => new FBoolProperty();
            NameToFieldClassMap[FSetProperty.TYPE_NAME] = () => new FSetProperty();
            NameToFieldClassMap[FArrayProperty.TYPE_NAME] = () => new FArrayProperty();
            NameToFieldClassMap[FStrProperty.TYPE_NAME] = () => new FStrProperty();
            NameToFieldClassMap[FEnumProperty.TYPE_NAME] = () => new FEnumProperty();
            NameToFieldClassMap[FByteProperty.TYPE_NAME] = () => new FByteProperty();
            NameToFieldClassMap[FDoubleProperty.TYPE_NAME] = () => new FDoubleProperty();
            NameToFieldClassMap[FFloatProperty.TYPE_NAME] = () => new FFloatProperty();
            NameToFieldClassMap[FInt64Property.TYPE_NAME] = () => new FInt64Property();
            NameToFieldClassMap[FTextProperty.TYPE_NAME] = () => new FTextProperty();
            NameToFieldClassMap[FMapProperty.TYPE_NAME] = () => new FMapProperty();
            NameToFieldClassMap[FSoftObjectProperty.TYPE_NAME] = () => new FSoftObjectProperty();
            NameToFieldClassMap[FUInt32Property.TYPE_NAME] = () => new FUInt32Property();
            NameToFieldClassMap[FUInt64Property.TYPE_NAME] = () => new FUInt64Property();
            NameToFieldClassMap[FInterfaceProperty.TYPE_NAME] = () => new FInterfaceProperty();
            NameToFieldClassMap[FClassProperty.TYPE_NAME] = () => new FClassProperty();
            NameToFieldClassMap[FMulticastDelegateProperty.TYPE_NAME] = () => new FMulticastDelegateProperty();
            NameToFieldClassMap[FMulticastSparseDelegateProperty.TYPE_NAME] = () => new FMulticastSparseDelegateProperty();
            NameToFieldClassMap[FSoftClassProperty.TYPE_NAME] = () => new FSoftClassProperty();
            NameToFieldClassMap[FDelegateProperty.TYPE_NAME] = () => new FDelegateProperty();
            NameToFieldClassMap[FFieldPathProperty.TYPE_NAME] = () => new FFieldPathProperty();
            NameToFieldClassMap[FInt8Property.TYPE_NAME] = () => new FInt8Property();
            NameToFieldClassMap[FClassPtrProperty.TYPE_NAME] = () => new FClassPtrProperty();
            NameToFieldClassMap[FInt16Property.TYPE_NAME] = () => new FInt16Property();
            NameToFieldClassMap[FUInt16Property.TYPE_NAME] = () => new FUInt16Property();
            NameToFieldClassMap[FLazyObjectProperty.TYPE_NAME] = () => new FLazyObjectProperty();
        }

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            AccessTrackedObjectPtr.Move(transfer);
            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
            {
                transfer.Move(ref Children);
            }
            else
            {
                ChildArray ??= new();
                ChildArray.Resize(transfer);
                ChildArray.ForEach(x => x.Move(transfer));
            }
            if (Supports.CustomVer(FCoreObjectVersion.Enums.FProperties))
            {
                ChildProperties ??= new();
                MoveChildProperties(transfer, ref ChildProperties);
            }
            ScriptLoadHelper.Construct(transfer);
            ScriptLoadHelper.LoadStructWithScript(transfer);
            return this;
        }

        [Location("void UStruct::SerializeProperties(FArchive& Ar)")]
        private void MoveChildProperties(Transfer transfer, ref List<FField> list)
        {
            list.Resize(transfer, true);
            for (int i = 0; i < list.Count; i++)
            {
                FField item = list[i];
                FName typeName = item is null ? new() : new FName(item.TypeName);
                transfer.Move(ref typeName);

                if (typeName.ComparisonIndex.Value == 0)
                    throw new InvalidOperationException($"Invalid type at {transfer.Position}");

                list[i] = (item ?? GetNameToFieldClassMap(transfer, typeName)).Move(transfer);
            }
        }

        public static FField GetNameToFieldClassMap(Transfer transfer, FName typeName)
        {
            string name = typeName.Value;
            if (NameToFieldClassMap.TryGetValue(name, out var field))
            {
                return field();
            }
            else
            {
                string msg = $"\n\t[{transfer.Position}] Invalid type: {name}\n";
                Log.Info(msg);
                throw new InvalidOperationException(msg);
            }
        }
    }
}

using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonAsset("Struct")]
    public class UStruct : UField
    {
        [JsonPropertyOrder(-8)] public FObjectPtr AccessTrackedObjectPtr;
        [JsonPropertyOrder(-8)] public UInt32 Children;
        [JsonPropertyOrder(-8)] public FStructScriptLoader ScriptLoadHelper;
        [JsonPropertyOrder(-8)] public List<FPackageIndex> ChildArray;
        [JsonPropertyOrder(-8)] public List<FField> ChildProperties;

        [Location("void UStruct::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            AccessTrackedObjectPtr ??= new();
            AccessTrackedObjectPtr.Move(transfer);
            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
            {
                transfer.Move(ref Children);
            }
            else
            {
                transfer.Move(ref ChildArray);
            }
            if (Supports.CustomVer(FCoreObjectVersion.Enums.FProperties))
            {
                ChildProperties ??= new();
                SerializeProperties(transfer, ref ChildProperties);
            }

            ScriptLoadHelper ??= new();
            ScriptLoadHelper.Construct(transfer);
            ScriptLoadHelper.LoadStructWithScript(transfer);
            return this;
        }

        [Location("void UStruct::SerializeProperties(FArchive& Ar)")]
        private void SerializeProperties(Transfer transfer, ref List<FField> LoadedProperties)
        {
            int PropertyCount = LoadedProperties.Count;
            transfer.Move(ref PropertyCount);
            LoadedProperties.Resize(transfer, PropertyCount, true);

            for (int i = 0; i < PropertyCount; i++)
            {
                FName PropertyTypeName = LoadedProperties[i] is null ? new() : new FName(LoadedProperties[i].TypeName);
                transfer.Move(ref PropertyTypeName);

                if (!PropertyTypeName.Value.EndsWith("Property"))
                    throw new InvalidOperationException($"Invalid property name: {PropertyTypeName.Value}");

                if (PropertyTypeName.ComparisonIndex.Value == 0)
                    throw new InvalidOperationException($"Invalid type at {transfer.Position}");

                FField Prop = LoadedProperties[i] ?? FField.Construct(PropertyTypeName);
                LoadedProperties[i] = Prop.Move(transfer);
            }
        }
    }
}

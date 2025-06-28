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
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref AccessTrackedObjectPtr);

            if (!transfer.Supports.RemoveUField_Next)
            {
                transfer.Move(ref Children);
            }
            else
            {
                transfer.Move(ref ChildArray);
            }
            if (transfer.Supports.FProperties)
            {
                SerializeProperties(transfer, ref ChildProperties);
            }

            ScriptLoadHelper ??= new();
            ScriptLoadHelper.Construct(transfer);
            ScriptLoadHelper.LoadStructWithScript(transfer);
            return this;
        }

        [Location("void UStruct::SerializeProperties(FArchive& Ar)")]
        private List<FField> SerializeProperties(Transfer transfer, ref List<FField> LoadedProperties)
        {
            LoadedProperties ??= [];
            int PropertyCount = LoadedProperties.Count;
            transfer.Move(ref PropertyCount);
            LoadedProperties.Resize(transfer, PropertyCount, true);

            for (int i = 0; i < PropertyCount; i++)
            {
                FName PropertyTypeName = LoadedProperties[i] == default ? new() : new FName(LoadedProperties[i].TypeName, transfer);
                transfer.Move(ref PropertyTypeName);

                if (!PropertyTypeName.Value.EndsWith("Property"))
                    throw new InvalidOperationException($"Invalid property name: {PropertyTypeName.Value}");

                FField Prop = LoadedProperties[i] ?? FField.Construct(PropertyTypeName);
                LoadedProperties[i] = Prop.Move(transfer);
            }

            return LoadedProperties;
        }
    }
}

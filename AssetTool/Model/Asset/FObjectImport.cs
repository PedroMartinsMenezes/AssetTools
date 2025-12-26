using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FObjectImport : ITransferable
    {
        public FName ClassPackage;
        public FName ClassName;
        public FPackageIndex OuterIndex = new();
        public FName ObjectName;
        public FName PackageName;
        public FBool bImportOptional;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectImport& I)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ClassPackage);
            transfer.Move(ref ClassName);
            OuterIndex.Move(transfer, true);
            transfer.Move(ref ObjectName);
            if (transfer.Supports.VER_UE4_NON_OUTER_PACKAGE_IMPORT && !transfer.GlobalObjects.IsFilterEditorOnly())
            {
                transfer.Move(ref PackageName);
            }
            if (transfer.Supports.OPTIONAL_RESOURCES)
            {
                transfer.Move(ref bImportOptional);
            }
            return this;
        }

        public void UpdateIndexes(Transfer transfer)
        {
            OuterIndex.UpdateIndexes(transfer);
        }
    }

    public class FObjectImportJsonConverter : JsonConverter<List<FObjectImport>>
    {
        public override List<FObjectImport> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            List<FObjectImport> list = [];
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    var v = reader.GetString().Split(" | ");
                    string classPackage = v[2][1..v[2].IndexOf('\'', 1)];
                    string className = v[3][1..v[3].IndexOf('\'', 1)];
                    string packageName = v[4][1..v[4].IndexOf('\'', 1)];
                    var obj = new FObjectImport
                    {
                        OuterIndex = new FPackageIndex(v[1]),
                        ClassPackage = new FName(classPackage),
                        ClassName = new FName(className),
                        PackageName = new FName(packageName),
                        bImportOptional = new FBool(v[5]),
                        ObjectName = new FName(v[6]),
                    };
                    list.Add(obj);
                }
            }
            return list;
        }
        public override void Write(Utf8JsonWriter writer, List<FObjectImport> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.Count; i++)
            {
                var index = -(i + 1);
                var x = value[i];
                string classPackage = $"'{x.ClassPackage}'";
                writer.WriteStringValue($"ImportIndex[{index,4}] | {x.OuterIndex,4} | {classPackage,-30} | '{x.ClassName}' | '{x.PackageName}' | {x.bImportOptional,5} | {x.ObjectName}");
            }
            writer.WriteEndArray();
        }
    }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FObjectImport : ITransferible
    {
        public FName ClassPackage;
        public FName ClassName;
        public FPackageIndex OuterIndex = new();
        public FName ObjectName;
        public FName PackageName;
        public FBool bImportOptional;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectImport& I)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ClassPackage);
            transfer.Move(ref ClassName);
            transfer.Move(ref OuterIndex.Index);
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
                    int i = 1;
                    var obj = new FObjectImport
                    {
                        OuterIndex = new(v[i++].Trim()),
                        ClassPackage = new(v[i++].Trim()),
                        ClassName = new(v[i++].Trim()),
                        PackageName = new(v[i++].Trim()),
                        bImportOptional = new(v[i++].Trim()),
                        ObjectName = new(v[i].Trim()),
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
                writer.WriteStringValue($"ImportIndex[{index}] | {x.OuterIndex,4} | {x.ClassPackage,30} | {x.ClassName,30} | {x.PackageName} | {x.bImportOptional} | {x.ObjectName}");
            }
            writer.WriteEndArray();
        }
    }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FObjectImport : ITransferible
    {
        public FName ClassPackage;
        public FName ClassName;
        public FPackageIndex OuterIndex;
        public FName ObjectName;
        public FName PackageName;
        public FBool bImportOptional;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectImport& I)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ClassPackage);
            transfer.Move(ref ClassName);
            transfer.Move(ref OuterIndex);
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
                    var obj = new FObjectImport
                    {
                        ClassPackage = string.IsNullOrEmpty(v[0]) ? default : new(v[0]),
                        ClassName = string.IsNullOrEmpty(v[1]) ? default : new(v[1]),
                        OuterIndex = string.IsNullOrEmpty(v[2]) ? default : new(v[2]),
                        ObjectName = string.IsNullOrEmpty(v[3]) ? default : new(v[3]),
                        PackageName = string.IsNullOrEmpty(v[4]) ? default : new(v[4]),
                        bImportOptional = string.IsNullOrEmpty(v[5]) ? default : new(v[5]),
                    };
                    list.Add(obj);
                }
            }
            return list;
        }
        public override void Write(Utf8JsonWriter writer, List<FObjectImport> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            value.ForEach(x => writer.WriteStringValue($"{x.ClassPackage} | {x.ClassName} | {x.OuterIndex} | {x.ObjectName} | {x.PackageName} | {x.bImportOptional}"));
            writer.WriteEndArray();
        }
    }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectImport& I)")]
    public class FObjectImport
    {
        public FName ClassPackage;
        public FName ClassName;
        public FPackageIndex OuterIndex;
        public FName ObjectName;
        [Check("CheckPackageName")] public FName PackageName;
        [Check("CheckImportOptional")] public FBool bImportOptional;

        public bool CheckPackageName()
        {
            return GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_NON_OUTER_PACKAGE_IMPORT);
        }
        public bool CheckImportOptional()
        {
            return GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.OPTIONAL_RESOURCES);
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
                    var obj = new FObjectImport { ClassPackage = new(v[0]), ClassName = new(v[1]), OuterIndex = new(v[2]), ObjectName = new(v[3]), PackageName = new(v[4]), bImportOptional = new(v[5]) };
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

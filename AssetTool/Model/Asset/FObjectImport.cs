using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FObjectImport
    {
        public FName ClassPackage;
        public FName ClassName;
        public FPackageIndex OuterIndex = new();
        public FName ObjectName;
        public FName PackageName;
        public FBool bImportOptional;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectImport& I)")]
        public void Move(Transfer transfer)
        {
            transfer.Move(ref ClassPackage);
            transfer.Move(ref ClassName);
            transfer.Move(ref OuterIndex);
            transfer.Move(ref ObjectName);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_NON_OUTER_PACKAGE_IMPORT))
                transfer.Move(ref PackageName);
            if (Supports.UEVer(EUnrealEngineObjectUE5Version.OPTIONAL_RESOURCES))
                transfer.Move(ref bImportOptional);
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
                        ClassPackage = string.IsNullOrEmpty(v[0]) ? null : new(v[0]),
                        ClassName = string.IsNullOrEmpty(v[1]) ? null : new(v[1]),
                        OuterIndex = string.IsNullOrEmpty(v[2]) ? null : new(v[2]),
                        ObjectName = string.IsNullOrEmpty(v[3]) ? null : new(v[3]),
                        PackageName = string.IsNullOrEmpty(v[4]) ? null : new(v[4]),
                        bImportOptional = string.IsNullOrEmpty(v[5]) ? null : new(v[5]),
                        ///ClassPackage = string.IsNullOrEmpty(v[1]) ? null : new(v[1]),
                        ///ClassName = string.IsNullOrEmpty(v[2]) ? null : new(v[2]),
                        ///OuterIndex = string.IsNullOrEmpty(v[3]) ? null : new(v[3]),
                        ///ObjectName = string.IsNullOrEmpty(v[4]) ? null : new(v[4]),
                        ///PackageName = string.IsNullOrEmpty(v[5]) ? null : new(v[5]),
                        ///bImportOptional = string.IsNullOrEmpty(v[6]) ? null : new(v[6]),
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
            ///foreach ((FObjectImport x, int i) in value.Select((x, i) => (x, i)))
            ///{
            ///    writer.WriteStringValue($"[{(i + 1) * -1}] | {x.ClassPackage} | {x.ClassName} | {x.OuterIndex} | {x.ObjectName} | {x.PackageName} | {x.bImportOptional}");
            ///}
            writer.WriteEndArray();
        }
    }
}

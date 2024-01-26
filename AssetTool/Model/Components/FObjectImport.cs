using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FObjectImport
    {
        public FName ClassPackage;
        public FName ClassName;
        public FPackageIndex OuterIndex;
        public FName ObjectName;
        public FName PackageName;
        public FBool bImportOptional;
    }

    public class FObjectImportJsonConverter : JsonConverter<FObjectImport>
    {
        public override FObjectImport Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString()!.Split(' ');
            var obj = new FObjectImport()
            {
                ClassPackage = new FName(v[7]),
                ClassName = new FName(v[8]),
                OuterIndex = new() { Index = int.Parse(v[9]) },
                ObjectName = new FName(v[10]),
                PackageName = new FName(v[11]),
                bImportOptional = new FBool(v[12])
            };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FObjectImport value, JsonSerializerOptions options)
        {
            string k = $"ClassPackage ClassName OuterIndex ObjectName PackageName bImportOptional";
            string v = $"{value.ClassPackage} {value.ClassName} {value.OuterIndex} {value.ObjectName} {value.PackageName} {value.bImportOptional}";
            writer.WriteStringValue($"{k} = {v}");
        }
    }
}

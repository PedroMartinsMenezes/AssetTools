using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [Location("FArchive& operator<<(FArchive& Ar, TVector2<double>& V)")]
    public class FVector2Df
    {
        public float X;
        public float Y;

        public const string StructName = "Vector2D";
        public const int SIZE = 8;

        public FVector2Df() { }

        public FVector2Df(BinaryReader reader)
        {
            X = reader.ReadSingle();
            Y = reader.ReadSingle();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
        }
    }

    public class FVector2fJsonConverter : JsonConverter<FVector2Df>
    {
        public override FVector2Df Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector2Df { X = v[0], Y = v[1] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector2Df value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y}");
            writer.WriteStringValue(s);
        }
    }

    public class FVector2DfJson : Dictionary<string, object>, IPropertytag
    {
        public const string Type = "Vector2Df";
        public const string Pattern = "Vector2Df '([ \\w]+)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FVector2DfJson() { }

        public FVector2DfJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            var value = tag.Value as FVector2Df;
            Add($"Vector2Df '{tag.Name.Value}'{arrayIndex}{guidValue}", $"{value.X} {value.Y}");
        }

        public FPropertyTag GetNative()
        {
            return GetNative(Keys.First(), (string)Values.First());
        }

        public static FPropertyTag GetNative(string key, string value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;
            var v = value.Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector2Df { X = v[0], Y = v[1] };

            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FStructProperty.TYPE_NAME),
                StructName = new FName(FVector2D.StructName),
                Value = obj,
                Size = 8,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }
}

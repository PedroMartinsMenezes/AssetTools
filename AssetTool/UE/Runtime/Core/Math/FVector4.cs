using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public static class FVector4Selector
    {
        public const string StructName = "Vector4";

        public static object Move(Transfer transfer, int num, object value)
        {
            return num == FVector4f.SIZE ? value.ToObject<FVector4f>().Move(transfer) : value.ToObject<FVector4d>().Move(transfer);
        }
        public static object GetDerived(FPropertyTag tag)
        {
            return tag.Size == FVector4f.SIZE ? new FVector4fJson(tag) : new FVector4dJson(tag);
        }
    }

    #region Double
    public class FVector4d
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        public const string StructName = "Vector4d";
        public const int SIZE = 32;

        public FVector4d() { }

        public virtual FVector4d Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FVector4dJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "Vector4d '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FVector4dJson() { }

        public FVector4dJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            var value = tag.Value as FVector4d;
            Add($"Vector4d '{tag.Name.ToString()}'{arrayIndex}{guidValue}", $"{value.X} {value.Y} {value.Z} {value.W}");
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
            var v = value.Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector4d { X = v[0], Y = v[1], Z = v[2], W = v[3] };

            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FStructProperty.TYPE_NAME),
                StructName = new FName(FVector4Selector.StructName),
                Value = obj,
                Size = FVector4d.SIZE,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }

    public class FVector4dJsonConverter : JsonConverter<FVector4d>
    {
        public override FVector4d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector4d { X = v[0], Y = v[1], Z = v[2], W = v[3] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector4d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float
    public class FVector4f
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public const string StructName = "Vector4f";
        public const int SIZE = 16;

        public FVector4f() { }

        public FVector4f Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FVector4fJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "Vector4f '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FVector4fJson() { }

        public FVector4fJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            var value = tag.Value as FVector4f;
            Add($"Vector4f '{tag.Name.ToString()}'{arrayIndex}{guidValue}", $"{value.X} {value.Y} {value.Z} {value.W}");
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
            var obj = new FVector4f { X = v[0], Y = v[1], Z = v[2], W = v[3] };

            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FStructProperty.TYPE_NAME),
                StructName = new FName(FVector4Selector.StructName),
                Value = obj,
                Size = FVector4f.SIZE,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }

    public class FVector4fJsonConverter : JsonConverter<FVector4f>
    {
        public override FVector4f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector4f { X = v[0], Y = v[1], Z = v[2], W = v[3] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector4f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}");
            writer.WriteStringValue(s);
        }
    }
    #endregion
}

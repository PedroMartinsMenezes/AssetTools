using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public static class FVector3Selector
    {
        public const string StructName = "Vector";

        public static object Move(Transfer transfer, int num, object value)
        {
            return num == FVector3f.SIZE ? value.ToObject<FVector3f>().Move(transfer) : value.ToObject<FVector3d>().Move(transfer);
        }
        public static object GetDerived(FPropertyTag tag)
        {
            return tag.Size == FVector3f.SIZE ? new FVector3fJson(tag) : new FVector3dJson(tag);
        }
    }

    #region Double
    public class FVector3d
    {
        public double X;
        public double Y;
        public double Z;

        public const string StructName = "Vector3d";
        public const int SIZE = 24;

        public FVector3d() { }

        public virtual FVector3d Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FVector3dJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "Vector3d '([ \\w]+)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FVector3dJson() { }

        public FVector3dJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            var value = tag.Value as FVector3d;
            Add($"Vector3d '{tag.Name.ToString()}'{arrayIndex}{guidValue}", $"{value.X} {value.Y} {value.Z}");
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
            var obj = new FVector3d { X = v[0], Y = v[1], Z = v[2] };

            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FStructProperty.TYPE_NAME),
                StructName = new FName(FVector3Selector.StructName),
                Value = obj,
                Size = FVector3d.SIZE,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }

    public class FVector3dJsonConverter : JsonConverter<FVector3d>
    {
        public override FVector3d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector3d { X = v[0], Y = v[1], Z = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector3d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float
    public class FVector3f
    {
        public float X;
        public float Y;
        public float Z;

        public const string StructName = "Vector3f";
        public const int SIZE = 12;

        public FVector3f() { }

        public FVector3f Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FVector3fJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "Vector3f '([ \\w]+)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FVector3fJson() { }

        public FVector3fJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            var value = tag.Value as FVector3f;
            Add($"Vector3f '{tag.Name.ToString()}'{arrayIndex}{guidValue}", $"{value.X} {value.Y} {value.Z}");
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
            var obj = new FVector3f { X = v[0], Y = v[1], Z = v[2] };

            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FStructProperty.TYPE_NAME),
                StructName = new FName(FVector3Selector.StructName),
                Value = obj,
                Size = FVector3f.SIZE,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }

    public class FVector3fJsonConverter : JsonConverter<FVector3f>
    {
        public override FVector3f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector3f { X = v[0], Y = v[1], Z = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector3f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}");
            writer.WriteStringValue(s);
        }
    }
    #endregion
}

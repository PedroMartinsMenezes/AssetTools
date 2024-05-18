using System.Globalization;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public static class FVector2DSelector
    {
        public const string StructName = "Vector2D";

        public static object Move(Transfer transfer, int num, object value)
        {
            return num == FVector2Df.SIZE ? value.ToObject<FVector2Df>().Move(transfer) : value.ToObject<FVector2D>().Move(transfer);
        }

        public static object GetDerived(FPropertyTag tag)
        {
            return tag.Size == FVector2Df.SIZE ? new FVector2DfJson(tag) : new FVector2DJson(tag);
        }
        public static FPropertyTag GetNative(string key, JsonElement value)
        {
            return key == FVector2Df.StructNameKey ? FVector2DfJson.GetNative(key, value.ToString()) : FVector2DJson.GetNative(key, value.ToString());
        }
    }

    #region Double
    [Location("FArchive& operator<<(FArchive& Ar, TVector2<double>& V)")]
    public class FVector2D
    {
        public double X;
        public double Y;

        public const string StructName = "Vector2D";
        public const string StructNameKey = "Vector2D";
        public const int SIZE = 16;

        public FVector2D Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }

    public class FVector2DJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "Vector2D '([ \\w]+)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FVector2DJson() { }

        public FVector2DJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            var value = tag.Value as FVector2D;
            Add($"Vector2D '{tag.Name.Value}'{arrayIndex}{guidValue}", $"{value.X} {value.Y}");
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
            var obj = new FVector2D { X = v[0], Y = v[1] };

            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FStructProperty.TYPE_NAME),
                StructName = new FName(FVector2D.StructName),
                Value = obj,
                Size = FVector2D.SIZE,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }
    #endregion

    #region Float
    [Location("FArchive& operator<<(FArchive& Ar, TVector2<double>& V)")]
    public class FVector2Df
    {
        public float X;
        public float Y;

        public const string StructName = "Vector2D";
        public const string StructNameKey = "Vector2Df";
        public const int SIZE = 8;

        public FVector2Df() { }

        public FVector2Df Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }

    public class FVector2DfJson : Dictionary<string, object>, IPropertytag
    {
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
                StructName = new FName(FVector2Df.StructName),
                Value = obj,
                Size = FVector2Df.SIZE,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }
    #endregion
}

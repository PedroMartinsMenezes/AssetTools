//using System.Globalization;
//using System.Text.Json;
//using System.Text.Json.Serialization;
//using System.Text.RegularExpressions;

//namespace AssetTool
//{
//    public class FVector
//    {
//        public const string StructName = "Vector";
//        public const int SIZE = 24;

//        public double X;
//        public double Y;
//        public double Z;

//        public virtual FVector Move(Transfer transfer)
//        {
//            transfer.Move(ref X);
//            transfer.Move(ref Y);
//            transfer.Move(ref Z);
//            return this;
//        }
//    }

//    public class FVectorJson : Dictionary<string, object>, IPropertytag
//    {
//        public const string Pattern = "Vector '([ \\w]+)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

//        public FVectorJson() { }

//        public FVectorJson(FPropertyTag tag)
//        {
//            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
//            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
//            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
//            var value = tag.Value as FVector;
//            Add($"Vector '{tag.Name.Value}'{arrayIndex}{guidValue}", $"{value.X} {value.Y} {value.Z}");
//        }

//        public FPropertyTag GetNative()
//        {
//            return GetNative(Keys.First(), (string)Values.First());
//        }

//        public static FPropertyTag GetNative(string key, string value)
//        {
//            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
//            var match = Regex.Match(key, Pattern);
//            string name = match.Groups[1].Value;
//            string index = match.Groups[2].Value;
//            string guid = match.Groups[3].Value;
//            var v = value.Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
//            var obj = new FVector { X = v[0], Y = v[1], Z = v[2] };

//            return new FPropertyTag
//            {
//                Name = new FName(name),
//                Type = new FName(FStructProperty.TYPE_NAME),
//                StructName = new FName(FVector.StructName),
//                Value = obj,
//                Size = FVector.SIZE,
//                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
//                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
//                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
//            };
//        }
//    }

//    public class FVectorJsonConverter : JsonConverter<FVector>
//    {
//        public override FVector Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
//        {
//            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
//            var obj = new FVector { X = v[0], Y = v[1], Z = v[2] };
//            return obj;
//        }

//        public override void Write(Utf8JsonWriter writer, FVector value, JsonSerializerOptions options)
//        {
//            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}");
//            writer.WriteStringValue(s);
//        }
//    }
//}

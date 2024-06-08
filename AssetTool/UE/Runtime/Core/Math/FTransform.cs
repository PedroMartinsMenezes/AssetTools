//using System.Globalization;
//using System.Text.RegularExpressions;

//namespace AssetTool
//{
//    public class FTransform
//    {
//        public const string StructName = "Transform";

//        public FQuat4d Rotation = new();
//        public FVector Translation = new();
//        public FVector Scale3D = new();

//        public virtual FTransform Move(Transfer transfer)
//        {
//            Rotation.Move(transfer);
//            Translation.Move(transfer);
//            Scale3D.Move(transfer);
//            return this;
//        }
//    }

//    public class FTransformJson : Dictionary<string, object>, IPropertytag
//    {
//        public const string Pattern = "Transform '([ \\w]+)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

//        public FTransformJson() { }

//        public FTransformJson(FPropertyTag tag)
//        {
//            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
//            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
//            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
//            var value = tag.Value as FLinearColor;
//            Add($"Transform '{tag.Name.Value}'{arrayIndex}{guidValue}", $"{value.R} {value.G} {value.B} {value.A}");
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
//            var v = value.Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
//            var obj = new FLinearColor { R = v[0], G = v[1], B = v[2], A = v[3] };

//            return new FPropertyTag
//            {
//                Name = new FName(name),
//                Type = new FName(FStructProperty.TYPE_NAME),
//                StructName = new FName(FLinearColor.StructName),
//                Value = obj,
//                Size = FLinearColor.SIZE,
//                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
//                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
//                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
//            };
//        }
//    }
//}

//using System.Diagnostics;

//namespace AssetTool
//{
//    [DebuggerDisplay("struct[]")]
//    public class FStructPropertyJsonArray : BasePropertyJsonArray<FStructPropertyJson>
//    {
//        public FStructPropertyJsonArray() { }
//        public FStructPropertyJsonArray(FPropertyTag tag) : base(tag) { }

//        public override string Name => "struct[]";
//        public override int Size => 0;
//        public override string InnerTypeName => FStructProperty.TYPE_NAME;
//        public override string StructName => null;
//        public override string ItemToValue(object item) => null;
//        public override object StringToItem<T2>(string str) => null;

//        public static string BuildKey(string type, FPropertyTag tag)
//        {
//            string enumName = !tag.EnumName.IsFilled() ? " " : $" ({tag.EnumName.Value}) ";
//            string arrayIndex = tag.ArrayIndex.GetValueOrDefault() > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
//            string guidValue = tag.HasPropertyGuid.GetValueOrDefault() == 0 ? string.Empty : $" {{{tag.GuidValue}}}";
//            string typeNamespace = tag.TypeNamespace is { } ? $" {tag.TypeNamespace.Value}" : string.Empty;
//            string enumInnerType = tag.EnumInnerType is { } ? $" {tag.EnumInnerType.Value}" : string.Empty;
//            string maybeInnerTag = string.Empty;

//            if (tag.MaybeInnerTag is { })
//            {
//                maybeInnerTag = $" @ {tag.MaybeInnerTag.Name} {tag.MaybeInnerTag.Type} {tag.MaybeInnerTag.StructName} {tag.MaybeInnerTag.Size}";
//            }

//            return $"{type}{enumName}'{tag.Name.ToString()}'{arrayIndex}{guidValue}{enumInnerType}{typeNamespace}{maybeInnerTag}";
//        }

//        public FStructPropertyJsonArray ToDict(FPropertyTag tag)
//        {
//            string key = BuildKey(Name, tag);
//            object value = tag.Value;
//            Add(key, value);
//            return this;
//        }
//    }
//}

using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("struct[]")]
    public class FStructPropertyJsonArray : BasePropertyJsonArray
    {
        public FStructPropertyJsonArray() { }

        public override string Name => "struct[]";
        public override int Size => throw new NotImplementedException();
        public override string InnerTypeName => FStructProperty.TYPE_NAME;
        public override string StructName => throw new NotImplementedException();
        public override string ItemToString(object item) => throw new NotImplementedException();
        public override object StringToItem(string str) => throw new NotImplementedException();

        public static string ExtraFields(FPropertyTag tag)
        {
            string innerTagName = tag.MaybeInnerTag is { } && tag.MaybeInnerTag.Name.Value != tag.Name.Value ? tag.MaybeInnerTag.Name.Value : string.Empty;

            string a = tag.StructName is { } ? $"StructName({tag.StructName}) " : string.Empty;
            string b = $"Size({tag.Size}) ";
            string c = tag.PropertyTagFlags is { } ? $"PropertyTagFlags({tag.PropertyTagFlags}) " : string.Empty;
            string d = tag.PropertyTagExtensions is { } ? $"PropertyTagExtensions({tag.PropertyTagExtensions}) " : string.Empty;
            string e = tag.OverrideOperation is { } ? $"OverrideOperation({tag.OverrideOperation}) " : string.Empty;
            string f = tag.bExperimentalOverridableLogic is { } ? $"bExperimentalOverridableLogic({tag.bExperimentalOverridableLogic}) " : string.Empty;
            string g = tag.StructGuid.HasValue ? $"StructGuid({tag.StructGuid}) " : string.Empty;
            string h = tag.MaybeInnerTag is null ? string.Empty : $"MaybeInnerTag({tag.MaybeInnerTag.StructName} {tag.MaybeInnerTag.Size} {tag.MaybeInnerTag.StructGuid} {innerTagName}) ";

            return $"{a}{b}{c}{d}{e}{f}{g}{h}";
        }

        public override object FromNative(FPropertyTag tag, Transfer transfer = null)
        {
            string globalKey = $"{FArrayProperty.TYPE_NAME} {FStructProperty.TYPE_NAME} {tag.StructName}";
            if (transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME && !transfer.GlobalObjects.GlobalTypeNames.ContainsKey(globalKey))
            {
                transfer.GlobalObjects.GlobalTypeNames[globalKey] = new GlobalTypeName { TypeName = tag.TypeName };
            }

            string key = new BasePropertyJson().BuildKey(Name, tag, ExtraFields);
            object value = tag.Value;
            Add(key, value);
            return this;
        }

        public override FPropertyTag ToNative(Transfer transfer, string key, object val)
        {
            string structName = key.GetNonNull("StructName({0})", x => x);

            var basePropertyJson = new BasePropertyJson
            {
                TypeName = FArrayProperty.TYPE_NAME,
                InnerType = FStructProperty.TYPE_NAME,
                StructName = structName,
            };

            FPropertyTag tag = basePropertyJson.ToNative(transfer, key, val);

            string globalKey = $"{FArrayProperty.TYPE_NAME} {FStructProperty.TYPE_NAME} {structName}";
            if (transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME && transfer.GlobalObjects.GlobalTypeNames.ContainsKey(globalKey))
            {
                tag.TypeName = transfer.GlobalObjects.GlobalTypeNames[globalKey].TypeName;
            }

            string name, native, enumName, index, guid, enumInnerType, typeNamespace;
            string prefix = BasePropertyJson.ExtractKey(transfer, null, key, out name, out native, out enumName, out index, out guid, out enumInnerType, out typeNamespace);

            int size = prefix.GetNonNull("Size({0})", x => int.Parse(x));
            string propertyTagFlags = prefix.GetNonNull("PropertyTagFlags({0})", x => x);
            string propertyTagExtensions = prefix.GetNonNull("PropertyTagExtensions({0})", x => x);
            string overrideOperation = prefix.GetNonNull("OverrideOperation({0})", x => x);
            string bExperimentalOverridableLogic = prefix.GetNonNull("bExperimentalOverridableLogic({0})", x => x);
            string structGuid = prefix.GetNonNull("StructGuid({0})", x => x);

            FPropertyTag maybeInnerTag = null;
            if (prefix.GetNonNull("MaybeInnerTag({0})", x => x) is string maybeInnerTagFields)
            {
                string[] parts = maybeInnerTagFields.Split(' ');
                string innerName = parts[3].Length == 0 ? name : parts[3];

                maybeInnerTag = new()
                {
                    Name = new FName(innerName, transfer),
                    Type = new FName(InnerTypeName, transfer),
                    StructName = new FName(parts[0], transfer),
                    Size = int.Parse(parts[1]),
                    StructGuid = parts[2].Length > 0 ? new FGuid(parts[2]) : null,
                };
            }

            tag.StructName = structName is null ? null : new FName(structName);
            tag.Size = size;
            tag.PropertyTagFlags = propertyTagFlags is { } ? (EPropertyTagFlags?)Enum.Parse(typeof(EPropertyTagFlags), propertyTagFlags) : null;
            tag.PropertyTagExtensions = propertyTagExtensions is { } ? (EPropertyTagExtension?)Enum.Parse(typeof(EPropertyTagExtension), propertyTagExtensions) : null;
            tag.OverrideOperation = overrideOperation is { } ? (EOverriddenPropertyOperation?)Enum.Parse(typeof(EOverriddenPropertyOperation), overrideOperation) : null;
            tag.bExperimentalOverridableLogic = bExperimentalOverridableLogic is { } ? (bool?)bool.Parse(bExperimentalOverridableLogic) : null;
            tag.StructGuid = structGuid is { } ? new FGuid(structGuid) : null;

            tag.MaybeInnerTag = maybeInnerTag;

            return tag;
        }
    }
}

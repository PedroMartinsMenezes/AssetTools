namespace AssetTool
{
    public class FStructPropertyJson : BasePropertyJson
    {
        public FStructPropertyJson() { }

        public override string Name => "struct";
        public override int Size => 0;
        public override string TypeName => FStructProperty.TYPE_NAME;

        public override object FromNative(FPropertyTag tag, Transfer transfer = null)
        {
            //building the global key of the Tag type
            string globalKey = $"{FStructProperty.TYPE_NAME} {tag.StructName}";
            if (!transfer.GlobalObjects.GlobalTypeNames.ContainsKey(globalKey))
            {
                transfer.GlobalObjects.GlobalTypeNames[globalKey] = new GlobalTypeName { TypeName = tag.TypeName };
            }

            //building the instance key of the Tag object
            string structName = $" {tag.StructName}";
            string name = tag.Name.ToString();
            string arrayIndex = tag.ArrayIndex.GetValueOrDefault() > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid.GetValueOrDefault() == 0 ? string.Empty : $" {{{tag.GuidValue}}}";
            string size = $" {tag.Size} ";
            string type = "struct";

            if (tag.PropertyTagFlags is { })
            {
                if (tag.PropertyTagFlags.Value.HasFlag(EPropertyTagFlags.HasBinaryOrNativeSerialize))
                    type = "class";

                tag.PropertyTagFlags &= ~EPropertyTagFlags.HasArrayIndex;
                tag.PropertyTagFlags &= ~EPropertyTagFlags.HasPropertyGuid;
                tag.PropertyTagFlags &= ~EPropertyTagFlags.HasBinaryOrNativeSerialize;
                tag.PropertyTagFlags = tag.PropertyTagFlags == EPropertyTagFlags.None ? null : tag.PropertyTagFlags;
            }
            string propertyTagFlags = tag.PropertyTagFlags is { } ? $" PropertyTagFlags({tag.PropertyTagFlags})" : string.Empty;

            string propertyTagExtensions = tag.PropertyTagExtensions is { } ? $" PropertyTagExtensions({tag.PropertyTagExtensions})" : string.Empty;
            string overrideOperation = tag.OverrideOperation is { } ? $" OverrideOperation({tag.OverrideOperation})" : string.Empty;
            string bExperimentalOverridableLogic = tag.bExperimentalOverridableLogic is { } ? $" bExperimentalOverridableLogic({tag.bExperimentalOverridableLogic})" : string.Empty;

            string key = $"{type}{structName}{size}'{name}'{arrayIndex}{guidValue}{propertyTagFlags}{propertyTagExtensions}{overrideOperation}{bExperimentalOverridableLogic}";

            Add(key, tag.Value);
            return this;
        }

        public override FPropertyTag GetNative(Transfer transfer, string key, object value)
        {
            //reading the indices of name
            int name1 = key.IndexOf('\'');
            int name2 = name1 == -1 ? -1 : key.IndexOf('\'', name1 + 1);
            //reading the indices of fields before name
            int structName1 = key.IndexOf(' ');
            int structName2 = key.IndexOf(' ', structName1 + 1);
            int size1 = key.IndexOf(' ', structName2);
            int size2 = key.IndexOf(' ', size1 + 1);
            //reading the indices of fields after name
            int index1 = key.IndexOf('[') is var validIndex1 && validIndex1 > name2 ? validIndex1 : -1;
            int index2 = index1 == -1 ? -1 : key.IndexOf(']') is var validIndex2 && validIndex2 > name2 ? validIndex2 : -1;
            int guid1 = key.IndexOf('{') is var validGuid1 && validGuid1 > name2 ? validGuid1 : -1;
            int guid2 = guid1 == -1 ? -1 : key.IndexOf('}') is var validGuid2 && validGuid2 > name2 ? validGuid2 : -1;
            int propertyTagFlags1 = key.IndexOf("PropertyTagFlags(") is var validPropertyTagFlags1 && validPropertyTagFlags1 > name2 ? validPropertyTagFlags1 + "PropertyTagFlags(".Length : -1;
            int propertyTagFlags2 = propertyTagFlags1 == -1 ? -1 : key.IndexOf(')', propertyTagFlags1) is var validPropertyTagFlags2 && validPropertyTagFlags2 > name2 ? validPropertyTagFlags2 : -1;
            int propertyTagExtensions1 = key.IndexOf("PropertyTagExtensions(") is var validPropertyTagExtensions1 && validPropertyTagExtensions1 > name2 ? validPropertyTagExtensions1 + "PropertyTagExtensions(".Length : -1;
            int propertyTagExtensions2 = propertyTagExtensions1 == -1 ? -1 : key.IndexOf(')', propertyTagExtensions1) is var validPropertyTagExtensions2 && validPropertyTagExtensions2 > name2 ? validPropertyTagExtensions2 : -1;
            int overrideOperation1 = key.IndexOf("OverrideOperation(") is var validOverrideOperation1 && validOverrideOperation1 > name2 ? validOverrideOperation1 + "OverrideOperation(".Length : -1;
            int overrideOperation2 = overrideOperation1 == -1 ? -1 : key.IndexOf(')', overrideOperation1) is var validOverrideOperation2 && validOverrideOperation2 > name2 ? validOverrideOperation2 : -1;
            int bExperimentalOverridableLogic1 = key.IndexOf("bExperimentalOverridableLogic(") is var validBExperimentalOverridableLogic1 && validBExperimentalOverridableLogic1 > name2 ? validBExperimentalOverridableLogic1 + "bExperimentalOverridableLogic(".Length : -1;
            int bExperimentalOverridableLogic2 = bExperimentalOverridableLogic1 == -1 ? -1 : key.IndexOf(')', bExperimentalOverridableLogic1) is var validBExperimentalOverridableLogic2 && validBExperimentalOverridableLogic2 > name2 ? validBExperimentalOverridableLogic2 : -1;
            //reading the field values
            string name = name1 > 0 && name2 > 0 ? key[(name1 + 1)..(name2)] : default;
            string structName = structName1 > 0 && structName2 > 0 ? key[(structName1 + 1)..(structName2)] : default;
            string size = size1 > 0 && size2 > 0 ? key[(size1 + 1)..(size2)] : default;
            string index = index1 > 0 && index2 > 0 ? key[(index1 + 1)..(index2)] : default;
            string guid = guid1 > 0 && guid2 > 0 ? key[(guid1 + 1)..(guid2)] : default;
            string propertyTagFlags = propertyTagFlags1 > 0 && propertyTagFlags2 > 0 ? key[propertyTagFlags1..propertyTagFlags2] : default;
            string propertyTagExtensions = propertyTagExtensions1 > 0 && propertyTagExtensions2 > 0 ? key[propertyTagExtensions1..propertyTagExtensions2] : default;
            string overrideOperation = overrideOperation1 > 0 && overrideOperation2 > 0 ? key[overrideOperation1..overrideOperation2] : default;
            string bExperimentalOverridableLogic = bExperimentalOverridableLogic1 > 0 && bExperimentalOverridableLogic2 > 0 ? key[bExperimentalOverridableLogic1..bExperimentalOverridableLogic2] : default;

            FPropertyTag tag = new();

            string globalKey = $"{FStructProperty.TYPE_NAME} {structName}";

            if (transfer.GlobalObjects.GlobalTypeNames.ContainsKey(globalKey))
            {
                tag.TypeName = transfer.GlobalObjects.GlobalTypeNames[globalKey].TypeName;
            }

            tag.Name = new FName(name, transfer);
            tag.EnumName = null;
            tag.Type = new FName(TypeName, transfer);
            tag.StructName = new FName(structName, transfer);
            tag.BoolVal = 0;
            tag.Value = value;
            tag.Size = int.Parse(size);
            tag.ArrayIndex = int.TryParse(index, out int i) && i > 0 ? i : null;
            tag.HasPropertyGuid = guid is { } ? 1 : null;
            tag.PropertyGuid = guid is { } ? new FGuid(guid) : null;
            tag.PropertyTagFlags = propertyTagFlags is { } ? (EPropertyTagFlags?)Enum.Parse(typeof(EPropertyTagFlags), propertyTagFlags) : null;
            tag.PropertyTagExtensions = propertyTagExtensions is { } ? (EPropertyTagExtension?)Enum.Parse(typeof(EPropertyTagExtension), propertyTagExtensions) : null;
            tag.OverrideOperation = overrideOperation is { } ? (EOverriddenPropertyOperation?)Enum.Parse(typeof(EOverriddenPropertyOperation), overrideOperation) : null;
            tag.bExperimentalOverridableLogic = bExperimentalOverridableLogic is { } ? (bool?)bool.Parse(bExperimentalOverridableLogic) : null;

            //reconstructing the flags
            if (transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME)
                tag.PropertyTagFlags = EPropertyTagFlags.None;
            if (tag.ArrayIndex is { })
                tag.PropertyTagFlags |= EPropertyTagFlags.HasArrayIndex;
            if (tag.HasPropertyGuid is { })
                tag.PropertyTagFlags |= EPropertyTagFlags.HasPropertyGuid;
            if (key.StartsWith("class "))
                tag.PropertyTagFlags |= EPropertyTagFlags.HasBinaryOrNativeSerialize;

            return tag;
        }
    }
}

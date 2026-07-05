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
            string globalKey = $"{tag.Type} | {tag.InnerType} | {tag.StructName} | {tag.ValueType} | {tag.EnumName}";
            if (!transfer.GlobalObjects.GlobalTypeNames.ContainsKey(globalKey))
            {
                transfer.GlobalObjects.GlobalTypeNames[globalKey] = new GlobalTypeName
                {
                    TypeName = tag.TypeName,
                    PropertyTagExtensions = tag.PropertyTagExtensions,
                    OverrideOperation = tag.OverrideOperation,
                    bExperimentalOverridableLogic = tag.bExperimentalOverridableLogic,
                    PropertyTagFlags = tag.PropertyTagFlags,
                };
            }

            //building the instance key of the Tag object
            string structName = $" {tag.StructName}";
            string name = tag.Name.ToString();
            string arrayIndex = tag.ArrayIndex.GetValueOrDefault() > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid.GetValueOrDefault() == 0 ? string.Empty : $" {{{tag.GuidValue}}}";
            string size = $" {tag.Size} ";
            
            string key = $"{Name}{structName}{size}'{name}'{arrayIndex}{guidValue}";

            Add(key, tag.Value);
            return this;
        }

        public override FPropertyTag GetNative(Transfer transfer, string key, object value)
        {
            //reading the work indices
            int name1 = key.IndexOf('\'');
            int name2 = name1 == -1 ? -1 : key.IndexOf('\'', name1 + 1);
            //fields before name
            int structName1 = key.IndexOf(' ');
            int structName2 = key.IndexOf(' ', structName1 + 1);
            int size1 = key.IndexOf(' ', structName2);
            int size2 = key.IndexOf(' ', size1 + 1);
            //fields after name
            int index1 = key.IndexOf('[') is var validIndex1 && validIndex1 > name2 ? validIndex1 : -1;
            int index2 = index1 == -1 ? -1 : key.IndexOf(']') is var validIndex2 && validIndex2 > name2 ? validIndex2 : -1;
            int guid1 = key.IndexOf('{') is var validGuid1 && validGuid1 > name2 ? validGuid1 : -1;
            int guid2 = guid1 == -1 ? -1 : key.IndexOf('}') is var validGuid2 && validGuid2 > name2 ? validGuid2 : -1;

            //reading the word values
            string name = name1 > 0 && name2 > 0 ? key[(name1 + 1)..(name2)] : default;
            string structName = structName1 > 0 && structName2 > 0 ? key[(structName1 + 1)..(structName2)] : default;
            string size = size1 > 0 && size2 > 0 ? key[(size1 + 1)..(size2)] : default;
            string index = index1 > 0 && index2 > 0 ? key[(index1 + 1)..(index2)] : default;
            string guid = guid1 > 0 && guid2 > 0 ? key[(guid1 + 1)..(guid2)] : default;

            FPropertyTag native = new();

            string globalKey = $"{FStructProperty.TYPE_NAME} |  | {structName} |  | ";

            if (transfer.GlobalObjects.GlobalTypeNames.ContainsKey(globalKey))
            {
                var globalTypeName = transfer.GlobalObjects.GlobalTypeNames[globalKey];

                native.TypeName = globalTypeName.TypeName;
                native.PropertyTagExtensions = globalTypeName.PropertyTagExtensions;
                native.OverrideOperation = globalTypeName.OverrideOperation;
                native.bExperimentalOverridableLogic = globalTypeName.bExperimentalOverridableLogic;
                native.PropertyTagFlags = globalTypeName.PropertyTagFlags;
            }

            native.Name = new FName(name, transfer);
            native.EnumName = new FName("None", transfer);
            native.Type = new FName(TypeName, transfer);
            native.StructName = new FName(structName, transfer);
            native.BoolVal = null;
            native.Value = value;
            native.Size = int.Parse(size);
            native.ArrayIndex = int.TryParse(index, out int i) && i > 0 ? i : null;
            native.HasPropertyGuid = guid is { } ? 1 : null;
            native.PropertyGuid = guid is { } ? new FGuid(guid) : null;

            return native;
        }
    }
}

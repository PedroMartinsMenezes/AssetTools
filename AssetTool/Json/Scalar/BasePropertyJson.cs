namespace AssetTool
{
    public class BasePropertyJson : Dictionary<string, object>, IPropertytag
    {
        public virtual string Name { get; }
        public virtual int Size { get; }
        public virtual int ComputedSize(Transfer transfer, object value) => 0;
        public virtual string TypeName { get; }
        public virtual string StructName { get; }
        public virtual object DerivedValue(object value) => value;
        public virtual object BaseValue(Transfer transfer, object value) => value;

        public BasePropertyJson() { }

        public virtual object FromNative(FPropertyTag tag, Transfer transfer = null)
        {
            string key = BuildKey(Name, tag);
            object value = TypeName == FBoolProperty.TYPE_NAME ? tag.BoolVal == 1 : DerivedValue(tag.Value);
            Add(key, value);
            return this;
        }

        public FPropertyTag ToNative(Transfer transfer)
        {
            return GetNative(transfer, Keys.First(), Values.First());
        }

        public virtual FPropertyTag GetNative(Transfer transfer, string key, object value)
        {
            byte boolVal = TypeName == FBoolProperty.TYPE_NAME ? (Convert.ToBoolean(value) ? (byte)1 : (byte)0) : (byte)0;
            string name, enumName, index, guid, enumInnerType, typeNamespace;
            ExtractKey(key, out name, out enumName, out index, out guid, out enumInnerType, out typeNamespace);
            byte hasPropertyGuid = (byte)(guid is { } ? 1 : 0);
            int arrayIndex = index is { } ? int.Parse(index) : 0;
            FPropertyTypeName typeName = ExtractTypeName(transfer, TypeName, enumName, StructName, default, default, name, enumInnerType, typeNamespace);
            EPropertyTagFlags propertyTagFlags = ExtractPropertyTagFlags(boolVal, hasPropertyGuid, arrayIndex, StructName);
            return new FPropertyTag
            {
                Name = new FName(name, transfer),
                EnumName = enumName is { } ? new FName(enumName, transfer) : new FName("None", transfer),
                Type = new FName(TypeName, transfer),
                StructName = StructName is { } ? new FName(StructName, transfer) : default,
                BoolVal = boolVal == 1 ? 1 : null,
                Value = BaseValue(transfer, value),
                Size = Math.Max(Size, ComputedSize(transfer, value)),
                ArrayIndex = int.TryParse(index, out int i) && i > 0 ? i : null,
                HasPropertyGuid = hasPropertyGuid == 1 ? 1 : null,
                PropertyGuid = guid is { } ? new FGuid(guid) : default,
                TypeName = typeName,
                PropertyTagFlags = propertyTagFlags,
            };
        }

        //Simplificar na versão nova usando o GlobalTypeNames
        public static EPropertyTagFlags ExtractPropertyTagFlags(byte boolVal, byte hasPropertyGuid, int arrayIndex, string structName)
        {
            EPropertyTagFlags flags = EPropertyTagFlags.None;
            if (boolVal == 1)
            {
                flags |= EPropertyTagFlags.BoolTrue;
            }
            if (hasPropertyGuid == 1)
            {
                flags |= EPropertyTagFlags.HasPropertyGuid;
            }
            if (arrayIndex > 0)
            {
                flags |= EPropertyTagFlags.HasArrayIndex;
            }
            if (structName is { })
            {
                flags |= EPropertyTagFlags.HasBinaryOrNativeSerialize;
            }
            return flags;
        }

        //Simplificar na versão nova gravando uma chave simples
        public virtual string BuildKey(string type, FPropertyTag tag)
        {
            string enumName = !tag.EnumName.IsFilled() ? " " : $" ({tag.EnumName.Value}) ";
            string arrayIndex = tag.ArrayIndex.GetValueOrDefault() > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid.GetValueOrDefault() == 0 ? string.Empty : $" {{{tag.GuidValue}}}";
            string typeNamespace = tag.TypeNamespace is { } ? $" {tag.TypeNamespace.Value}" : string.Empty;
            string enumInnerType = tag.EnumInnerType is { } ? $" {tag.EnumInnerType.Value}" : string.Empty;
            return $"{type}{enumName}'{tag.Name.ToString()}'{arrayIndex}{guidValue}{enumInnerType}{typeNamespace}";
        }

        //Simplificar na versão nova usando o GlobalTypeNames
        public static void ExtractKey(string key, out string name, out string enumName, out string index, out string guid, out string enumInnerType, out string typeNamespace)
        {
            key = key.Contains(FName.DOUBLE_SEPARATOR) ? key.Substring(0, key.IndexOf(FName.DOUBLE_SEPARATOR)) : key;
            int name1 = key.IndexOf('\'');
            int name2 = name1 == -1 ? -1 : key.IndexOf('\'', name1 + 1);
            int enumName1 = key.IndexOf('(') is var validEnumName1 && validEnumName1 < name1 ? validEnumName1 : -1;
            int enumName2 = key.IndexOf(')') is var validEnumName2 && validEnumName2 < name1 ? validEnumName2 : -1;
            int index1 = key.IndexOf('[') is var validIndex1 && validIndex1 > name2 ? validIndex1 : -1;
            int index2 = index1 == -1 ? -1 : key.IndexOf(']') is var validIndex2 && validIndex2 > name2 ? validIndex2 : -1;
            int guid1 = key.IndexOf('{') is var validGuid1 && validGuid1 > name2 ? validGuid1 : -1;
            int guid2 = guid1 == -1 ? -1 : key.IndexOf('}') is var validGuid2 && validGuid2 > name2 ? validGuid2 : -1;

            name = name1 > 0 && name2 > 0 ? key[(name1 + 1)..(name2)] : default;
            enumName = enumName1 > 0 && enumName2 > 0 ? key[(enumName1 + 1)..(enumName2)] : default;
            index = index1 > 0 && index2 > 0 ? key[(index1 + 1)..(index2)] : default;
            guid = guid1 > 0 && guid2 > 0 ? key[(guid1 + 1)..(guid2)] : default;

            int lastIndex = Math.Max(name2, Math.Max(index2, guid2)) + 1;

            enumInnerType = default;
            typeNamespace = default;

            if (lastIndex < key.Length - 1)
            {
                if (enumName == default)
                {
                    enumName = "None";
                    typeNamespace = key[lastIndex] != '.' ? key.Substring(lastIndex + 1) : default;
                }
                else
                {
                    string suffix = key[lastIndex] != '.' ? key.Substring(lastIndex + 1) : default;
                    if (suffix is { })
                    {
                        string[] parts = suffix.Split(' ');
                        if (parts.Length == 2)
                        {
                            enumInnerType = suffix.Split(' ')[0];
                            typeNamespace = suffix.Split(' ')[1];
                        }
                        else
                        {
                            typeNamespace = suffix.Split(' ')[0];
                        }
                    }
                }
            }
        }

        //Simplificar na versão nova usando o GlobalTypeNames
        public static FPropertyTypeName ExtractTypeName(Transfer transfer, string type, string enumName, string structName, string innerType, string valueType, string name, string enumInnerType, string typeNamespace)
        {
            if (!transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME)
                return default;
            FPropertyTypeName typeName = new();
            if (type == FStructProperty.TYPE_NAME)
            {
                typeName.Nodes.Add(new() { Name = new FName(type, transfer), InnerCount = 1 });
                typeName.Nodes.Add(new() { Name = new FName(structName, transfer), InnerCount = 1 });
                if (typeNamespace == default)
                    typeName.Nodes.Add(new() { Name = new FName(1, 0, transfer), InnerCount = 0 });
                else
                    typeName.Nodes.Add(new() { Name = new FName(typeNamespace, transfer), InnerCount = 0 });
            }
            else if (type is FByteProperty.TYPE_NAME)
            {
                if (enumName is { })
                {
                    typeName.Nodes.Add(new() { Name = new FName(type, transfer), InnerCount = 1 });
                    typeName.Nodes.Add(new() { Name = new FName(enumName, transfer), InnerCount = 1 });
                    if (typeNamespace == default)
                        typeName.Nodes.Add(new() { Name = new FName(1, 0, transfer), InnerCount = 0 });
                    else
                        typeName.Nodes.Add(new() { Name = new FName(typeNamespace, transfer), InnerCount = 0 });
                }
                else
                {
                    typeName.Nodes.Add(new() { Name = new FName(type, transfer), InnerCount = 0 });
                }
            }
            else if (type is FEnumProperty.TYPE_NAME)
            {
                if (enumName is { })
                {
                    typeName.Nodes.Add(new() { Name = new FName(type, transfer), InnerCount = 2 });
                    typeName.Nodes.Add(new() { Name = new FName(enumName, transfer), InnerCount = 1 });
                    if (typeNamespace == default)
                        typeName.Nodes.Add(new() { Name = new FName(1, 0, transfer), InnerCount = 0 });
                    else
                        typeName.Nodes.Add(new() { Name = new FName(typeNamespace, transfer), InnerCount = 0 });
                    typeName.Nodes.Add(new() { Name = new FName(enumInnerType, transfer), InnerCount = 0 });
                }
                else
                {
                    typeName.Nodes.Add(new() { Name = new FName(type, transfer), InnerCount = 0 });
                }
            }
            else if (type == FMapProperty.TYPE_NAME)
            {
                typeName.Nodes.Add(new() { Name = new FName(type, transfer), InnerCount = 2 });
                typeName.Nodes.Add(new() { Name = new FName(innerType, transfer), InnerCount = 0 });
                typeName.Nodes.Add(new() { Name = new FName(valueType, transfer), InnerCount = 0 });
            }
            else if (type == FSetProperty.TYPE_NAME)
            {
                typeName.Nodes.Add(new() { Name = new FName(type, transfer), InnerCount = 1 });
                typeName.Nodes.Add(new() { Name = new FName(valueType, transfer), InnerCount = 0 });
            }
            else if (type == Consts.ArrayProperty)
            {
                typeName.Nodes.Add(new() { Name = new FName(type, transfer), InnerCount = 1 });
                typeName.Nodes.Add(new() { Name = new FName(innerType, transfer), InnerCount = 0 });
                if (enumName is { })
                {
                    typeName.Nodes[1].InnerCount = 1;
                    typeName.Nodes.Add(new() { Name = new FName(enumName, transfer), InnerCount = 1 });
                }
                if (typeNamespace == default)
                    typeName.Nodes.Add(new() { Name = new FName(1, 0, transfer), InnerCount = 0 });
                else
                    typeName.Nodes.Add(new() { Name = new FName(typeNamespace, transfer), InnerCount = 0 });
            }
            else
            {
                typeName.Nodes.Add(new() { Name = new FName(type, transfer), InnerCount = 0 });
            }
            return typeName;
        }
    }
}

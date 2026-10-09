namespace AssetTool
{
    public class BasePropertyJson : Dictionary<string, object>, IPropertytag
    {
        public virtual string Name { get; }
        public virtual int Size { get; set; }
        public virtual int ComputedSize(Transfer transfer, object value) => 0;
        public virtual string TypeName { get; set; }
        public virtual string StructName { get; set; }
        public virtual string InnerType { get; set; }
        public virtual string ValueType { get; set; }
        public virtual object FromNativeValue(object value) => value;
        public virtual string FromNativeFields(FPropertyTag tag) => string.Empty;
        public virtual string BuildTypeNameKey(FPropertyTag tag, Transfer transfer = null) => tag.TypeNameString();
        public virtual string RebuildTypeNameKey(string key) => null;
        public virtual object ToNativeValue(Transfer transfer, object value) => value;

        public BasePropertyJson() { }

        public virtual object FromNative(FPropertyTag tag, Transfer transfer = null)
        {
            if (transfer is { } && transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME)
            {
                string globalKey = BuildTypeNameKey(tag, transfer);
                if (!transfer.GlobalObjects.GlobalTypeNames.ContainsKey(globalKey))
                {
                    transfer.GlobalObjects.GlobalTypeNames[globalKey] = new GlobalTypeName { TypeName = tag.TypeName };
                }
            }
            string key = BuildKey(Name, tag, FromNativeFields);
            object value = TypeName == FBoolProperty.TYPE_NAME ? tag.BoolVal == 1 : FromNativeValue(tag.Value);
            Add(key, value);
            return this;
        }

        public virtual FPropertyTag ToNative(Transfer transfer)
        {
            return ToNative(transfer, Keys.First(), Values.First());
        }

        public virtual FPropertyTag ToNative(Transfer transfer, string key, object value)
        {
            byte boolVal = TypeName == FBoolProperty.TYPE_NAME ? (Convert.ToBoolean(value) ? (byte)1 : (byte)0) : (byte)0;
            string name, native, enumName, index, guid, enumInnerType, typeNamespace;
            ExtractKey(transfer, TypeName, key, out name, out native, out enumName, out index, out guid, out enumInnerType, out typeNamespace);
            byte hasPropertyGuid = (byte)(guid is { } ? 1 : 0);
            int arrayIndex = index is { } ? int.Parse(index) : 0;
            EPropertyTagFlags? propertyTagFlags = ExtractPropertyTagFlags(boolVal, hasPropertyGuid, arrayIndex, native);

            FPropertyTypeName typeName = null;
            if (transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME)
            {
                //use the specific function to recreate the 'typeName'
                if (RebuildTypeNameKey(key) is string globalKey && transfer.GlobalObjects.GlobalTypeNames.ContainsKey(globalKey))
                    typeName = transfer.GlobalObjects.GlobalTypeNames[globalKey].TypeName;
                else
                    //use a generic function to recreate the 'typeName'
                    typeName = ExtractTypeName(transfer, TypeName, enumName, StructName, InnerType, ValueType, name, enumInnerType, typeNamespace);
            }

            FPropertyTag tag = new()
            {
                Name = new FName(name, transfer),
                EnumName = enumName is { } ? new FName(enumName, transfer) : null,
                Type = new FName(TypeName, transfer),
                StructName = StructName is { } ? new FName(StructName, transfer) : null,
                BoolVal = boolVal == 1 ? (byte)1 : (byte)0,
                Value = ToNativeValue(transfer, value),
                Size = Math.Max(Size, ComputedSize(transfer, value)),
                ArrayIndex = int.TryParse(index, out int i) && i > 0 ? i : null,
                HasPropertyGuid = hasPropertyGuid == 1 ? 1 : null,
                PropertyGuid = guid is { } ? new FGuid(guid) : null,
                TypeName = typeName,
                PropertyTagFlags = propertyTagFlags,
                InnerType = InnerType is { } ? new FName(InnerType, transfer) : null,
                ValueType = ValueType is { } ? new FName(ValueType, transfer) : null,
            };

            return tag;
        }

        //Simplificar na versão nova usando o GlobalTypeNames
        public static EPropertyTagFlags? ExtractPropertyTagFlags(byte boolVal, byte hasPropertyGuid, int arrayIndex, string native)
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
            if (native is { })
            {
                flags |= EPropertyTagFlags.HasBinaryOrNativeSerialize;
            }
            return flags == EPropertyTagFlags.None ? null : flags;
        }

        //Simplificar na versão nova gravando uma chave simples
        public virtual string BuildKey(string type, FPropertyTag tag, Func<FPropertyTag, string> extraFieldsCallback = null)
        {
            string native = tag.PropertyTagFlags is { } && tag.PropertyTagFlags.Value.HasFlag(EPropertyTagFlags.HasBinaryOrNativeSerialize) ? "native " : string.Empty;

            string enumName = !tag.EnumName.IsFilled() ? string.Empty : $"({tag.EnumName.Value}) ";

            string arrayIndex = tag.ArrayIndex.GetValueOrDefault() <= 0 ? string.Empty : $"[{tag.ArrayIndex}] ";

            string guidValue = tag.HasPropertyGuid.GetValueOrDefault() == 0 ? string.Empty : $"{{{tag.GuidValue}}} ";

            string enumInnerType = tag.EnumInnerType is null ? string.Empty : $"EnumInnerType({tag.EnumInnerType.Value}) ";

            string typeNamespace = tag.TypeNamespace is null ? string.Empty : $"TypeNamespace({tag.TypeNamespace.Value}) ";

            string extraFields = extraFieldsCallback?.Invoke(tag) ?? string.Empty;

            return $"{type} {native}{enumName}{arrayIndex}{guidValue}{enumInnerType}{typeNamespace}{extraFields}'{tag.Name.ToString()}'";
        }

        //Simplificar na versão nova usando o GlobalTypeNames
        public static string ExtractKey(Transfer transfer, string typeName, string key, out string name, out string native, out string enumName, out string arrayIndex, out string guidValue, out string enumInnerType, out string typeNamespace)
        {
            string originalKey = key;
            key = key[(key.IndexOf(' ') + 1)..];
            key = key.Contains(FName.DOUBLE_SEPARATOR) ? key.Substring(0, key.IndexOf(FName.DOUBLE_SEPARATOR)) : key;

            string prefix = key[0..(key.IndexOf("'"))];

            native = originalKey.IndexOf(" native ") == originalKey.IndexOf(' ') ? "native" : null;

            enumName = originalKey.IndexOf(' ') == originalKey.IndexOf('(') - 1 ? prefix.GetNonNull("({0})", x => x) : null;
            enumName = enumName is { } ? enumName : originalKey.IndexOf(" native ") + 8 == originalKey.IndexOf('(') ? prefix.GetNonNull("({0})", x => x) : null;
            //use the same logic of LoadPropertyTagNoFullType
            if ((typeName == FByteProperty.TYPE_NAME || typeName == FEnumProperty.TYPE_NAME) && enumName is null && !transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME)
            {
                enumName = "None";
            }

            arrayIndex = prefix.GetNonNull("[{0}]", x => x);
            guidValue = prefix.GetNonNull("{{0}}", x => x);
            enumInnerType = prefix.GetNonNull("EnumInnerType({0})", x => x);
            typeNamespace = prefix.GetNonNull("TypeNamespace({0})", x => x);

            name = key[(key.IndexOf("'") + 1)..^1];

            return prefix;
        }

        //@@@ Incomplete logic: Should handle: InnerType(StructPropert) + StructName(Guid)
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
                typeName.Nodes.Add(new() { Name = new FName(innerType, transfer), InnerCount = 0 });
                if (innerType == FStructProperty.TYPE_NAME)
                {
                    typeName.Nodes[1].InnerCount = 1;
                    typeName.Nodes.Add(new() { Name = new FName(structName, transfer), InnerCount = 1 });
                }
            }
            else if (type == FArrayProperty.TYPE_NAME)
            {
                typeName.Nodes.Add(new() { Name = new FName(type, transfer), InnerCount = 1 });
                typeName.Nodes.Add(new() { Name = new FName(innerType, transfer), InnerCount = 0 });
                if (structName is { })
                {
                    typeName.Nodes[1].InnerCount = 1;
                    typeName.Nodes.Add(new() { Name = new FName(structName, transfer), InnerCount = 1 });
                }
                if (enumName is { })
                {
                    typeName.Nodes[1].InnerCount = 1;
                    typeName.Nodes.Add(new() { Name = new FName(enumName, transfer), InnerCount = 1 });
                }
                if (typeNamespace is { })
                    typeName.Nodes.Add(new() { Name = new FName(typeNamespace, transfer), InnerCount = 0 });
                else
                    typeName.Nodes.Add(new() { Name = new FName(1, 0, transfer), InnerCount = 0 });
            }
            else
            {
                typeName.Nodes.Add(new() { Name = new FName(type, transfer), InnerCount = 0 });
            }
            return typeName;
        }
    }
}

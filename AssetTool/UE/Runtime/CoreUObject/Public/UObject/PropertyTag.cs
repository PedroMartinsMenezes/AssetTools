using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("Tag: {Name.Value == \"None\" ? \"None\" : $\"{Name} {Type} {StructName} {InnerType} {ValueType} {Size} ({HeaderOffset} {ValueOffset} {EndOffset})\"}")]
    public class FPropertyTag : ITransferable
    {
        #region Json Members
        public FName Name;
        public FName Type;
        public Int32 Size;
        public Int32? ArrayIndex;
        public byte? HasPropertyGuid;
        public FGuid? PropertyGuid;
        public FName StructName;
        public FGuid? StructGuid;
        public byte? BoolVal;
        public FName EnumName;
        public FName InnerType;
        public FName ValueType;
        public FPropertyTag MaybeInnerTag;
        public object Value;
        #endregion

        #region JsonIgnore: Saved in GlobalTypeNames
        public FPropertyTypeName TypeName;
        public EPropertyTagExtension? PropertyTagExtensions;
        public EOverriddenPropertyOperation? OverrideOperation;
        public bool? bExperimentalOverridableLogic;
        public EPropertyTagFlags? PropertyTagFlags;
        #endregion

        #region JsonIgnore
        [JsonIgnore]
        public FName KeyType => TypeName?.KeyType ?? InnerType;

        [JsonIgnore]
        public FName EnumInnerType;

        [JsonIgnore]
        public FName TypeNamespace;

        [JsonIgnore]
        public FPropertyTag ParentTag;

        [JsonIgnore]
        public long HeaderOffset;

        [JsonIgnore]
        public long ValueOffset;

        [JsonIgnore]
        public long EndOffset;

        [JsonIgnore]
        public string GuidValue => HasPropertyGuid.GetValueOrDefault() == 0 ? string.Empty : PropertyGuid.ToString();

        [JsonIgnore]
        public string JsonKey => Type?.Value == FStructProperty.TYPE_NAME && StructName.IsFilled() ? $"{StructName.Value}" : $"{Type?.Value}";

        [JsonIgnore]
        public int ArrayElementSize;
        #endregion

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FPropertyTag& Tag)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME)
                return LoadPropertyTagNoFullType(transfer);

            transfer.Move(ref Name);

            if (transfer.AppConfig.DenyNamesStartedWithSlash && Name.Value.StartsWith('/'))
                throw new InvalidOperationException($"Invalid Name: {Name.Value}");

            if (!Name.IsFilled())
                return this;

            transfer.Move(ref TypeName);

            Type = TypeName.Type;
            FPropertyTagExt.CheckTagType(transfer, Type);

            EnumName = TypeName.EnumName;
            StructName = TypeName.StructName;
            InnerType = TypeName.InnerType;
            ValueType = TypeName.ValueType;

            transfer.Move(ref Size);

            if (transfer.AppConfig.BreakWhenTagSizeIsZero && Size == 0 && Type?.Value != FBoolProperty.TYPE_NAME)
                throw new InvalidOperationException($"Invalid Size: 0");

            transfer.MoveEnum(ref PropertyTagFlags);

            EPropertyTagFlags propertyTagFlags = PropertyTagFlags.HasValue ? PropertyTagFlags.Value : default;

            BoolVal = propertyTagFlags.HasFlag(EPropertyTagFlags.BoolTrue) ? (byte)1 : (byte)0;

            HasPropertyGuid = propertyTagFlags.HasFlag(EPropertyTagFlags.HasPropertyGuid) ? 1 : null;

            if (propertyTagFlags.HasFlag(EPropertyTagFlags.HasArrayIndex))
                transfer.Move(ref ArrayIndex);
            ArrayIndex = ArrayIndex == 0 ? null : ArrayIndex;

            if (propertyTagFlags.HasFlag(EPropertyTagFlags.HasPropertyGuid))
                transfer.Move(ref PropertyGuid);

            if (propertyTagFlags.HasFlag(EPropertyTagFlags.HasPropertyExtensions))
                SerializePropertyExtensions(transfer);

            if (TypeName.Nodes[0].Name.Value == Consts.ArrayProperty && TypeName.Nodes.Count == 4 && TypeName.Nodes[^1].Name.ComparisonIndex.Value != 1)
            {
                TypeNamespace = TypeName.Nodes[3].Name;
            }
            else if (TypeName.Nodes[0].Name.Value == FEnumProperty.TYPE_NAME && TypeName.Nodes.Count == 4)
            {
                TypeNamespace = TypeName.Nodes[2].Name;
                EnumInnerType = TypeName.Nodes[3].Name;
            }
            else if (TypeName.Nodes[0].Name.Value == FStructProperty.TYPE_NAME && TypeName.Nodes.Count == 3 && TypeName.Nodes[^1].Name.ComparisonIndex.Value != 1)
            {
                TypeNamespace = TypeName.Nodes[2].Name;
            }
            else if (TypeName.Nodes[0].Name.Value == FStructProperty.TYPE_NAME && TypeName.Nodes.Count == 4 && TypeName.Nodes[^1].Name.ComparisonIndex.Value != 1)
            {
                TypeNamespace = TypeName.Nodes[3].Name;
            }
            else if (TypeName.Nodes[0].Name.Value == FByteProperty.TYPE_NAME && TypeName.Nodes.Count == 3 && TypeName.Nodes[^1].Name.ComparisonIndex.Value != 1)
            {
                TypeNamespace = TypeName.Nodes[2].Name;
            }
            else
            {
                TypeNamespace = default;
            }
            return this;
        }

        private FPropertyTag LoadPropertyTagNoFullType(Transfer transfer)
        {
            transfer.Move(ref Name);

            if (transfer.AppConfig.DenyNamesStartedWithSlash && Name.Value.StartsWith('/'))
                throw new InvalidOperationException($"Invalid Name: {Name.Value}");

            if (!Name.IsFilled())
                return this;

            transfer.Move(ref Type);

            FPropertyTagExt.CheckTagType(transfer, Type);

            transfer.Move(ref Size);
            transfer.Move(ref ArrayIndex);
            ArrayIndex = ArrayIndex == 0 ? null : ArrayIndex;

            if (Type.Number == 0)
            {
                if (Type.Value == FStructProperty.TYPE_NAME)
                {
                    transfer.Move(ref StructName);
                    if (transfer.Supports.VER_UE4_STRUCT_GUID_IN_PROPERTY_TAG)
                        transfer.Move(ref StructGuid);
                }
                else if (Type.Value == FBoolProperty.TYPE_NAME)
                    transfer.Move(ref BoolVal);
                else if (Type.Value == FByteProperty.TYPE_NAME)
                    transfer.Move(ref EnumName);
                else if (Type.Value == FEnumProperty.TYPE_NAME)
                    transfer.Move(ref EnumName);
                else if (Type.Value == Consts.ArrayProperty && transfer.Supports.VAR_UE4_ARRAY_PROPERTY_INNER_TAGS)
                    transfer.Move(ref InnerType);
                else if (Type.Value == Consts.OptionalProperty)
                    transfer.Move(ref InnerType);
                else if (Type.Value == FSetProperty.TYPE_NAME && transfer.Supports.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT)
                    transfer.Move(ref InnerType);
                else if (Type.Value == FMapProperty.TYPE_NAME && transfer.Supports.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT)
                {
                    transfer.Move(ref InnerType);
                    transfer.Move(ref ValueType);
                }
            }
            if (transfer.Supports.VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG)
            {
                transfer.Move(ref HasPropertyGuid);
                HasPropertyGuid = HasPropertyGuid.GetValueOrDefault() == 0 ? null : HasPropertyGuid;
                if (HasPropertyGuid.GetValueOrDefault() is not (0 or 1))
                {
                    throw new InvalidOperationException($"Invalid HasPropertyGuid: {HasPropertyGuid}");
                }
                if (HasPropertyGuid == 1)
                    transfer.Move(ref PropertyGuid);
            }

            if (transfer.Supports.PROPERTY_TAG_EXTENSION_AND_OVERRIDABLE_SERIALIZATION)
            {
                SerializePropertyExtensions(transfer);
            }

            return this;
        }

        private void SerializePropertyExtensions(Transfer transfer)
        {
            transfer.MoveEnum(ref PropertyTagExtensions);
            if (PropertyTagExtensions.HasValue && PropertyTagExtensions.Value.HasFlag(EPropertyTagExtension.OverridableInformation))
            {
                transfer.MoveEnum(ref OverrideOperation);
                transfer.Move(ref bExperimentalOverridableLogic);
            }
        }

        public int HeaderSize(Transfer transfer)
        {
            if (Type?.Value == FStructProperty.TYPE_NAME)
            {
                return StructHeaderSize(transfer);
            }
            else if (Type?.Value == Consts.ArrayProperty)
            {
                return ArrayHeaderSize(transfer);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public int StructHeaderSize(Transfer transfer)
        {
            const int nameSize = 8;
            const int typeSize = 8;
            const int sizeSize = 4;
            const int arrayIndexSize = 4;
            const int structNameSize = 8;
            int structGuidSize = transfer.Supports.VER_UE4_STRUCT_GUID_IN_PROPERTY_TAG ? 16 : 0;
            int propertyGuidSize = (transfer.Supports.VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG ? 1 : 0) + (HasPropertyGuid == 1 ? 16 : 0);
            int extensionSize = 0;
            if (transfer.Supports.PROPERTY_TAG_EXTENSION_AND_OVERRIDABLE_SERIALIZATION)
            {
                extensionSize = 1 + (PropertyTagExtensions.HasValue && PropertyTagExtensions.Value.HasFlag(EPropertyTagExtension.OverridableInformation) ? 5 : 0);
            }
            int size = nameSize + typeSize + sizeSize + arrayIndexSize + structNameSize + structGuidSize + propertyGuidSize + extensionSize;
            return size;
        }

        public static int SimpleStructHeaderSize(Transfer transfer)
        {
            return 48 + (transfer.Supports.VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG ? 1 : 0) + (transfer.Supports.PROPERTY_TAG_EXTENSION_AND_OVERRIDABLE_SERIALIZATION ? 1 : 0);
        }

        public static int ArrayHeaderSize(Transfer transfer)
        {
            return 48 + (transfer.Supports.VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG ? 1 : 0) + (transfer.Supports.PROPERTY_TAG_EXTENSION_AND_OVERRIDABLE_SERIALIZATION ? 1 : 0);
        }
    }

    public static class FPropertyTagExt
    {
        public static Dictionary<string, Func<Transfer, int, object, FPropertyTag, object>> StructMovers { get; } = new();
        public static Dictionary<string, Func<FPropertyTag, object>> DerivedConstructors { get; } = new();
        public static Dictionary<string, Func<Transfer, string, object, FPropertyTag>> NativeConstructors { get; } = new();

        #region List of Tags
        [Location("void UStruct::SerializeVersionedTaggedProperties")]
        public static Dictionary<string, object> MoveTags(this Transfer transfer, Dictionary<string, object> members, int indent = 0, UObject obj = default, FPropertyTag ParentTag = default)
        {
            obj ??= new();

            if (obj.bIsUClass && transfer.Supports.PROPERTY_TAG_EXTENSION_AND_OVERRIDABLE_SERIALIZATION)
            {
                obj.bIsUClass = false;
                transfer.MoveEnum(ref obj.SerializationControl);
            }
            if (transfer.IsWriting && members.Count == 0)
            {
                transfer.Move(ref transfer.GlobalNames.None);
                return members;
            }

            (bool quit, int i) = (false, 0);
            while (!quit)
            {
                FPropertyTag tag = transfer.IsReading ? new FPropertyTag() : BaseTag(members.ElementAt(i), transfer);
                tag.ParentTag = ParentTag;
                tag.HeaderOffset = transfer.Position;
                tag.Move(transfer);
                tag.ValueOffset = transfer.Position;
                tag.EndOffset = tag.ValueOffset + tag.Size;

                (long baseOffset, long endOffset) = (transfer.Position, transfer.Position + tag.Size);
                transfer.BaseOffset = baseOffset;
                if (tag.Name.IsFilled() && tag.Size > 0)
                {
                    transfer.MoveMember(tag, indent, baseOffset, obj);
                    transfer.Counter++;
                    if (transfer.Position != endOffset)
                    {
                        Log.Error($"{(transfer.IsReading ? "Read" : "Write")} Failed. Expected Offset {endOffset} but was {transfer.Position}. Break at tag.HeaderOffset == {tag.HeaderOffset} or {tag.HeaderOffset + transfer.GlobalObjects.CurrentObject.Offset}");
                        throw new InvalidOperationException();
                    }
                }
                if (transfer.IsReading)
                {
                    if (tag.Name.IsFilled())
                    {
                        var item = tag.Name.IsFilled() && indent >= 0 ? DerivedTag(transfer, tag) : tag;
                        if (item is Dictionary<string, object> dict)
                        {
                            string suffix = members.ContainsKey(dict.Keys.First()) ? $"{FName.DOUBLE_SEPARATOR}{tag.ValueOffset.ToString()}" : string.Empty;
                            members[$"{dict.Keys.First()}{suffix}"] = dict.Values.First();
                        }
                        else if (item is FPropertyTag member2)
                        {
                            string suffix = members.ContainsKey(member2.Name.ToString()) ? $"{FName.DOUBLE_SEPARATOR}{tag.ValueOffset.ToString()}" : string.Empty;
                            members[$"{member2.Name.ToString()}{suffix}"] = member2;
                        }
                    }
                }
                else if (i == members.Count - 1)
                {
                    transfer.Move(ref transfer.GlobalNames.None);
                    break;
                }
                quit = !tag.Name.IsFilled();
                transfer.Counter = quit ? 0 : transfer.Counter;
                i++;
            }
            return members;
        }
        #endregion

        #region DerivedTag
        private static object DerivedTag(Transfer transfer, FPropertyTag tag)
        {
            if (tag is { } && DerivedConstructors.TryGetValue(tag.JsonKey, out var func))
            {
                return func(tag);
            }

            if (tag == default || !tag.Type.IsFilled()) return tag;

            //struct types
            if (tag.Type.Value == FStructProperty.TYPE_NAME && tag.StructName?.Value != Consts.Guid) return new FStructPropertyJson().FromNative(tag, transfer);
            else if (tag.Type.Value == FStructProperty.TYPE_NAME && tag.StructName?.Value == Consts.Guid) return new FGuidPropertyJson().FromNative(tag);

            //primitive types
            else if (tag.Type.Value == FBoolProperty.TYPE_NAME) return new FBoolPropertyJson().FromNative(tag);
            else if (tag.Type.Value == FSoftObjectProperty.TYPE_NAME && tag.Size == 4) return new SoftObjectPropertyJson().FromNative(tag);
            else if (tag.Type.Value == FByteProperty.TYPE_NAME && tag.Size == 1) return new FBytePropertyJson().FromNative(tag);
            else if (tag.Type.Value == FInt8Property.TYPE_NAME && tag.Size == 1) return new FInt8PropertyJson().FromNative(tag);
            else if (tag.Type.Value == FByteProperty.TYPE_NAME && tag.Size == 4) return new FByte32PropertyJson().FromNative(tag);
            else if (tag.Type.Value == FByteProperty.TYPE_NAME && tag.Size == 8) return new FByte64PropertyJson().FromNative(tag);
            else if (tag.Type.Value == FDoubleProperty.TYPE_NAME) return new FDoublePropertyJson().FromNative(tag);
            else if (tag.Type.Value == FEnumProperty.TYPE_NAME && tag.Size == 4) return new FEnum32PropertyJson().FromNative(tag);
            else if (tag.Type.Value == FEnumProperty.TYPE_NAME && tag.Size == 8) return new FEnum64PropertyJson().FromNative(tag);
            else if (tag.Type.Value == FFloatProperty.TYPE_NAME) return new FFloatPropertyJson().FromNative(tag);
            else if (tag.Type.Value == FIntProperty.TYPE_NAME) return new FIntPropertyJson().FromNative(tag);
            else if (tag.Type.Value == FNameProperty.TYPE_NAME) return new FNamePropertyJson().FromNative(tag);
            else if (tag.Type.Value == FObjectProperty.TYPE_NAME) return new FObjectPropertyJson().FromNative(tag);
            else if (tag.Type.Value == FStrProperty.TYPE_NAME) return new FStrPropertyJson().FromNative(tag);
            else if (tag.Type.Value == FInt16Property.TYPE_NAME && tag.Size == 2) return new FInt16PropertyJson().FromNative(tag);
            else if (tag.Type.Value == FUInt16Property.TYPE_NAME && tag.Size == 2) return new FUInt16PropertyJson().FromNative(tag);
            else if (tag.Type.Value == FUInt32Property.TYPE_NAME && tag.Size == 4) return new FUInt32PropertyJson().FromNative(tag);
            else if (tag.Type.Value == FInt64Property.TYPE_NAME && tag.Size == 8) return new FInt64PropertyJson().FromNative(tag);
            else if (tag.Type.Value == FUInt64Property.TYPE_NAME && tag.Size == 8) return new FUInt64PropertyJson().FromNative(tag);

            //array types
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FObjectProperty.TYPE_NAME) return new FObjectPropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FBoolProperty.TYPE_NAME) return new FBoolPropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FIntProperty.TYPE_NAME) return new FIntPropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FInt64Property.TYPE_NAME) return new FInt64PropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FFloatProperty.TYPE_NAME) return new FFloatPropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FDoubleProperty.TYPE_NAME) return new FDoublePropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FByteProperty.TYPE_NAME && tag.ArrayElementSize == 1) return new FBytePropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FByteProperty.TYPE_NAME && tag.ArrayElementSize == 8) return new FByte64PropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.MaybeInnerTag?.StructName?.Value == FVector3f.StructName) return new Vector3fPropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.MaybeInnerTag?.StructName?.Value == FQuat4f.StructName) return new Quat4fPropertyJsonArray(tag);
            else return tag;
        }
        #endregion

        #region BaseTag
        private static FPropertyTag BaseTag(object item, Transfer transfer)
        {
            KeyValuePair<string, object> pair = (KeyValuePair<string, object>)item;

            if (pair.Key == "None")
            {
                return new FPropertyTag { Name = transfer.GlobalNames.None };
            }

            if (pair.Key.Contains('\''))
            {
                string key = pair.Key;
                var value = pair.Value;
                string type = pair.Key.Split(' ')[0];

                if (NativeConstructors.TryGetValue(type, out var func))
                {
                    return func(transfer, key, value);
                }

                //struct types
                if (type == "struct" || type == "class") return new FStructPropertyJson().GetNative(transfer, key, value);
                else if (type == "guid") return new FGuidPropertyJson().GetNative(transfer, key, value.ToObject<Guid>(transfer));

                //scalar types
                else if (type == "soft") return new SoftObjectPropertyJson().GetNative(transfer, key, value.ToObject<TUInt32>(transfer));
                else if (type == "bool") return new FBoolPropertyJson().GetNative(transfer, key, value.ToObject<bool>(transfer));
                else if (type == "byte") return new FBytePropertyJson().GetNative(transfer, key, value.ToObject<TUInt8>(transfer));
                else if (type == "int8") return new FInt8PropertyJson().GetNative(transfer, key, value.ToObject<TInt8>(transfer));
                else if (type == "byte32") return new FByte32PropertyJson().GetNative(transfer, key, value.ToObject<TUInt32>(transfer));
                else if (type == "byte64") return new FByte64PropertyJson().GetNative(transfer, key, value.ToObject<TUInt64>(transfer));
                else if (type == "enum32") return new FEnum32PropertyJson().GetNative(transfer, key, value.ToObject<TUInt32>(transfer));
                else if (type == "enum64") return new FEnum64PropertyJson().GetNative(transfer, key, value.ToObject<TUInt64>(transfer));
                else if (type == "float") return new FFloatPropertyJson().GetNative(transfer, key, value.ToObject<TFloat>(transfer));
                else if (type == "double") return new FDoublePropertyJson().GetNative(transfer, key, value.ToObject<TDouble>(transfer));
                else if (type == "int") return new FIntPropertyJson().GetNative(transfer, key, value.ToObject<TInt32>(transfer));
                else if (type == "name") return new FNamePropertyJson().GetNative(transfer, key, value.ToString());
                else if (type == "obj") return new FObjectPropertyJson().GetNative(transfer, key, value.ToObject<TInt32>(transfer));
                else if (type == "string") return new FStrPropertyJson().GetNative(transfer, key, value.ToString());
                else if (type == "short") return new FInt16PropertyJson().GetNative(transfer, key, value.ToObject<TInt16>(transfer));
                else if (type == "ushort") return new FUInt16PropertyJson().GetNative(transfer, key, value.ToObject<TUInt16>(transfer));
                else if (type == "uint") return new FUInt32PropertyJson().GetNative(transfer, key, value.ToObject<TUInt32>(transfer));
                else if (type == "long") return new FInt64PropertyJson().GetNative(transfer, key, value.ToObject<TInt64>(transfer));
                else if (type == "ulong") return new FUInt64PropertyJson().GetNative(transfer, key, value.ToObject<TUInt64>(transfer));

                //array types
                else if (type == "obj[]") return new FObjectPropertyJsonArray().GetNative(transfer, key, value.ToString());
                else if (type == "bool[]") return new FBoolPropertyJsonArray().GetNative(transfer, key, value.ToString());
                else if (type == "int[]") return new FIntPropertyJsonArray().GetNative(transfer, key, value.ToString());
                else if (type == "long[]") return new FInt64PropertyJsonArray().GetNative(transfer, key, value.ToString());
                else if (type == "float[]") return new FFloatPropertyJsonArray().GetNative(transfer, key, value.ToString());
                else if (type == "double[]") return new FDoublePropertyJsonArray().GetNative(transfer, key, value.ToString());
                else if (type == "byte[]") return new FBytePropertyJsonArray().GetNative(transfer, key, value.ToString());
                else if (type == "byte64[]") return new FByte64PropertyJsonArray().GetNative(transfer, key, value.ToString());
                else if (type == "vector3f[]") return new Vector3fPropertyJsonArray().GetNative(transfer, key, value.ToString());
                else if (type == "quat4f[]") return new Quat4fPropertyJsonArray().GetNative(transfer, key, value.ToString());
            }
            else if (pair.Value is IPropertytag propertytag)
            {
                return propertytag.ToNative(transfer);
            }
            else if (pair.Value is Dictionary<string, object> dict)
            {
                string key = dict.Keys.First();
                object value = dict.Values.First();
                string type = key.Split(' ')[0];
                if (NativeConstructors.TryGetValue(type, out var func))
                {
                    return func(transfer, key, value);
                }
            }
            return pair.Value.ToObject<FPropertyTag>(transfer);
        }
        #endregion

        #region Tag Value Single
        [Location("void FPropertyTag::SerializeTaggedProperty(FStructuredArchive::FSlot Slot, FProperty* Property, uint8* Value, const uint8* Defaults) const")]
        public static object MoveMember(this Transfer transfer, FPropertyTag tag, int indent, long baseOffset, UObject obj)
        {
            (long startOffset, long endOffset) = (transfer.Position, transfer.Position + tag.Size);
            (string name, string structName, string type, string innerType, string keyType, string valueType, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.KeyType?.Value, tag.ValueType?.Value, tag.Size);
            int inc = Log.InfoRead(tag);

            if (type == default) throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            if (type == FStructProperty.TYPE_NAME)
                tag.Value = MoveMemberStruct(transfer, structName, size, indent + inc, obj, tag);
            else if (type == Consts.ArrayProperty)
                tag.Value = MoveMemberArray(transfer, tag, indent + inc, baseOffset, obj);
            else
                tag.Value = TagMovers[type](transfer, size, tag.Value, name, innerType, keyType, valueType, indent + inc, obj);

            if (transfer.IsReading && startOffset != endOffset && size > 0 && indent == 0)
                new FPropertyTagValue(tag, indent, baseOffset, tag.Value, obj).AutoCheck(transfer, $"Name({tag.Name}) Type({tag.Type}) StructName({tag.StructName}) Size({tag.Size})", transfer.Stream, [startOffset, endOffset]);
            else if (indent == 0 && tag.Size == 0)
                Log.InfoWrite(tag, true);

            return tag.Value;
        }
        #endregion

        [Location("void UScriptStruct::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)")]
        private static object MoveMemberStruct(this Transfer transfer, string structName, int size, int indent, UObject obj, FPropertyTag parentTag)
        {
            if (structName is { } && StructMovers.ContainsKey(structName))
            {
                object result = StructMovers[structName](transfer, size, parentTag.Value, parentTag);
                if (result is { })
                {
                    return result;
                }
                else
                {
                    return transfer.MoveTags(parentTag.Value.ToObject<Dictionary<string, object>>(transfer), indent, obj, parentTag);
                }
            }
            else
            {
                return transfer.MoveTags(parentTag.Value.ToObject<Dictionary<string, object>>(transfer), indent, obj, parentTag);
            }
        }

        #region MoveMemberArray
        [Location("void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        private static object MoveMemberArray(Transfer transfer, FPropertyTag tag, int indent, long baseOffset, UObject obj)
        {
            if (tag.InnerType == null)
                tag.InnerType = new FName(FStructProperty.TYPE_NAME);
            (string structName, string innerType) = (tag.StructName?.Value, tag.InnerType?.Value);

            tag.Value = tag.Value.ToObject<List<object>>(transfer);
            List<object> list = (List<object>)tag.Value;

            transfer.Resize(ref list, true);

            if (list.Count > transfer.AppConfig.MaxArraySize)
                throw new InvalidOperationException($"Array MaxSize Exceeded: {list.Count}");

            if (!transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME && transfer.Supports.VER_UE4_INNER_ARRAY_TAG_INFO && innerType == FStructProperty.TYPE_NAME)
            {
                tag.MaybeInnerTag ??= new();
                tag.MaybeInnerTag.Move(transfer);
                if (tag.MaybeInnerTag.Type.Value == FStructProperty.TYPE_NAME)
                    structName = tag.MaybeInnerTag.StructName.Value;
            }
            else if (innerType != FStructProperty.TYPE_NAME)
            {
                //We cannot estimate the Struct size at the 'Array' level. We can only do this at the 'Element' level
                tag.ArrayElementSize = innerType == FStrProperty.TYPE_NAME ? -1 : (tag.Size - 4) / Math.Max(1, list.Count);
            }

            for (int i = 0; i < list.Count; i++)
            {
                var currentItem = list[i];
                if (obj.ArrayNotifiers.ContainsKey(tag.Name.Value))
                {
                    obj.ArrayNotifiers[tag.Name.Value](transfer);
                }
                if (obj.ArrayMovers.ContainsKey(tag.Name.Value))
                {
                    list[i] = obj.ArrayMovers[tag.Name.Value](transfer, list[i]);
                }
                else if (TransfersForName.ContainsKey(tag.Name.Value))
                {
                    list[i] = TransfersForName[tag.Name.Value](transfer, list[i]);
                }
                else if (structName is { } && StructMovers.ContainsKey(structName))
                {
                    tag.ArrayElementSize = structName == FSoftObjectPath.StructName ? 4 : tag.ArrayElementSize;
                    object value = StructMovers[structName](transfer, tag.ArrayElementSize, list[i], tag);
                    list[i] = value is { } ? value : transfer.MoveTags(list[i].ToObject<Dictionary<string, object>>(transfer), indent, obj);
                }
                else if (innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag is { } && tag.MaybeInnerTag.Type.Value != FStructProperty.TYPE_NAME)
                {
                    list[i] = transfer.MoveTags(list[i].ToObject<Dictionary<string, object>>(transfer), indent, obj);
                }
                else if (innerType == FEnumProperty.TYPE_NAME)
                {
                    list[i] = FEnumProperty.MoveValue(transfer, list[i].ToObject<FName>(transfer));
                }
                else
                {
                    if (tag.InnerType?.Value == Consts.ArrayProperty)
                    {
                        tag.MaybeInnerTag ??= new FPropertyTag
                        {
                            Name = tag.Name,
                            Type = tag.InnerType,
                            Size = tag.ArrayElementSize,
                            StructName = structName is { } ? new FName(structName, transfer) : default,
                        };
                        if (transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME)
                        {
                            tag.MaybeInnerTag.InnerType = tag.TypeName.Nodes[2].Name;
                            tag.MaybeInnerTag.StructName = tag.TypeName.Nodes[3].Name;
                        }
                        else
                        {
                            tag.MaybeInnerTag.InnerType = new FName(FStructProperty.TYPE_NAME);
                        }
                        object value = transfer.MoveMember(tag.MaybeInnerTag, indent, baseOffset, obj);
                        list[i] = value;
                    }
                    else
                    {
                        var elemTag = new FPropertyTag
                        {
                            Name = tag.Name,
                            Type = tag.InnerType,
                            Size = tag.ArrayElementSize,
                            StructName = structName is { } ? new FName(structName, transfer) : default,
                            Value = list[i]
                        };
                        object value = transfer.MoveMember(elemTag, indent, baseOffset, obj);
                        list[i] = value;
                    }
                }
                if (list[i] == null)
                {
                    list[i] = transfer.MoveTags(currentItem.ToObject<Dictionary<string, object>>(transfer), indent, obj);
                }
            }
            transfer.GlobalObjects.CurrentObject.ArrayNames[tag.Name.Value] = list.Count;
            return list;
        }
        #endregion

        #region Check Type
        public static void CheckTagType(Transfer transfer, FName type)
        {
            if (type.Value == transfer.GlobalNames.None.Value)
            {
                throw new InvalidOperationException("Invalid Tag Type");
            }
            else if (int.TryParse(type.Value, out int value))
            {
                throw new InvalidOperationException($"Invalid Tag Type: '{value}'");
            }
        }
        #endregion

        static FPropertyTagExt()
        {
            #region Calling automatically Move function for classes containg the TransferableStruct Attribute
            TransferableStructAttribute.TypesAndAttributes.ToList().ForEach(t =>
            {
                StructMovers.Add(t.Item2.TypeName, (transfer, num, value, parentTag) =>
                {
                    #region default value
                    if ((value == default || value is JsonElement) && typeof(ITransferableSelector).IsAssignableFrom(t.Item1))
                    {
                        value = ((ITransferableSelector)Activator.CreateInstance(t.Item1)).Move(transfer, num, value);
                    }
                    else if (value == default && typeof(ITransferable).IsAssignableFrom(t.Item1))
                    {
                        ITransferable self = (ITransferable)Activator.CreateInstance(t.Item1);
                        value = self.Move(transfer);
                    }
                    #endregion
                    #region object value
                    else if (value is string && typeof(ITransferableSelector).IsAssignableFrom(t.Item1))
                    {
                        value = ((ITransferableSelector)Activator.CreateInstance(t.Item1)).Move(transfer, num, value);
                    }
                    else if (value is string)
                    {
                        value = value.ToObject(t.Item1, transfer);
                    }
                    else if (value is ITransferableSelector TransferableStruct)
                    {
                        value = TransferableStruct.Move(transfer, num, value);
                    }
                    else if (value is ITransferable Transferable)
                    {
                        value = Transferable.Move(transfer);
                    }
                    #endregion
                    #region JsonElement Object value
                    else if (value is JsonElement obj2 && obj2.ValueKind != JsonValueKind.Array && typeof(ITransferable).IsAssignableFrom(t.Item1))
                    {
                        if (typeof(ITransferablePropertyTag).IsAssignableFrom(t.Item1) && Activator.CreateInstance(t.Item1) is ITransferablePropertyTag self2 && self2.IsPropertyTag(transfer))
                        {
                            value = transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer), 0, default, parentTag);
                        }
                        else
                        {
                            value = ((ITransferable)obj2.ToObject(t.Item1, transfer)).Move(transfer);
                        }
                    }
                    #endregion
                    else if (value is FPropertyTag tag)
                    {
                        value = ((ITransferable)tag.Value).Move(transfer);
                    }
                    else
                    {
                        value = transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer), 0, default, parentTag);
                    }
                    return value;
                });
            });

            #endregion

            #region Elegant Json Creation From PropertTag
            TransferableStructAttribute.TypesAndAttributes.ToList().ForEach(t =>
            {
                if (typeof(ITagConverter).IsAssignableFrom(t.Item1))
                {
                    DerivedConstructors.Add(t.Item2.TypeName, (tag) =>
                    {
                        string type = t.Item2.TypeName;
                        string key = new BasePropertyJson().BuildKey(type, tag);
                        object value = tag.Value;
                        return new Dictionary<string, object> { { key, value } };
                    });

                }
            });
            #endregion

            #region Elegant Json Creation From PropertTag (Array)
            DerivedConstructors.Add(new Vector3fPropertyJsonArray().Name, (tag) => new Vector3fPropertyJsonArray(tag));
            DerivedConstructors.Add(new Quat4fPropertyJsonArray().Name, (tag) => new Quat4fPropertyJsonArray(tag));
            #endregion

            #region PropertTag Creation From Elegant Json
            TransferableStructAttribute.TypesAndAttributes.ToList().ForEach(t =>
            {
                if (typeof(ITagConverter).IsAssignableFrom(t.Item1))
                {
                    NativeConstructors.Add(t.Item2.TypeName, (Func<Transfer, string, object, FPropertyTag>)((transfer, key, value) =>
                    {
                        string name, enumName, index, guid, enumInnerType, typeNamespace;
                        BasePropertyJson.ExtractKey(key, out name, out enumName, out index, out guid, out enumInnerType, out typeNamespace);
                        string structName = t.Item2.TypeName;
                        byte hasPropertyGuid = (byte)(guid is { } ? 1 : 0);
                        int arrayIndex = index is { } ? int.Parse(index) : 0;
                        FPropertyTypeName typeName = BasePropertyJson.ExtractTypeName(transfer, FStructProperty.TYPE_NAME, enumName, structName, default, default, name, enumInnerType, typeNamespace);
                        EPropertyTagFlags propertyTagFlags = BasePropertyJson.ExtractPropertyTagFlags(0, hasPropertyGuid, arrayIndex, structName);
                        object tagValue = default;
                        int size = 0;

                        if (value is JsonElement obj && obj.ValueKind == JsonValueKind.Object)
                        {
                            tagValue = obj.Deserialize(t.Item1, JsonSerializerExt.DefaultOptions);
                            size = t.Item2.Size(transfer);
                        }
                        else if (value is JsonElement str && str.ValueKind == JsonValueKind.String)
                        {
                            tagValue = str.Deserialize(t.Item1, JsonSerializerExt.DefaultOptions);
                            size = t.Item2.Size(transfer);
                        }
                        else if (value is ITagConverter tagConverter)
                        {
                            tagValue = tagConverter;
                            if (typeof(IDynamicSize).IsAssignableFrom(t.Item1))
                            {
                                var calculator = ((IDynamicSize)Activator.CreateInstance(t.Item1));
                                size = calculator.TagSize(transfer);
                            }
                            else
                            {
                                size = t.Item2.Size(transfer);
                            }
                        }
                        else if (value is Dictionary<string, object> dict)
                        {
                            foreach (var pair in dict)
                            {
                                string type = pair.Key.Split(' ')[0];
                                object tag = NativeConstructors[type](transfer, pair.Key, pair.Value);
                                dict[pair.Key] = tag;
                                size += ((FPropertyTag)tag).HeaderSize(transfer) + ((FPropertyTag)tag).Size;
                            }
                            tagValue = dict;
                            size += 8;
                        }
                        else
                        {
                            size = ((FPropertyTag)value).Size;
                            tagValue = (FPropertyTag)value;
                        }
                        return new FPropertyTag
                        {
                            Name = new FName(name, transfer),
                            Type = new FName(FStructProperty.TYPE_NAME, transfer),
                            StructName = new FName(structName, transfer),
                            Value = tagValue,
                            Size = size,
                            ArrayIndex = arrayIndex > 0 ? arrayIndex : null,
                            HasPropertyGuid = hasPropertyGuid == 1 ? 1 : null,
                            PropertyGuid = guid is { } ? new FGuid(guid) : default,
                            TypeName = typeName,
                            PropertyTagFlags = propertyTagFlags,
                        };
                    }));
                }
            });
            #endregion

            #region PropertTag Creation From Elegant Json (Array)
            NativeConstructors.Add(new Vector3fPropertyJsonArray().Name, (transfer, key, value) => new Vector3fPropertyJsonArray().GetNative(transfer, key, value.ToString()));
            NativeConstructors.Add(new Quat4fPropertyJsonArray().Name, (transfer, key, value) => new Quat4fPropertyJsonArray().GetNative(transfer, key, value.ToString()));
            #endregion

            RegisterTransfesForNames();

            RegisterTagMovers();
        }

        private static void RegisterTransfesForNames()
        {
            //Handling special cases of Array of StructProperty
            TransfersForName.Add("VoronoiSites", (transfer, value) => value.ToObject<FVector>(transfer).Move(transfer));
            TransfersForName.Add("ReferencedTextureGuids", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
            TransfersForName.Add("IrrelevantLights", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
            TransfersForName.Add("AttributeGetTypes", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
        }

        static void RegisterTagMovers()
        {
            TagMovers.Add(FMapProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FMapProperty>(transfer).MoveValue(transfer, name, keyType, valueType, indent, obj));

            TagMovers.Add(FSetProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FSetProperty>(transfer).MoveValue(transfer, name, valueType, innerType, indent, obj));

            TagMovers.Add(FOptionalProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FOptionalProperty>(transfer).MoveValue(transfer, innerType, size));

            TagMovers.Add(FSoftObjectProperty.OLD_TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FSoftObjectProperty>(transfer).ConvertFromType(transfer));

            TagMovers.Add(FSoftObjectProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) =>
            {
                if (size == 4)
                    return value.ToObject<TUInt32>(transfer).Move(transfer);
                else
                    return value.ToObject<FSoftObjectPath>(transfer).Move(transfer);
            });

            TagMovers.Add(FBoolProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) =>
            {
                if (size == 1)
                    return value.ToObject<TUInt8>(transfer).Move(transfer);
                else
                    return value;
            });

            TagMovers.Add(FByteProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) =>
            {
                if (size == 1)
                    return value.ToObject<TUInt8>(transfer).Move(transfer);
                else if (size == 4)
                    return value.ToObject<TUInt32>(transfer).Move(transfer);
                else if (size == 8)
                    return value.ToObject<TUInt64>(transfer).Move(transfer);
                else
                    return value;
            });

            TagMovers.Add(FDoubleProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<TDouble>(transfer).Move(transfer));

            TagMovers.Add(FEnumProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) =>
            {
                if (size == 4)
                    return value.ToObject<TUInt32>(transfer).Move(transfer);
                else if (size == 8)
                    return value.ToObject<TUInt64>(transfer).Move(transfer);
                else
                    return value;
            });

            TagMovers.Add(FFieldPathProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FFieldPathProperty>(transfer).SerializeItem(transfer));

            TagMovers.Add(FMulticastInlineDelegateProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FMulticastInlineDelegateProperty>(transfer).SerializeItem(transfer));

            TagMovers.Add(FMulticastSparseDelegateProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FMulticastSparseDelegateProperty>(transfer).SerializeItem(transfer));

            TagMovers.Add(FFloatProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<TFloat>(transfer).Move(transfer));

            TagMovers.Add(FInt16Property.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<TInt16>(transfer).Move(transfer));

            TagMovers.Add(FInt64Property.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<TInt64>(transfer).Move(transfer));

            TagMovers.Add(FInt8Property.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<TInt8>(transfer).Move(transfer));

            TagMovers.Add(FInterfaceProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FInterfaceProperty>(transfer).ConvertFromType(transfer));

            TagMovers.Add(FIntProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<TInt32>(transfer).Move(transfer));

            TagMovers.Add(FNameProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FName>(transfer).Move(transfer));

            TagMovers.Add(FObjectProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<TInt32>(transfer).Move(transfer));

            TagMovers.Add(FObjectPropertyBase.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<TInt32>(transfer).Move(transfer));

            TagMovers.Add(FStrProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FString>(transfer).Move(transfer));

            TagMovers.Add(FTextProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FText>(transfer).Move(transfer));

            TagMovers.Add(FUInt16Property.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<TUInt16>(transfer).Move(transfer));

            TagMovers.Add(FUInt32Property.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<TUInt32>(transfer).Move(transfer));

            TagMovers.Add(FUInt64Property.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<TUInt64>(transfer).Move(transfer));

            TagMovers.Add(FLazyObjectProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FGuid>(transfer).Move(transfer));

            TagMovers.Add(FDelegateProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FDelegateProperty>(transfer).MoveValue(transfer));

            TagMovers.Add(FMulticastDelegateProperty.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FMulticastDelegateProperty>(transfer).MoveValue(transfer));

            TagMovers.Add(FGuid.TYPE_NAME, (transfer, size, value, name, innerType, keyType, valueType, indent, obj) => value.ToObject<FGuid>(transfer).Move(transfer));
        }

        public static Dictionary<string, Func<Transfer, object, object>> TransfersForName { get; } = new();
        public static Dictionary<string, Func<Transfer, int, object, string, string, string, string, int, UObject, object>> TagMovers { get; } = new();
    }

    public class FPropertyTagValue : ITransferable
    {
        public FPropertyTag tag;
        public int indent;
        public long baseOffset;
        public object value;
        public UObject obj;
        public FPropertyTagValue() { }
        public FPropertyTagValue(FPropertyTag tag, int indent, long baseOffset, object value, UObject obj)
        {
            this.tag = tag;
            this.indent = indent;
            this.baseOffset = baseOffset;
            this.value = value;
            this.obj = new UObject { ArrayNotifiers = obj.ArrayNotifiers, ArrayMovers = obj.ArrayMovers, MapMovers = obj.MapMovers };
        }
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveMember(tag, indent, baseOffset, obj);
            return this;
        }
    }

    #region Enums
    public enum EPropertyTagExtension : uint8
    {
        NoExtension = 0x00,
        ReserveForFutureUse = 0x01,
        OverridableInformation = 0x02,
    }

    public enum EOverriddenPropertyOperation : uint8
    {
        None = 0,
        Modified,
        Replace,
        Add,
        Remove,
    }

    [Flags]
    public enum EPropertyTagFlags : uint8
    {
        None = 0x00,
        HasArrayIndex = 0x01,
        HasPropertyGuid = 0x02,
        HasPropertyExtensions = 0x04,
        HasBinaryOrNativeSerialize = 0x08,
        BoolTrue = 0x10,
        SkippedSerialize = 0x20,
    }

    public enum EPropertyTagSerializeType : uint8
    {
        Unknown,
        Skipped,
        Property,
        BinaryOrNative,
    }
    #endregion
}

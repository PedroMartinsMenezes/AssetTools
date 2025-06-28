using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("Tag: {Name.Value == \"None\" ? \"None\" : $\"{Name} {Type} {StructName} {InnerType} {ValueType} {Size} ({HeaderOffset} {ValueOffset} {EndOffset})\"}")]
    public class FPropertyTag : ITransferible
    {
        public FName Name;
        public FName Type;
        public Int32 Size;
        public Int32 ArrayIndex;
        public byte HasPropertyGuid;
        public FGuid PropertyGuid;
        public FName StructName;
        public FGuid StructGuid;
        public byte BoolVal;
        public FName EnumName;
        public FName InnerType;
        public FName ValueType;
        public FPropertyTag MaybeInnerTag;
        public object Value;
        public EPropertyTagExtension PropertyTagExtensions;
        public EOverriddenPropertyOperation OverrideOperation;
        public FBool bExperimentalOverridableLogic;
        public FPropertyTypeName TypeName;
        public EPropertyTagFlags PropertyTagFlags;
        public EPropertyTagSerializeType SerializeType;

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
        public string GuidValue => HasPropertyGuid == 0 ? string.Empty : PropertyGuid.ToString();

        [JsonIgnore]
        public string JsonKey => Type?.Value == FStructProperty.TYPE_NAME && StructName is { } ? $"{StructName.Value}" : $"{Type?.Value}";

        [JsonIgnore]
        public int ArrayElementSize;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FPropertyTag& Tag)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME)
                return LoadPropertyTagNoFullType(transfer);

            transfer.Move(ref Name);

            if (Name.Value.StartsWith('/'))
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

            if (Size == 0 && Type?.Value != FBoolProperty.TYPE_NAME)
                throw new InvalidOperationException($"Invalid Size: 0");

            PropertyTagFlags = (EPropertyTagFlags)transfer.Move((byte)PropertyTagFlags);

            BoolVal = PropertyTagFlags.HasFlag(EPropertyTagFlags.BoolTrue) ? (byte)1 : (byte)0;

            HasPropertyGuid = PropertyTagFlags.HasFlag(EPropertyTagFlags.HasPropertyGuid) ? (byte)1 : (byte)0;

            SerializeType = PropertyTagFlags.HasFlag(EPropertyTagFlags.SkippedSerialize)
                ? EPropertyTagSerializeType.Skipped
                : PropertyTagFlags.HasFlag(EPropertyTagFlags.HasBinaryOrNativeSerialize)
                    ? EPropertyTagSerializeType.BinaryOrNative
                    : EPropertyTagSerializeType.Property;

            if (PropertyTagFlags.HasFlag(EPropertyTagFlags.HasArrayIndex))
                transfer.Move(ref ArrayIndex);

            if (PropertyTagFlags.HasFlag(EPropertyTagFlags.HasPropertyGuid))
                transfer.Move(ref PropertyGuid);

            if (PropertyTagFlags.HasFlag(EPropertyTagFlags.HasPropertyExtensions))
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
                TypeNamespace = null;
            }
            return this;
        }

        private FPropertyTag LoadPropertyTagNoFullType(Transfer transfer)
        {
            transfer.Move(ref Name);
            if (Name.Value.StartsWith('/'))
                throw new InvalidOperationException($"Invalid Name: {Name.Value}");
            if (!Name.IsFilled())
                return this;

            transfer.Move(ref Type);

            FPropertyTagExt.CheckTagType(transfer, Type);

            transfer.Move(ref Size);
            transfer.Move(ref ArrayIndex);

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
                else if (Type.Value == Consts.SetProperty && transfer.Supports.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT)
                    transfer.Move(ref InnerType);
                else if (Type.Value == Consts.MapProperty && transfer.Supports.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT)
                {
                    transfer.Move(ref InnerType);
                    transfer.Move(ref ValueType);
                }
            }
            if (transfer.Supports.VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG)
            {
                transfer.Move(ref HasPropertyGuid);
                if (HasPropertyGuid is not (0 or 1))
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
            PropertyTagExtensions = (EPropertyTagExtension)transfer.Move((byte)PropertyTagExtensions);

            if (PropertyTagExtensions.HasFlag(EPropertyTagExtension.OverridableInformation))
            {
                OverrideOperation = (EOverriddenPropertyOperation)transfer.Move((byte)OverrideOperation);

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

        public static int StructHeaderSize(Transfer transfer)
        {
            return transfer.Supports.VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG ? 49 : 48;
        }

        public static int ArrayHeaderSize(Transfer transfer)
        {
            return transfer.Supports.VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG ? 49 : 48;
        }
    }

    public static class FPropertyTagExt
    {
        public static Dictionary<string, Func<Transfer, int, object, FPropertyTag, object>> StructMovers { get; } = new();
        public static Dictionary<string, Func<FPropertyTag, object>> DerivedConstructors { get; } = new();
        public static Dictionary<string, Func<Transfer, string, object, FPropertyTag>> NativeConstructors { get; } = new();

        #region List of Tags
        [Location("void UStruct::SerializeVersionedTaggedProperties")]
        public static Dictionary<string, object> MoveTags(this Transfer transfer, Dictionary<string, object> members, int indent = 0, UObject obj = null, FPropertyTag ParentTag = null)
        {
            obj ??= new();

            if (obj.bIsUClass && transfer.Supports.PROPERTY_TAG_EXTENSION_AND_OVERRIDABLE_SERIALIZATION)
            {
                obj.bIsUClass = false;
                obj.SerializationControl = (EClassSerializationControlExtension)transfer.Move((uint8)obj.SerializationControl);
            }
            if (transfer.IsWriting && members.Count == 0)
            {
                transfer.writer.Write(transfer.GlobalNames.None);
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
                    if (transfer.IsReading)
                    {
                        tag.Value = transfer.ReadMember(tag, indent, baseOffset, obj);
                        DebugSaveMemberAfterRead(transfer, tag, tag.HeaderOffset, indent);
                    }
                    else
                    {
                        DebugSaveMemberBeforeWrite(transfer, tag, tag.HeaderOffset, indent);
                        transfer.WriterMember(tag, indent, baseOffset, tag.Value, obj);
                    }
                    transfer.Counter++;
                    if (transfer.Position != endOffset)
                    {
                        Log.Error($"{(transfer.IsReading ? "Read" : "Write")} Failed. Expected Offset {endOffset} but was {transfer.Position}. Break at tag.HeaderOffset == {tag.HeaderOffset}");
                        throw new InvalidOperationException();
                    }
                }
                if (transfer.IsReading)
                {
                    if (tag.Name.IsFilled())
                    {
                        var item = tag.Name.IsFilled() && indent >= 0 ? DerivedTag(tag) : tag;
                        if (item is Dictionary<string, object> dict)
                        {
                            string suffix = members.ContainsKey(dict.Keys.First()) ? $".{tag.ValueOffset.ToString()}" : string.Empty;
                            members[$"{dict.Keys.First()}{suffix}"] = dict.Values.First();
                        }
                        else if (item is FPropertyTag member2)
                        {
                            string suffix = members.ContainsKey(member2.Name.ToString()) ? $".{tag.ValueOffset.ToString()}" : string.Empty;
                            members[$"{member2.Name.ToString()}{suffix}"] = member2;
                        }
                    }
                }
                else if (i == members.Count - 1)
                {
                    transfer.writer.Write(transfer.GlobalNames.None);
                    break;
                }
                quit = !tag.Name.IsFilled();
                transfer.Counter = quit ? 0 : transfer.Counter;
                i++;
            }
            return members;
        }
        #endregion

        #region DebugSaveMember
        private static void DebugSaveMemberAfterRead(Transfer transfer, FPropertyTag tag, long offset, int indent)
        {
            if (AppConfig.DebugSaveMember && indent == 0)
            {
                string name = $"{tag.Name.Value}.{tag.Type.Value}.{tag.StructName?.Value ?? "_"}";
                string path = $"C:/Temp/Debug/Reader/{offset}-{transfer.GlobalObjects.CurrentObject.Index}-{transfer.GlobalObjects.CurrentObject.Type}-{name}.json";
                tag.Value.SaveToJson(path, transfer);
            }
        }

        private static void DebugSaveMemberBeforeWrite(Transfer transfer, FPropertyTag tag, long offset, int indent)
        {
            if (!AppConfig.DebugCheckMember && AppConfig.DebugSaveMember && indent == 0)
            {
                string name = $"{tag.Name.Value}.{tag.Type.Value}.{tag.StructName?.Value ?? "_"}";
                string fileName = $"{offset}-{transfer.GlobalObjects.CurrentObject.Index}-{transfer.GlobalObjects.CurrentObject.Type}-{name}";
                if (!transfer.FromJson)
                {
                    tag.Value.SaveToJson($"C:/Temp/Debug/Writer/{fileName}.json", transfer);
                    if (!DataComparer.CompareFiles($"C:/Temp/Debug/Reader/{fileName}.json", $"C:/Temp/Debug/Writer/{fileName}.json"))
                        throw new InvalidOperationException($"Writer/Reader Mismatch: {fileName}");
                }
                else
                {
                    tag.Value.SaveToJson($"C:/Temp/Debug/Writer2/{fileName}.json", transfer);
                    if (!DataComparer.CompareFiles($"C:/Temp/Debug/Reader/{fileName}.json", $"C:/Temp/Debug/Writer2/{fileName}.json"))
                        throw new InvalidOperationException($"Writer/Reader Mismatch: {fileName}");
                }
            }
        }
        #endregion

        #region DerivedTag
        private static object DerivedTag(FPropertyTag tag)
        {
            if (tag is { } && DerivedConstructors.TryGetValue(tag.JsonKey, out var func))
            {
                return func(tag);
            }

            if (tag is null || tag.Type is null) return tag;
            else if (tag.Type.Value == FBoolProperty.TYPE_NAME) return new FBoolPropertyJson().SetNative(tag);
            else if (tag.Type.Value == Consts.SoftObjectProperty && tag.Size == 4) return new SoftObjectPropertyJson().SetNative(tag);
            else if (tag.Type.Value == FByteProperty.TYPE_NAME && tag.Size == 1) return new FBytePropertyJson().SetNative(tag);
            else if (tag.Type.Value == FByteProperty.TYPE_NAME && tag.Size == 4) return new FByte32PropertyJson().SetNative(tag);
            else if (tag.Type.Value == FByteProperty.TYPE_NAME && tag.Size == 8) return new FByte64PropertyJson().SetNative(tag);
            else if (tag.Type.Value == FDoubleProperty.TYPE_NAME) return new FDoublePropertyJson().SetNative(tag);
            else if (tag.Type.Value == FEnumProperty.TYPE_NAME && tag.Size == 4) return new FEnum32PropertyJson().SetNative(tag);
            else if (tag.Type.Value == FEnumProperty.TYPE_NAME && tag.Size == 8) return new FEnum64PropertyJson().SetNative(tag);
            else if (tag.Type.Value == FFloatProperty.TYPE_NAME) return new FFloatPropertyJson().SetNative(tag);
            else if (tag.Type.Value == FIntProperty.TYPE_NAME) return new FIntPropertyJson().SetNative(tag);
            else if (tag.Type.Value == FNameProperty.TYPE_NAME) return new FNamePropertyJson().SetNative(tag);
            else if (tag.Type.Value == FObjectProperty.TYPE_NAME) return new FObjectPropertyJson().SetNative(tag);
            else if (tag.Type.Value == FStrProperty.TYPE_NAME) return new FStrPropertyJson().SetNative(tag);
            else if (tag.Type.Value == FInt16Property.TYPE_NAME && tag.Size == 2) return new FInt16PropertyJson().SetNative(tag);
            else if (tag.Type.Value == FUInt16Property.TYPE_NAME && tag.Size == 2) return new FUInt16PropertyJson().SetNative(tag);
            else if (tag.Type.Value == FUInt32Property.TYPE_NAME && tag.Size == 4) return new FUInt32PropertyJson().SetNative(tag);
            else if (tag.Type.Value == FUInt64Property.TYPE_NAME && tag.Size == 8) return new FUInt64PropertyJson().SetNative(tag);
            else if (tag.Type.Value == FStructProperty.TYPE_NAME && tag.StructName?.Value == Consts.Guid) return new FGuidPropertyJson().SetNative(tag);
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

                if (type == "soft") return new SoftObjectPropertyJson().GetNative(transfer, key, value.ToObject<UInt32>(transfer));
                else if (type == "bool") return new FBoolPropertyJson().GetNative(transfer, key, value.ToObject<bool>(transfer));
                else if (type == "byte") return new FBytePropertyJson().GetNative(transfer, key, value.ToObject<byte>(transfer));
                else if (type == "byte32") return new FByte32PropertyJson().GetNative(transfer, key, value.ToObject<UInt32>(transfer));
                else if (type == "byte64") return new FByte64PropertyJson().GetNative(transfer, key, value.ToObject<UInt64>(transfer));
                else if (type == "enum32") return new FEnum32PropertyJson().GetNative(transfer, key, value.ToObject<UInt32>(transfer));
                else if (type == "enum64") return new FEnum64PropertyJson().GetNative(transfer, key, value.ToObject<UInt64>(transfer));
                else if (type == "float") return new FFloatPropertyJson().GetNative(transfer, key, value.ToObject<float>(transfer));
                else if (type == "double") return new FDoublePropertyJson().GetNative(transfer, key, value.ToObject<double>(transfer));
                else if (type == "int") return new FIntPropertyJson().GetNative(transfer, key, value.ToObject<Int32>(transfer));
                else if (type == "name") return new FNamePropertyJson().GetNative(transfer, key, value.ToString());
                else if (type == "obj") return new FObjectPropertyJson().GetNative(transfer, key, value.ToObject<UInt32>(transfer));
                else if (type == "string") return new FStrPropertyJson().GetNative(transfer, key, value.ToString());
                else if (type == "short") return new FInt16PropertyJson().GetNative(transfer, key, value.ToObject<Int16>(transfer));
                else if (type == "ushort") return new FUInt16PropertyJson().GetNative(transfer, key, value.ToObject<UInt16>(transfer));
                else if (type == "uint") return new FUInt32PropertyJson().GetNative(transfer, key, value.ToObject<UInt32>(transfer));
                else if (type == "ulong") return new FUInt64PropertyJson().GetNative(transfer, key, value.ToObject<UInt64>(transfer));
                else if (type == "guid") return new FGuidPropertyJson().GetNative(transfer, key, value.ToObject<Guid>(transfer));
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
                return propertytag.GetNative(transfer);
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
        public static object ReadMember(this Transfer transfer, FPropertyTag tag, int indent, long baseOffset, UObject obj)
        {
            var reader = transfer.reader;

            (long startOffset, long endOffset) = (reader.BaseStream.Position, reader.BaseStream.Position + tag.Size);
            (string name, string structName, string type, string innerType, string valueType, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.ValueType?.Value, tag.Size);
            int inc = Log.InfoRead(transfer.reader.BaseStream.Position, indent, tag);

            if (type is null) throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            else if (type == FStructProperty.TYPE_NAME) tag.Value = ReadMemberStruct(transfer, structName, size, indent + inc, obj, tag);
            else if (type == Consts.ArrayProperty) tag.Value = ReadMemberArray(transfer, tag, indent + inc, baseOffset, obj);
            else if (type == FMapProperty.TYPE_NAME) tag.Value = new FMapProperty().MoveValue(transfer, name, valueType, innerType, indent + inc);
            else if (type == FSetProperty.TYPE_NAME) tag.Value = new FSetProperty().MoveValue(transfer, name, valueType, innerType, indent + inc);

            else if (type == FSoftObjectProperty.OLD_TYPE_NAME) tag.Value = tag.Value.ToObject<FSoftObjectProperty>(transfer).ConvertFromType(transfer);
            else if (type == Consts.SoftObjectProperty && size == 4) tag.Value = reader.ReadUInt32();
            else if (type == Consts.SoftObjectProperty) tag.Value = tag.Value.ToObject<FSoftObjectPath>(transfer).Move(transfer);

            else if (type == FBoolProperty.TYPE_NAME && size == 0) tag.Value = null;
            else if (type == FBoolProperty.TYPE_NAME && size == 1) tag.Value = tag.Value = reader.ReadByte();
            else if (type == FByteProperty.TYPE_NAME && size == 1) tag.Value = reader.ReadByte();
            else if (type == FByteProperty.TYPE_NAME && size == 4) tag.Value = reader.ReadUInt32();
            else if (type == FByteProperty.TYPE_NAME && size == 8) tag.Value = reader.ReadUInt64();
            else if (type == FDoubleProperty.TYPE_NAME) tag.Value = reader.ReadDouble();
            else if (type == FEnumProperty.TYPE_NAME && size == 4) tag.Value = reader.ReadUInt32();
            else if (type == FEnumProperty.TYPE_NAME && size == 8) tag.Value = reader.ReadUInt64();
            else if (type == FFieldPathProperty.TYPE_NAME) tag.Value = tag.Value.ToObject<FFieldPathProperty>(transfer).SerializeItem(transfer);
            else if (type == FMulticastInlineDelegateProperty.TYPE_NAME) tag.Value = tag.Value.ToObject<FMulticastInlineDelegateProperty>(transfer).SerializeItem(transfer);
            else if (type == FFloatProperty.TYPE_NAME) tag.Value = reader.ReadSingle();
            else if (type == FInt16Property.TYPE_NAME) tag.Value = reader.ReadInt16();
            else if (type == FInt64Property.TYPE_NAME) tag.Value = reader.ReadInt64();
            else if (type == FInt8Property.TYPE_NAME) tag.Value = reader.ReadSByte();
            else if (type == FInterfaceProperty.TYPE_NAME) tag.Value = tag.Value.ToObject<FInterfaceProperty>(transfer).ConvertFromType(transfer);
            else if (type == FIntProperty.TYPE_NAME) tag.Value = reader.ReadInt32();
            else if (type == FNameProperty.TYPE_NAME) tag.Value = transfer.ReadFName();
            else if (type == FObjectProperty.TYPE_NAME) tag.Value = reader.ReadUInt32();
            else if (type == FObjectPropertyBase.TYPE_NAME) tag.Value = reader.ReadUInt32();
            else if (type == FStrProperty.TYPE_NAME) tag.Value = transfer.ReadFString();
            else if (type == FTextProperty.TYPE_NAME) tag.Value = tag.Value.ToObject<FText>(transfer).Move(transfer);
            else if (type == FUInt16Property.TYPE_NAME) tag.Value = reader.ReadUInt16();
            else if (type == FUInt32Property.TYPE_NAME) tag.Value = reader.ReadUInt32();
            else if (type == FUInt64Property.TYPE_NAME) tag.Value = reader.ReadUInt64();
            else if (type == FLazyObjectProperty.TYPE_NAME) tag.Value = reader.ReadFGuid();
            else if (type == FGuid.TYPE_NAME) tag.Value = reader.ReadFGuid();
            else throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            if (startOffset != endOffset && size > 0 && indent == 0)
                tag.AutoCheck(transfer, $"Name({tag.Name}) Type({tag.Type}) StructName({tag.StructName}) Size({tag.Size})", reader.BaseStream, [startOffset, endOffset], (transferWriter, copy, v) => transferWriter.WriterMember(copy, indent, baseOffset, v, obj));
            else if (indent == 0 && tag.Size == 0)
                Log.InfoWrite(reader.BaseStream.Position, indent, tag, true);

            return tag.Value;
        }

        public static void WriterMember(this Transfer transfer, FPropertyTag tag, int indent, long baseOffset, object value, UObject obj)
        {
            var writer = transfer.writer;
            (string name, string structName, string type, string innerType, string valueType, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.ValueType?.Value, tag.Size);
            int inc = Log.InfoWrite(writer.BaseStream.Position, indent, tag, false);

            if (type is null) throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            else if (type == FStructProperty.TYPE_NAME) WriteMemberStruct(transfer, structName, value, size, indent + inc, obj, tag);
            else if (type == Consts.ArrayProperty) WriteMemberArray(transfer, tag, value, indent + inc, baseOffset, obj);
            else if (type == FMapProperty.TYPE_NAME) value.ToObject<FMapProperty>(transfer).MoveValue(transfer, name, valueType, innerType, indent + inc);
            else if (type == FSetProperty.TYPE_NAME) value.ToObject<FSetProperty>(transfer).MoveValue(transfer, name, valueType, innerType, indent + inc);

            else if (type == FSoftObjectProperty.OLD_TYPE_NAME) value.ToObject<FSoftObjectProperty>(transfer).ConvertFromType(transfer);
            else if (type == Consts.SoftObjectProperty && size == 4) writer.Write(value.ToObject<UInt32>(transfer));
            else if (type == Consts.SoftObjectProperty) value.ToObject<FSoftObjectPath>(transfer).Move(transfer);

            else if (type == FBoolProperty.TYPE_NAME && size == 0) return;
            else if (type == FBoolProperty.TYPE_NAME && size == 1) writer.Write(value.ToObject<byte>(transfer));
            else if (type == FByteProperty.TYPE_NAME && size == 1) writer.Write(value.ToObject<byte>(transfer));
            else if (type == FByteProperty.TYPE_NAME && size == 4) writer.Write(value.ToObject<UInt32>(transfer));
            else if (type == FByteProperty.TYPE_NAME && size == 8) writer.Write(value.ToObject<UInt64>(transfer));
            else if (type == FDoubleProperty.TYPE_NAME) writer.Write(value.ToObject<double>(transfer));
            else if (type == FEnumProperty.TYPE_NAME && size == 4) writer.Write(value.ToObject<UInt32>(transfer));
            else if (type == FEnumProperty.TYPE_NAME && size == 8) writer.Write(value.ToObject<UInt64>(transfer));
            else if (type == FFieldPathProperty.TYPE_NAME) value.ToObject<FFieldPathProperty>(transfer).SerializeItem(transfer);
            else if (type == FMulticastInlineDelegateProperty.TYPE_NAME) value.ToObject<FMulticastInlineDelegateProperty>(transfer).SerializeItem(transfer);
            else if (type == FFloatProperty.TYPE_NAME) writer.Write(value.ToObject<float>(transfer));
            else if (type == FInt16Property.TYPE_NAME) writer.Write(value.ToObject<Int16>(transfer));
            else if (type == FInt64Property.TYPE_NAME) writer.Write(value.ToObject<Int64>(transfer));
            else if (type == FInt8Property.TYPE_NAME) writer.Write(value.ToObject<sbyte>(transfer));
            else if (type == FInterfaceProperty.TYPE_NAME) tag.Value.ToObject<FInterfaceProperty>(transfer).ConvertFromType(transfer);
            else if (type == FIntProperty.TYPE_NAME) writer.Write(value.ToObject<Int32>(transfer));
            else if (type == FNameProperty.TYPE_NAME) writer.Write(value.ToObject<FName>(transfer));
            else if (type == FObjectProperty.TYPE_NAME) writer.Write(value.ToObject<UInt32>(transfer));
            else if (type == FObjectPropertyBase.TYPE_NAME) writer.Write(value.ToObject<UInt32>(transfer));
            else if (type == FStrProperty.TYPE_NAME) transfer.Write(value.ToObject<FString>(transfer));
            else if (type == FTextProperty.TYPE_NAME) value.ToObject<FText>(transfer).Move(transfer);
            else if (type == FUInt16Property.TYPE_NAME) writer.Write(value.ToObject<UInt16>(transfer));
            else if (type == FUInt32Property.TYPE_NAME) writer.Write(value.ToObject<UInt32>(transfer));
            else if (type == FUInt64Property.TYPE_NAME) writer.Write(value.ToObject<UInt64>(transfer));
            else if (type == FLazyObjectProperty.TYPE_NAME) writer.Write(value.ToObject<FGuid>(transfer));
            else if (type == FGuid.TYPE_NAME) writer.Write(value.ToObject<FGuid>(transfer));
            else throw new InvalidOperationException($"Invalid Tag Type: '{type}'");
        }
        #endregion

        #region Tag Value Struct
        [Location("void UScriptStruct::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)")]
        private static object ReadMemberStruct(this Transfer transfer, string structName, int size, int indent, UObject obj, FPropertyTag parentTag)
        {
            if (structName is { } && !StructMovers.ContainsKey(structName))
                Log.LogUnknownStruct(structName);

            transfer.GlobalObjects.LogStructName = structName;
            if (structName is { } && StructMovers.ContainsKey(structName))
            {
                object result = StructMovers[structName](transfer, size, null, parentTag);
                if (result is { })
                {
                    return result;
                }
                else
                {
                    return transfer.MoveTags([], indent, obj, parentTag);
                }
            }
            else
            {
                return transfer.MoveTags([], indent, obj, parentTag);
            }
        }
        private static void WriteMemberStruct(this Transfer transfer, string structName, object value, int size, int indent, UObject obj, FPropertyTag parentTag)
        {
            if (structName is { } && StructMovers.ContainsKey(structName))
            {
                object result = StructMovers[structName](transfer, size, value, parentTag);
                if (result is null)
                {
                    transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer), indent, obj);
                }
            }
            else
            {
                transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer), indent, obj);
            }
        }
        #endregion

        #region Tag Value Array
        [Location("void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        private static object ReadMemberArray(Transfer transfer, FPropertyTag tag, int indent, long baseOffset, UObject obj)
        {
            (string structName, string innerType) = (tag.StructName?.Value, tag.InnerType?.Value);
            int count = transfer.reader.ReadInt32();
            if (count > AppConfig.MaxArraySize)
                throw new InvalidOperationException($"Array MaxSize Exceeded: {count}");
            List<object> list = Enumerable.Range(0, count).Select(x => (object)null).ToList();

            if (!transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME && transfer.Supports.VER_UE4_INNER_ARRAY_TAG_INFO && innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag is null)
            {
                tag.MaybeInnerTag ??= new();
                tag.MaybeInnerTag.Move(transfer);
                if (tag.MaybeInnerTag.Type.Value == FStructProperty.TYPE_NAME)
                    structName = tag.MaybeInnerTag.StructName.Value;
                tag.ArrayElementSize = tag.MaybeInnerTag.Size / Math.Max(1, count);
            }
            else
            {
                tag.ArrayElementSize = innerType == FStrProperty.TYPE_NAME ? -1 : (tag.Size - 4) / Math.Max(1, count);
            }

            for (int i = 0; i < count; i++)
            {
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
                    object value = StructMovers[structName](transfer, tag.ArrayElementSize, list[i], tag);
                    list[i] = value is { } ? value : transfer.MoveTags([], indent, obj);
                }
                else if (innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag?.Type?.Value != FStructProperty.TYPE_NAME)
                {
                    list[i] = transfer.MoveTags([], indent, obj);
                }
                else
                {
                    var elemTag = new FPropertyTag { Name = tag.Name, Type = tag.InnerType, Size = tag.ArrayElementSize, StructName = structName is { } ? new FName(structName, transfer) : null };
                    if (transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME && tag.InnerType.Value == Consts.ArrayProperty)
                    {
                        elemTag.Name = tag.Name;
                        elemTag.InnerType = tag.TypeName.Nodes[2].Name;
                        elemTag.StructName = tag.TypeName.Nodes[3].Name;
                    }
                    object value = transfer.ReadMember(elemTag, indent, baseOffset, obj);
                    list[i] = value;
                }
            }
            if (count != list.Count)
                throw new InvalidOperationException("Empty array");
            transfer.GlobalObjects.CurrentObject.ArrayNames[tag.Name.Value] = count;
            return list;
        }
        private static void WriteMemberArray(Transfer transfer, FPropertyTag tag, object array, int indent, long baseOffset, UObject obj)
        {
            (string structName, string innerType) = (tag.StructName?.Value, tag.InnerType?.Value);
            var list = array.ToObject<List<object>>(transfer);
            transfer.writer.Write(list.Count);

            if (!transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME && transfer.Supports.VER_UE4_INNER_ARRAY_TAG_INFO && innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag is { })
            {
                tag.MaybeInnerTag.Move(transfer);
                if (tag.MaybeInnerTag.Type.Value == FStructProperty.TYPE_NAME)
                    structName = tag.MaybeInnerTag.StructName.Value;
                tag.ArrayElementSize = tag.MaybeInnerTag.Size / Math.Max(1, list.Count);
            }
            else
            {
                tag.ArrayElementSize = innerType == FStrProperty.TYPE_NAME ? -1 : (tag.Size - 4) / Math.Max(1, list.Count);
            }

            for (int i = 0; i < list.Count; i++)
            {
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
                    object value = StructMovers[structName](transfer, tag.ArrayElementSize, list[i], tag);
                    list[i] = value is { } ? value : transfer.MoveTags(list[i].ToObject<Dictionary<string, object>>(transfer), indent, obj);
                }
                else if (innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag?.Type?.Value != FStructProperty.TYPE_NAME)
                {
                    transfer.MoveTags(list[i].ToObject<Dictionary<string, object>>(transfer), indent, obj);
                }
                else
                {
                    var elemTag = new FPropertyTag { Name = tag.Name, Type = tag.InnerType, Size = tag.ArrayElementSize, StructName = structName is { } ? new FName(structName, transfer) : null };
                    if (transfer.Supports.PROPERTY_TAG_COMPLETE_TYPE_NAME && tag.InnerType.Value == Consts.ArrayProperty)
                    {
                        elemTag.InnerType = tag.TypeName.Nodes[2].Name;
                        elemTag.StructName = tag.TypeName.Nodes[3].Name;
                    }
                    transfer.WriterMember(elemTag, indent, baseOffset, list[i], obj);
                }
            }
        }
        #endregion

        #region Check Type
        public static void CheckTagType(Transfer transfer, FName type)
        {
            if (type.Value == transfer.GlobalNames.None.Value)
            {
                Log.Error($"StructName Not Found:\n\t{transfer.GlobalObjects.LogStructName}");
                Log.Error($"Look for:\n\tTStructOpsTypeTraits<F{transfer.GlobalObjects.LogStructName}>");
                Log.Error($"Look for:\n\tF{transfer.GlobalObjects.LogStructName}::Serialize");
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
            #region Calling automatically Move function for classes containg the TransferibleStruct Attribute
            TransferibleStructAttribute.TypesAndAttributes.ToList().ForEach(t =>
            {
                StructMovers.Add(t.Item2.TypeName, (transfer, num, value, parentTag) =>
                {
                    #region null value
                    if ((value is null || value is JsonElement) && typeof(ITransferibleSelector).IsAssignableFrom(t.Item1))
                    {
                        ITransferibleSelector self = (ITransferibleSelector)Activator.CreateInstance(t.Item1);
                        value = self.Move(transfer, num, value);
                    }
                    else if (value is null && typeof(ITransferible).IsAssignableFrom(t.Item1))
                    {
                        ITransferible self = (ITransferible)Activator.CreateInstance(t.Item1);
                        value = self.Move(transfer);
                    }
                    #endregion
                    #region object value
                    else if (value is string && typeof(ITransferibleSelector).IsAssignableFrom(t.Item1))
                    {
                        ITransferibleSelector self = (ITransferibleSelector)Activator.CreateInstance(t.Item1);
                        value = self.Move(transfer, num, value);
                    }
                    else if (value is string)
                    {
                        value = value.ToObject<object>(t.Item1, transfer);
                    }
                    else if (value is ITransferibleSelector transferibleStruct)
                    {
                        value = transferibleStruct.Move(transfer, num, value);
                    }
                    else if (value is ITransferible transferible)
                    {
                        value = transferible.Move(transfer);
                    }
                    #endregion
                    #region JsonElement Object value
                    else if (value is JsonElement obj2 && obj2.ValueKind != JsonValueKind.Array && typeof(ITransferible).IsAssignableFrom(t.Item1))
                    {
                        ITransferible self = obj2.ToObject<ITransferible>(t.Item1, transfer);
                        value = self.Move(transfer);
                    }
                    #endregion
                    else if (value is FPropertyTag tag)
                    {
                        ITransferible self = (ITransferible)tag.Value;
                        value = self.Move(transfer);
                    }
                    else
                    {
                        return transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer), 0, null, parentTag);
                    }
                    return value;
                });
            });

            #endregion

            #region Elegant Json Creation From PropertTag
            TransferibleStructAttribute.TypesAndAttributes.ToList().ForEach(t =>
            {
                if (typeof(ITagConverter).IsAssignableFrom(t.Item1))
                {
                    DerivedConstructors.Add(t.Item2.TypeName, (tag) =>
                    {
                        string type = t.Item2.TypeName;
                        string key = BasePropertyJson.BuildKey(type, tag);
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
            TransferibleStructAttribute.TypesAndAttributes.ToList().ForEach(t =>
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
                        FPropertyTypeName typeName = BasePropertyJson.ExtractTypeName(transfer, FStructProperty.TYPE_NAME, enumName, structName, null, null, name, enumInnerType, typeNamespace);
                        EPropertyTagFlags propertyTagFlags = BasePropertyJson.ExtractPropertyTagFlags(0, hasPropertyGuid, arrayIndex, structName);
                        EPropertyTagSerializeType serializeType = BasePropertyJson.ExtractSerializeType(propertyTagFlags);
                        object tagValue = null;
                        int size = 0;

                        #region Remove this
                        if (value is JsonElement objs && objs.ValueKind == JsonValueKind.Object && objs.EnumerateObject().Count() > 1 && typeof(ITagConverter).IsAssignableFrom(t.Item1))
                        {
                            var dict = objs.ToObject<Dictionary<string, object>>(transfer);
                            Dictionary<string, object> tags = [];
                            foreach (var pair in dict)
                            {
                                string type = pair.Key.Split(' ')[0];
                                object tag = NativeConstructors[type](transfer, pair.Key, pair.Value);
                                tags.Add(pair.Key, tag);
                                size += ((FPropertyTag)tag).HeaderSize(transfer) + ((FPropertyTag)tag).Size;
                            }
                            size += 8;
                            tagValue = tags;
                        }
                        #endregion
                        #region Remove this
                        else if (value is JsonElement obj && obj.ValueKind == JsonValueKind.Object && typeof(ITagConverter).IsAssignableFrom(t.Item1))
                        {
                            var dict = obj.ToObject<Dictionary<string, object>>(transfer);
                            List<object> tags = [];
                            foreach (var pair in dict)
                            {
                                string type = pair.Key.Split(' ')[0];
                                object tag = NativeConstructors[type](transfer, pair.Key, pair.Value);
                                tags.Add(tag);
                                size += ((FPropertyTag)tag).HeaderSize(transfer) + ((FPropertyTag)tag).Size;
                            }
                            size += 8;
                            tagValue = tags;
                        }
                        #endregion
                        else if (value is JsonElement str && str.ValueKind == JsonValueKind.String)
                        {
                            tagValue = $"\"{value.ToString()}\"".ToObject<object>(t.Item1, transfer);
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
                            ArrayIndex = arrayIndex,
                            HasPropertyGuid = hasPropertyGuid,
                            PropertyGuid = guid is { } ? new FGuid(guid) : default,
                            TypeName = typeName,
                            PropertyTagFlags = propertyTagFlags,
                            SerializeType = serializeType,
                        };
                    }));
                }
            });
            #endregion

            #region PropertTag Creation From Elegant Json (Array)
            NativeConstructors.Add(new Vector3fPropertyJsonArray().Name, (transfer, key, value) => new Vector3fPropertyJsonArray().GetNative(transfer, key, value.ToString()));
            NativeConstructors.Add(new Quat4fPropertyJsonArray().Name, (transfer, key, value) => new Quat4fPropertyJsonArray().GetNative(transfer, key, value.ToString()));
            #endregion

            #region Handling special cases of Array of StructProperty
            TransfersForName.Add("VoronoiSites", (transfer, value) => value.ToObject<FVector>(transfer).Move(transfer));
            TransfersForName.Add("ReferencedTextureGuids", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
            TransfersForName.Add("IrrelevantLights", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
            TransfersForName.Add("AttributeGetTypes", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
            #endregion
        }

        public static Dictionary<string, Func<Transfer, object, object>> TransfersForName { get; } = new();
    }

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
}

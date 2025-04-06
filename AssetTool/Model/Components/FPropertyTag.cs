using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("{Name.Value == \"None\" ? \"None\" : $\"{Name} {Type} {StructName} {InnerType} {ValueType} {Size}\"}")]
    public class FPropertyTag
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

        [JsonIgnore]
        public string GuidValue => HasPropertyGuid == 0 ? string.Empty : PropertyGuid.ToString();

        [JsonIgnore]
        public string JsonKey => Type?.Value == FStructProperty.TYPE_NAME && StructName is { } ? $"{StructName.Value}" : $"{Type?.Value}";

        [JsonIgnore]
        public int ArrayElementSize;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FPropertyTag& Tag)")]
        public FPropertyTag Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            if (Name.Value.StartsWith('/'))
                throw new InvalidOperationException($"Invalid Name: {Name.Value}");
            if (Name.IsFilled)
            {
                transfer.Move(ref Type);
                CheckTagType(transfer);

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
            }
            return this;
        }

        private void CheckTagType(Transfer transfer)
        {
            if (Type.Value == transfer.GlobalNames.None.Value)
            {
                Log.Error($"StructName Not Found:\n\t{transfer.GlobalObjects.LogStructName}");
                Log.Error($"Look for:\n\tTStructOpsTypeTraits<F{transfer.GlobalObjects.LogStructName}>");
                Log.Error($"Look for:\n\tF{transfer.GlobalObjects.LogStructName}::Serialize");
                throw new InvalidOperationException("Invalid Tag Type");
            }
            else if (int.TryParse(Type.Value, out int value))
            {
                throw new InvalidOperationException($"Invalid Tag Type: '{value}'");
            }
        }

        public static int HeaderSize(Transfer transfer)
        {
            return transfer.Supports.VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG ? 49 : 48;
        }
    }

    public static class FPropertyTagExt
    {
        public static Dictionary<string, Func<Transfer, int, object, object>> StructMovers { get; } = new();
        public static Dictionary<string, Func<FPropertyTag, object>> DerivedConstructors { get; } = new();
        public static Dictionary<string, Func<Transfer, string, object, FPropertyTag>> NativeConstructors { get; } = new();

        #region List of Tags
        [Location("void UStruct::SerializeVersionedTaggedProperties")]
        public static List<object> MoveTags(this Transfer transfer, List<object> list, int indent = 0, UObject obj = null)
        {
            if (transfer.IsWriting && list.Count == 0) return list;
            obj ??= new();
            (bool quit, int i) = (false, 0);
            while (!quit)
            {
                FPropertyTag tag = transfer.IsReading ? new FPropertyTag() : BaseTag(list[i], transfer);
                tag.Move(transfer);
                (long baseOffset, long endOffset) = (transfer.Position, transfer.Position + tag.Size);
                transfer.BaseOffset = baseOffset;
                if (tag.Name.IsFilled && tag.Size > 0)
                {
                    if (transfer.IsReading)
                        tag.Value = transfer.ReadMember(tag, indent, baseOffset, obj);
                    else
                        transfer.WriterMember(tag, indent, baseOffset, tag.Value, obj);
                    transfer.Counter++;
                    if (transfer.Position != endOffset)
                    {
                        Log.Error($"{(transfer.IsReading ? "Read" : "Write")} Failed. Expected Offset {endOffset} but was {transfer.Position}. Break at {baseOffset}");
                        throw new InvalidOperationException();
                    }
                }
                if (transfer.IsReading)
                {
                    list.Add(tag.Name.IsFilled && indent >= 0 ? DerivedTag(tag) : tag);
                    if (list[list.Count - 1] is Dictionary<string, object> dict)
                        obj.Members[dict.Keys.First()] = dict.Values.First();
                    else if (list[list.Count - 1] is FPropertyTag member && member.Name.ToString() == "None")
                        obj.Members["name"] = "None";
                    else if (list[list.Count - 1] is FPropertyTag member2)
                        obj.Members[member2.Name.ToString()] = member2;
                }
                quit = !tag.Name.IsFilled;
                i++;
            }
            return list;
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
            else if (tag.Type.Value == FBoolProperty.TYPE_NAME) return new FBoolPropertyJson(tag);
            else if (tag.Type.Value == Consts.SoftObjectProperty && tag.Size == 4) return new SoftObjectPropertyJson(tag);
            else if (tag.Type.Value == FByteProperty.TYPE_NAME && tag.Size == 1) return new FBytePropertyJson(tag);
            else if (tag.Type.Value == FByteProperty.TYPE_NAME && tag.Size == 4) return new FByte32PropertyJson(tag);
            else if (tag.Type.Value == FByteProperty.TYPE_NAME && tag.Size == 8) return new FByte64PropertyJson(tag);
            else if (tag.Type.Value == FDoubleProperty.TYPE_NAME) return new FDoublePropertyJson(tag);
            else if (tag.Type.Value == FEnumProperty.TYPE_NAME && tag.Size == 4) return new FEnum32PropertyJson(tag);
            else if (tag.Type.Value == FEnumProperty.TYPE_NAME && tag.Size == 8) return new FEnum64PropertyJson(tag);
            else if (tag.Type.Value == FFloatProperty.TYPE_NAME) return new FFloatPropertyJson(tag);
            else if (tag.Type.Value == FIntProperty.TYPE_NAME) return new FIntPropertyJson(tag);
            else if (tag.Type.Value == FNameProperty.TYPE_NAME) return new FNamePropertyJson(tag);
            else if (tag.Type.Value == FObjectProperty.TYPE_NAME) return new FObjectPropertyJson(tag);
            else if (tag.Type.Value == FStrProperty.TYPE_NAME) return new FStrPropertyJson(tag);
            else if (tag.Type.Value == FInt16Property.TYPE_NAME && tag.Size == 2) return new FInt16PropertyJson(tag);
            else if (tag.Type.Value == FUInt16Property.TYPE_NAME && tag.Size == 2) return new FUInt16PropertyJson(tag);
            else if (tag.Type.Value == FUInt32Property.TYPE_NAME && tag.Size == 4) return new FUInt32PropertyJson(tag);
            else if (tag.Type.Value == FUInt64Property.TYPE_NAME && tag.Size == 8) return new FUInt64PropertyJson(tag);
            else if (tag.Type.Value == FStructProperty.TYPE_NAME && tag.StructName?.Value == Consts.Guid) return new FGuidPropertyJson(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FObjectProperty.TYPE_NAME) return new FObjectPropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FBoolProperty.TYPE_NAME) return new FBoolPropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FIntProperty.TYPE_NAME) return new FIntPropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FInt64Property.TYPE_NAME) return new FInt64PropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FFloatProperty.TYPE_NAME) return new FFloatPropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FByteProperty.TYPE_NAME && tag.ArrayElementSize == 1) return new FBytePropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FByteProperty.TYPE_NAME && tag.ArrayElementSize == 8) return new FByte64PropertyJsonArray(tag);
            else return tag;
        }
        #endregion

        #region BaseTag
        private static FPropertyTag BaseTag(object item, Transfer transfer)
        {
            if (item is JsonElement elem)
            {
                string key = elem.EnumerateObject().First().Name;
                var value = elem.EnumerateObject().First().Value;
                string[] v = elem.EnumerateObject().First().Name.Split(' ').Concat(elem.EnumerateObject().First().Value.ToString().Split(' ')).ToArray();
                string type = v[0];

                if (NativeConstructors.TryGetValue(type, out var func))
                {
                    return func(transfer, key, value);
                }

                if (type == "soft") return SoftObjectPropertyJson.GetNative(transfer, key, value.ToObject<UInt32>(transfer));
                else if (type == "bool") return new FBoolPropertyJson().GetNative(transfer, key, value.ToObject<bool>(transfer));
                else if (type == "byte") return FBytePropertyJson.GetNative(transfer, key, value.ToObject<byte>(transfer));
                else if (type == "byte32") return new FByte32PropertyJson().GetNative(transfer, key, value.ToObject<UInt32>(transfer));
                else if (type == "byte64") return new FByte64PropertyJson().GetNative(transfer, key, value.ToObject<UInt64>(transfer));
                else if (type == "enum32") return FEnum32PropertyJson.GetNative(transfer, key, value.ToObject<UInt32>(transfer));
                else if (type == "enum64") return FEnum64PropertyJson.GetNative(transfer, key, value.ToObject<UInt64>(transfer));
                else if (type == "float") return FFloatPropertyJson.GetNative(transfer, key, value.ToObject<float>(transfer));
                else if (type == "double") return FDoublePropertyJson.GetNative(transfer, key, value.ToObject<double>(transfer));
                else if (type == "int") return FIntPropertyJson.GetNative(transfer, key, value.ToObject<Int32>(transfer));
                else if (type == "name") return FNamePropertyJson.GetNative(transfer, key, value.ToString());
                else if (type == "obj") return FObjectPropertyJson.GetNative(transfer, key, value.ToObject<UInt32>(transfer));
                else if (type == "string") return FStrPropertyJson.GetNative(transfer, key, value.ToString());
                else if (type == "short") return FInt16PropertyJson.GetNative(transfer, key, value.ToObject<Int16>(transfer));
                else if (type == "ushort") return FUInt16PropertyJson.GetNative(transfer, key, value.ToObject<UInt16>(transfer));
                else if (type == "uint") return FUInt32PropertyJson.GetNative(transfer, key, value.ToObject<UInt32>(transfer));
                else if (type == "ulong") return FUInt64PropertyJson.GetNative(transfer, key, value.ToObject<UInt64>(transfer));
                else if (type == "guid") return FGuidPropertyJson.GetNative(transfer, key, value.ToObject<Guid>(transfer));
                else if (type == "obj[]") return FObjectPropertyJsonArray.GetNative(transfer, key, value.ToString());
                else if (type == "bool[]") return FBoolPropertyJsonArray.GetNative(transfer, key, value.ToString());
                else if (type == "int[]") return FIntPropertyJsonArray.GetNative(transfer, key, value.ToString());
                else if (type == "long[]") return FInt64PropertyJsonArray.GetNative(transfer, key, value.ToString());
                else if (type == "float[]") return FFloatPropertyJsonArray.GetNative(transfer, key, value.ToString());
                else if (type == "byte[]") return FBytePropertyJsonArray.GetNative(transfer, key, value.ToString());
                else if (type == "byte64[]") return FByte64PropertyJsonArray.GetNative(transfer, key, value.ToString());
            }
            else if (item is IPropertytag propertytag)
            {
                return propertytag.GetNative(transfer);
            }
            else if (item is Dictionary<string, object> dict)
            {
                string key = dict.Keys.First();
                object value = dict.Values.First();
                string type = key.Split(' ')[0];
                if (NativeConstructors.TryGetValue(type, out var func))
                {
                    return func(transfer, key, value);
                }
            }
            return item.ToObject<FPropertyTag>(transfer);
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

            else if (type == FStructProperty.TYPE_NAME) tag.Value = ReadMemberStruct(transfer, structName, size, indent + inc, obj);
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
            else if (type == FGuid.TYPE_NAME) tag.Value = reader.ReadFGuid();
            else throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            if (startOffset != endOffset && (AppConfig.AutoCheckDeep || indent == 0))
                tag.AutoCheck(transfer, $"Name({tag.Name}) Type({tag.Type}) StructName({tag.StructName}) Size({tag.Size})", reader.BaseStream, [startOffset, endOffset], (transferWriter) => transferWriter.WriterMember(tag, indent, baseOffset, tag.Value, obj));
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

            else if (type == FStructProperty.TYPE_NAME) WriteMemberStruct(transfer, structName, value, size, indent + inc, obj);
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
            else if (type == FGuid.TYPE_NAME) writer.Write(value.ToObject<FGuid>(transfer));
            else throw new InvalidOperationException($"Invalid Tag Type: '{type}'");
        }
        #endregion

        #region Tag Value Struct
        [Location("void UScriptStruct::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)")]
        private static object ReadMemberStruct(this Transfer transfer, string structName, int size, int indent, UObject obj)
        {
            if (structName is { } && !StructMovers.ContainsKey(structName))
                Log.LogUnknownStruct(structName);

            transfer.GlobalObjects.LogStructName = structName;
            if (structName is { } && StructMovers.ContainsKey(structName))
            {
                object result = StructMovers[structName](transfer, size, null);
                if (result is { })
                {
                    return result;
                }
                else
                {
                    return transfer.MoveTags(new List<object>(), indent, obj);
                }
            }
            else
            {
                return transfer.MoveTags(new List<object>(), indent, obj);
            }
        }
        private static void WriteMemberStruct(this Transfer transfer, string structName, object value, int size, int indent, UObject obj)
        {
            if (structName is { } && StructMovers.ContainsKey(structName))
            {
                object result = StructMovers[structName](transfer, size, value);
                if (result is null)
                {
                    transfer.MoveTags(value.ToObject<List<object>>(transfer), indent, obj);
                }
            }
            else
            {
                transfer.MoveTags(value.ToObject<List<object>>(transfer), indent, obj);
            }
        }
        #endregion

        #region Tag Value Array
        [Location("void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)")]
        private static object ReadMemberArray(Transfer transfer, FPropertyTag tag, int indent, long baseOffset, UObject obj)
        {
            (_, string structName, _, string innerType, _, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.ValueType?.Value, tag.Size);
            int elemSize = 0;
            int count = transfer.reader.ReadInt32();
            if (count > AppConfig.MaxArraySize)
                throw new InvalidOperationException($"Array MaxSize Exceeded: {count}");
            List<object> list = Enumerable.Range(0, count).Select(x => (object)null).ToList();

            if (transfer.Supports.VER_UE4_INNER_ARRAY_TAG_INFO && innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag is null)
            {
                tag.MaybeInnerTag ??= new();
                tag.MaybeInnerTag.Move(transfer);
                if (tag.MaybeInnerTag.Type.Value == FStructProperty.TYPE_NAME)
                    structName = tag.MaybeInnerTag.StructName.Value;
                size = tag.MaybeInnerTag.Size / Math.Max(1, count);
                tag.ArrayElementSize = size;
            }

            if (innerType is { } && innerType != FStructProperty.TYPE_NAME)
            {
                elemSize = (tag.Size - 4) / Math.Max(1, count);
                tag.ArrayElementSize = elemSize;
            }

            for (int i = 0; i < count; i++)
            {
                if (obj.ArrayNotifiers.ContainsKey(tag.Name.Value))
                    obj.ArrayNotifiers[tag.Name.Value](transfer);

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
                    object value = StructMovers[structName](transfer, size, list[i]);
                    if (value is { })
                    {
                        list[i] = value;
                    }
                    else
                    {
                        list[i] = transfer.MoveTags(new List<object>(), indent, obj);
                    }
                }
                else if (innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag?.Type?.Value != FStructProperty.TYPE_NAME)
                {
                    object members = transfer.MoveTags(new List<object>(), indent, obj);
                    list[i] = members;
                }
                else
                {
                    var elemTag = new FPropertyTag
                    {
                        Type = tag.InnerType,
                        Size = elemSize,
                        StructName = structName is { } ? new FName(structName, transfer) : null
                    };
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
            (_, string structName, _, string innerType, _, int size) = (tag.Name.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.ValueType?.Value, tag.Size);
            int elemSize = 0;
            var list = array.ToObject<List<object>>(transfer);
            transfer.writer.Write(list.Count);

            if (transfer.Supports.VER_UE4_INNER_ARRAY_TAG_INFO && innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag is { })
            {
                tag.MaybeInnerTag.Move(transfer);
                if (tag.MaybeInnerTag.Type.Value == FStructProperty.TYPE_NAME)
                    structName = tag.MaybeInnerTag.StructName.Value;
                size = tag.MaybeInnerTag.Size / Math.Max(1, list.Count);
            }
            if (innerType is { } && innerType != FStructProperty.TYPE_NAME)
            {
                elemSize = (tag.Size - 4) / Math.Max(1, list.Count);
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
                    object value = StructMovers[structName](transfer, size, list[i]);
                    if (value is null)
                    {
                        List<object> members = list[i].ToObject<List<object>>(transfer);
                        transfer.MoveTags(members, indent, obj);
                    }
                }
                else if (innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag?.Type?.Value != FStructProperty.TYPE_NAME)
                {
                    List<object> members = list[i].ToObject<List<object>>(transfer);
                    transfer.MoveTags(members, indent, obj);
                }
                else
                {
                    var elemTag = new FPropertyTag
                    {
                        Type = tag.InnerType,
                        Size = elemSize,
                        StructName = structName is { } ? new FName(structName, transfer) : null,
                    };
                    transfer.WriterMember(elemTag, indent, baseOffset, list[i], obj);
                }
            }
        }
        #endregion

        static FPropertyTagExt()
        {
            #region Calling automatically Move function for classes containg the TransferibleStruct Attribute
            TransferibleStructAttribute.TypesAndAttributes.ToList().ForEach(t =>
            {
                StructMovers.Add(t.Item2.TypeName, (transfer, num, value) =>
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
                    else
                    {
                        return transfer.MoveTags(value.ToObject<List<object>>(transfer), 0, null);
                    }
                    return value;
                });
            });
            #endregion

            #region Elegant Json Creation From PropertTag
            TransferibleStructAttribute.TypesAndAttributes.ToList().ForEach(t =>
            {
                if (typeof(ITagSelector).IsAssignableFrom(t.Item1))
                {
                    DerivedConstructors.Add(t.Item2.TypeName, (tag) =>
                    {
                        string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
                        string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
                        var tagSelector = ((ITagSelector)Activator.CreateInstance(t.Item1));
                        string type = tagSelector.GetType(tag.Size);
                        object value = tagSelector.GetValue(tag.Value, tag.Size);
                        return new Dictionary<string, object> { { $"{type} '{tag.Name.ToString()}'{arrayIndex}{guidValue}", value } };
                    });

                }
            });
            #endregion

            #region PropertTag Creation From Elegant Json
            TransferibleStructAttribute.TypesAndAttributes.ToList().ForEach((Action<(Type, TransferibleStructAttribute)>)(t =>
            {
                if (typeof(ITagConverter).IsAssignableFrom(t.Item1))
                {
                    NativeConstructors.Add(t.Item2.TypeName, (Func<Transfer, string, object, FPropertyTag>)((transfer, key, value) =>
                    {
                        string pattern = t.Item2.TypeName + " '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";
                        var match = Regex.Match(key, pattern);
                        string name = match.Groups[1].Value;
                        string index = match.Groups[2].Value;
                        string guid = match.Groups[3].Value;
                        string structName = t.Item2.TypeName1 ?? t.Item2.TypeName;
                        object tagValue = null;
                        int size = 0;
                        if (value is JsonElement objs && objs.ValueKind == JsonValueKind.Object && objs.EnumerateObject().Count() > 1 && typeof(ITagConverter).IsAssignableFrom(t.Item1))
                        {
                            var dict = objs.ToObject<Dictionary<string, object>>(transfer);
                            List<object> tags = [];
                            foreach (var pair in dict)
                            {
                                string type = pair.Key.Split(' ')[0];
                                object tag = NativeConstructors[type](transfer, pair.Key, pair.Value);
                                tags.Add(tag);
                                size += FPropertyTag.HeaderSize(transfer) + ((FPropertyTag)tag).Size;
                            }
                            tags.Add(new FPropertyTag { Name = transfer.GlobalNames.None });
                            size += 8;
                            tagValue = tags;
                        }
                        else if (value is JsonElement obj && obj.ValueKind == JsonValueKind.Object && typeof(ITagConverter).IsAssignableFrom(t.Item1))
                        {
                            var dict = obj.ToObject<Dictionary<string, object>>(transfer);
                            List<object> tags = [];
                            foreach (var pair in dict)
                            {
                                string type = pair.Key.Split(' ')[0];
                                object tag = NativeConstructors[type](transfer, pair.Key, pair.Value);
                                tags.Add(tag);
                                size += FPropertyTag.HeaderSize(transfer) + ((FPropertyTag)tag).Size;
                            }
                            tags.Add(new FPropertyTag { Name = transfer.GlobalNames.None });
                            size += 8;
                            tagValue = tags;
                        }
                        else if (value is JsonElement str && str.ValueKind == JsonValueKind.String)
                        {
                            tagValue = $"\"{value.ToString()}\"".ToObject<object>(t.Item1, transfer);
                            size = t.Item2.Size(transfer);
                        }
                        else if (value is ITagConverter tagConverter)
                        {
                            tagValue = tagConverter;
                            size = tagConverter.TagSize(transfer);
                        }
                        else if (value is Dictionary<string, object> dict)
                        {
                            List<object> tags = [];
                            foreach (var pair in dict)
                            {
                                string type = pair.Key.Split(' ')[0];
                                object tag = NativeConstructors[type](transfer, pair.Key, pair.Value);
                                tags.Add(tag);
                                size += FPropertyTag.HeaderSize(transfer) + ((FPropertyTag)tag).Size;
                            }
                            tags.Add(new FPropertyTag { Name = transfer.GlobalNames.None });
                            size += 8;
                            tagValue = tags;
                        }
                        return new FPropertyTag
                        {
                            Name = new FName(name, transfer),
                            Type = new FName(FStructProperty.TYPE_NAME, transfer),
                            StructName = new FName(structName, transfer),
                            Value = tagValue,
                            Size = size,
                            ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                            HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                            PropertyGuid = guid.Length > 0 ? new FGuid(guid) : default,
                        };

                    }));
                }
            }));
            #endregion

            #region Handling special cases of Array of StructProperty
            TransfersForName.Add("VoronoiSites", (transfer, value) => value.ToObject<FVector>(transfer).Move(transfer));
            TransfersForName.Add("ReferencedTextureGuids", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
            TransfersForName.Add("IrrelevantLights", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
            #endregion
        }

        public static Dictionary<string, Func<Transfer, object, object>> TransfersForName { get; } = new();
    }
}

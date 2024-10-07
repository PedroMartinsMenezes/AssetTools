using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace AssetTool
{
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

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FPropertyTag& Tag)")]
        public FPropertyTag Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            if (Name.IsFilled)
            {
                transfer.Move(ref Type);
                CheckTagType();

                transfer.Move(ref Size);
                transfer.Move(ref ArrayIndex);
                if (Type.Number == 0)
                {
                    if (Type.Value == FStructProperty.TYPE_NAME)
                        (_, _) = (transfer.Move(ref StructName), Supports.VER_UE4_STRUCT_GUID_IN_PROPERTY_TAG ? transfer.Move(ref StructGuid) : null);
                    else if (Type.Value == FBoolProperty.TYPE_NAME)
                        transfer.Move(ref BoolVal);
                    else if (Type.Value == FByteProperty.TYPE_NAME)
                        transfer.Move(ref EnumName);
                    else if (Type.Value == FEnumProperty.TYPE_NAME)
                        transfer.Move(ref EnumName);
                    else if (Type.Value == Consts.ArrayProperty && Supports.VAR_UE4_ARRAY_PROPERTY_INNER_TAGS)
                        transfer.Move(ref InnerType);
                    else if (Type.Value == Consts.OptionalProperty)
                        transfer.Move(ref InnerType);
                    else if (Type.Value == Consts.SetProperty && Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT))
                        transfer.Move(ref InnerType);
                    else if (Type.Value == Consts.MapProperty && Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT))
                        (_, _) = (transfer.Move(ref InnerType), transfer.Move(ref ValueType));
                }
                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG))
                {
                    transfer.Move(ref HasPropertyGuid);
                    if (HasPropertyGuid == 1)
                        transfer.Move(ref PropertyGuid);
                }
            }
            return this;
        }

        private void CheckTagType()
        {
            if (Type.Value == GlobalNames.None.Value)
            {
                Log.Error($"StructName Not Found:\n\t{GlobalObjects.LogStructName}");
                Log.Error($"Look for:\n\tTStructOpsTypeTraits<F{GlobalObjects.LogStructName}>");
                Log.Error($"Look for:\n\tF{GlobalObjects.LogStructName}::Serialize");
                throw new InvalidOperationException("Invalid Tag Type");
            }
            else if (int.TryParse(Type.Value, out int value))
            {
                throw new InvalidOperationException($"Invalid Tag Type: '{value}'");
            }
        }
    }

    public static class FPropertyTagExt
    {
        public static Dictionary<string, Func<Transfer, int, object, object>> StructMovers { get; } = new();
        public static Dictionary<string, Func<FPropertyTag, object>> DerivedConstructors { get; } = new();
        public static Dictionary<string, Func<string, object, FPropertyTag>> NativeConstructors { get; } = new();

        #region List of Tags
        [Location("void UStruct::SerializeVersionedTaggedProperties")]
        public static List<object> MoveTags(this Transfer transfer, List<object> list, int indent = 0, UObject obj = null)
        {
            if (transfer.IsWriting && list.Count == 0) return list;
            obj ??= new();
            (bool quit, int i) = (false, 0);
            while (!quit)
            {
                FPropertyTag tag = transfer.IsReading ? new FPropertyTag() : BaseTag(list[i++]);
                tag.Move(transfer);
                (long baseOffset, long endOffset) = (transfer.Position, transfer.Position + tag.Size);
                if (tag.Name.IsFilled)
                {
                    if (transfer.IsReading)
                        tag.Value = transfer.reader.ReadMember(tag, indent, baseOffset, obj);
                    else
                        transfer.writer.WriterMember(tag, indent, baseOffset, tag.Value, obj);
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
            else if (tag.Type.Value == FUInt16Property.TYPE_NAME && tag.Size == 2) return new FUInt16PropertyJson(tag);
            else if (tag.Type.Value == FUInt32Property.TYPE_NAME && tag.Size == 4) return new FUInt32PropertyJson(tag);
            else if (tag.Type.Value == FUInt64Property.TYPE_NAME && tag.Size == 8) return new FUInt64PropertyJson(tag);
            else if (tag.Type.Value == FStructProperty.TYPE_NAME && tag.StructName?.Value == Consts.Guid) return new FGuidPropertyJson(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FObjectProperty.TYPE_NAME) return new FObjectPropertyJsonArray(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FBoolProperty.TYPE_NAME) return new FBoolPropertyJsonArray(tag);
            else return tag;
        }
        #endregion

        #region BaseTag
        private static FPropertyTag BaseTag(object item)
        {
            if (item is JsonElement elem)
            {
                string key = elem.EnumerateObject().First().Name;
                var value = elem.EnumerateObject().First().Value;
                string[] v = elem.EnumerateObject().First().Name.Split(' ').Concat(elem.EnumerateObject().First().Value.ToString().Split(' ')).ToArray();
                string type = v[0];

                if (NativeConstructors.TryGetValue(type, out var func))
                {
                    return func(key, value);
                }

                if (type == "soft") return SoftObjectPropertyJson.GetNative(key, value.ToObject<UInt32>());
                else if (type == "bool") return FBoolPropertyJson.GetNative(key, value.ToObject<bool>());
                else if (type == "byte32") return FByte32PropertyJson.GetNative(key, value.ToObject<UInt32>());
                else if (type == "byte64") return FByte64PropertyJson.GetNative(key, value.ToObject<UInt64>());
                else if (type == "enum32") return FEnum32PropertyJson.GetNative(key, value.ToObject<UInt32>());
                else if (type == "enum64") return FEnum64PropertyJson.GetNative(key, value.ToObject<UInt64>());
                else if (type == "float") return FFloatPropertyJson.GetNative(key, value.ToObject<float>());
                else if (type == "double") return FDoublePropertyJson.GetNative(key, value.ToObject<double>());
                else if (type == "int") return FIntPropertyJson.GetNative(key, value.ToObject<Int32>());
                else if (type == "name") return FNamePropertyJson.GetNative(key, value.ToString());
                else if (type == "obj") return FObjectPropertyJson.GetNative(key, value.ToObject<UInt32>());
                else if (type == "string") return FStrPropertyJson.GetNative(key, value.ToString());
                else if (type == "ushort") return FUInt16PropertyJson.GetNative(key, value.ToObject<UInt16>());
                else if (type == "uint") return FUInt32PropertyJson.GetNative(key, value.ToObject<UInt32>());
                else if (type == "ulong") return FUInt64PropertyJson.GetNative(key, value.ToObject<UInt64>());
                else if (type == "guid") return FGuidPropertyJson.GetNative(key, value.ToObject<Guid>());
                else if (type == "obj[]") return FObjectPropertyJsonArray.GetNative(key, value.ToString());
                else if (type == "bool[]") return FBoolPropertyJsonArray.GetNative(key, value.ToString());
            }
            else if (item is IPropertytag propertytag)
            {
                return propertytag.GetNative();
            }
            else if (item is Dictionary<string, object> dict)
            {
                string key = dict.Keys.First();
                object value = dict.Values.First();
                string type = key.Split(' ')[0];
                if (NativeConstructors.TryGetValue(type, out var func))
                {
                    return func(key, value);
                }
            }
            return item.ToObject<FPropertyTag>();
        }
        #endregion

        #region Tag Value Single
        [Location("void FPropertyTag::SerializeTaggedProperty(FStructuredArchive::FSlot Slot, FProperty* Property, uint8* Value, const uint8* Defaults) const")]
        public static object ReadMember(this BinaryReader reader, FPropertyTag tag, int indent, long baseOffset, UObject obj)
        {
            var transfer = GlobalObjects.Transfer;
            (long startOffset, long endOffset) = (reader.BaseStream.Position, reader.BaseStream.Position + tag.Size);
            (string name, string structName, string type, string innerType, string valueType, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.ValueType?.Value, tag.Size);
            int inc = Log.InfoRead(reader.BaseStream.Position, indent, tag);

            if (type is null) throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            else if (type == FStructProperty.TYPE_NAME) tag.Value = ReadMemberStruct(reader, structName, size, indent + inc, obj);
            else if (type == Consts.ArrayProperty) tag.Value = ReadMemberArray(reader, tag, indent + inc, baseOffset, obj);

            else if (type == Consts.SoftObjectProperty && size == 4) tag.Value = reader.ReadUInt32();
            else if (type == Consts.SoftObjectProperty) tag.Value = tag.Value.ToObject<FSoftObjectPath>().Move(transfer);
            else if (type == FBoolProperty.TYPE_NAME && size == 0) tag.Value = null;
            else if (type == FBoolProperty.TYPE_NAME && size == 1) tag.Value = tag.Value = reader.ReadByte();
            else if (type == FByteProperty.TYPE_NAME && size == 1) tag.Value = reader.ReadByte();
            else if (type == FByteProperty.TYPE_NAME && size == 4) tag.Value = reader.ReadUInt32();
            else if (type == FByteProperty.TYPE_NAME && size == 8) tag.Value = reader.ReadUInt64();
            else if (type == FEnumProperty.TYPE_NAME && size == 4) tag.Value = reader.ReadUInt32();
            else if (type == FEnumProperty.TYPE_NAME && size == 8) tag.Value = reader.ReadUInt64();
            else if (type == FFloatProperty.TYPE_NAME) tag.Value = reader.ReadSingle();
            else if (type == FDoubleProperty.TYPE_NAME) tag.Value = reader.ReadDouble();
            else if (type == FIntProperty.TYPE_NAME) tag.Value = reader.ReadInt32();
            else if (type == FNameProperty.TYPE_NAME) tag.Value = reader.ReadFName();
            else if (type == FObjectProperty.TYPE_NAME) tag.Value = reader.ReadUInt32();
            else if (type == FObjectPropertyBase.TYPE_NAME) tag.Value = reader.ReadUInt32();
            else if (type == FStrProperty.TYPE_NAME) tag.Value = reader.ReadFString();
            else if (type == FTextProperty.TYPE_NAME) tag.Value = tag.Value.ToObject<FText>().Move(transfer);
            else if (type == FUInt16Property.TYPE_NAME) tag.Value = reader.ReadUInt16();
            else if (type == FUInt32Property.TYPE_NAME && size == 4) tag.Value = reader.ReadUInt32();
            else if (type == FUInt64Property.TYPE_NAME && size == 8) tag.Value = reader.ReadUInt64();
            else if (type == FInt64Property.TYPE_NAME && size == 8) tag.Value = reader.ReadInt64();
            else if (type == FMapProperty.TYPE_NAME) tag.Value = new FMapProperty().MoveValue(transfer, name, valueType, innerType, indent + inc);
            else if (type == FInterfaceProperty.TYPE_NAME) tag.Value = tag.Value.ToObject<FInterfaceProperty>().MoveValue(transfer);
            else if (type == FFieldPathProperty.TYPE_NAME) tag.Value = tag.Value.ToObject<FFieldPathProperty>().Move(transfer);
            else if (type == FSetProperty.TYPE_NAME) tag.Value = new FSetProperty().MoveValue(transfer, name, valueType, innerType, indent + inc);
            else throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            if (startOffset != endOffset && (AppConfig.RedundantAutoCheck || indent == 0))
                tag.AutoCheck($"Name({tag.Name}) Type({tag.Type}) StructName({tag.StructName}) Size({tag.Size})", reader.BaseStream, [startOffset, endOffset], (writer) => writer.WriterMember(tag, indent, baseOffset, tag.Value, obj));
            else if (indent == 0 && tag.Size == 0)
                Log.InfoWrite(reader.BaseStream.Position, indent, tag, true);
            return tag.Value;
        }

        public static void WriterMember(this BinaryWriter writer, FPropertyTag tag, int indent, long baseOffset, object value, UObject obj)
        {
            var transfer = GlobalObjects.Transfer;
            (string name, string structName, string type, string innerType, string valueType, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.ValueType?.Value, tag.Size);
            int inc = Log.InfoWrite(writer.BaseStream.Position, indent, tag, false);

            if (type is null) throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            else if (type == FStructProperty.TYPE_NAME) WriteMemberStruct(writer, structName, value, size, indent + inc, obj);
            else if (type == Consts.ArrayProperty) WriteMemberArray(writer, tag, value, indent + inc, baseOffset, obj);

            else if (type == Consts.SoftObjectProperty && size == 4) writer.Write(value.ToObject<UInt32>());
            else if (type == Consts.SoftObjectProperty) value.ToObject<FSoftObjectPath>().Move(transfer);
            else if (type == FBoolProperty.TYPE_NAME && size == 0) return;
            else if (type == FBoolProperty.TYPE_NAME && size == 1) writer.Write(value.ToObject<byte>());
            else if (type == FByteProperty.TYPE_NAME && size == 1) writer.Write(value.ToObject<byte>());
            else if (type == FByteProperty.TYPE_NAME && size == 4) writer.Write(value.ToObject<UInt32>());
            else if (type == FByteProperty.TYPE_NAME && size == 8) writer.Write(value.ToObject<UInt64>());
            else if (type == FEnumProperty.TYPE_NAME && size == 4) writer.Write(value.ToObject<UInt32>());
            else if (type == FEnumProperty.TYPE_NAME && size == 8) writer.Write(value.ToObject<UInt64>());
            else if (type == FFloatProperty.TYPE_NAME) writer.Write(value.ToObject<float>());
            else if (type == FDoubleProperty.TYPE_NAME) writer.Write(value.ToObject<double>());
            else if (type == FInt8Property.TYPE_NAME) writer.Write(value.ToObject<sbyte>());
            else if (type == FInt16Property.TYPE_NAME) writer.Write(value.ToObject<Int16>());
            else if (type == FIntProperty.TYPE_NAME) writer.Write(value.ToObject<Int32>());
            else if (type == FInt64Property.TYPE_NAME) writer.Write(value.ToObject<Int64>());
            else if (type == FNameProperty.TYPE_NAME) writer.Write(value.ToObject<FName>());
            else if (type == FObjectProperty.TYPE_NAME) writer.Write(value.ToObject<UInt32>());
            else if (type == FObjectPropertyBase.TYPE_NAME) writer.Write(value.ToObject<UInt32>());
            else if (type == FStrProperty.TYPE_NAME) writer.Write(value.ToObject<FString>());
            else if (type == FTextProperty.TYPE_NAME) value.ToObject<FText>().Move(transfer);
            else if (type == FUInt16Property.TYPE_NAME) writer.Write(value.ToObject<UInt16>());
            else if (type == FUInt32Property.TYPE_NAME && size == 4) writer.Write(value.ToObject<UInt32>());
            else if (type == FUInt64Property.TYPE_NAME && size == 8) writer.Write(value.ToObject<UInt64>());
            else if (type == FInt64Property.TYPE_NAME && size == 8) writer.Write(value.ToObject<Int64>());
            else if (type == FMapProperty.TYPE_NAME) value.ToObject<FMapProperty>().MoveValue(transfer, name, valueType, innerType, indent + inc);
            else if (type == FInterfaceProperty.TYPE_NAME) tag.Value.ToObject<FInterfaceProperty>().MoveValue(transfer);
            else if (type == FFieldPathProperty.TYPE_NAME) value.ToObject<FFieldPathProperty>().Move(transfer);
            else if (type == FSetProperty.TYPE_NAME) value.ToObject<FSetProperty>().MoveValue(transfer, name, valueType, innerType, indent + inc);
            else throw new InvalidOperationException($"Invalid Tag Type: '{type}'");
        }
        #endregion

        #region Tag Value Struct
        [Location("void UScriptStruct::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)")]
        private static object ReadMemberStruct(this BinaryReader reader, string structName, int size, int indent, UObject obj)
        {
            if (structName is { } && !StructMovers.ContainsKey(structName))
                Log.LogUnknownStruct(structName);

            GlobalObjects.LogStructName = structName;
            if (structName is { } && StructMovers.ContainsKey(structName))
                return StructMovers[structName](GlobalObjects.Transfer, size, null);
            else
                return GlobalObjects.Transfer.MoveTags(new List<object>(), indent, obj);
        }
        private static void WriteMemberStruct(this BinaryWriter writer, string structName, object value, int size, int indent, UObject obj)
        {
            if (structName is { } && StructMovers.ContainsKey(structName))
                StructMovers[structName](GlobalObjects.Transfer, size, value);
            else
                GlobalObjects.Transfer.MoveTags(value.ToObject<List<object>>(), indent, obj);
        }
        #endregion

        #region Tag Value Array
        [Location("void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)")]
        private static object ReadMemberArray(BinaryReader reader, FPropertyTag tag, int indent, long baseOffset, UObject obj)
        {
            (_, string structName, _, string innerType, _, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.ValueType?.Value, tag.Size);
            int elemSize = 0;
            int count = reader.ReadInt32();
            if (count > AppConfig.MaxArraySize)
                throw new InvalidOperationException($"Array MaxSize Exceeded: {count}");
            List<object> list = Enumerable.Range(0, count).Select(x => (object)null).ToList();
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_INNER_ARRAY_TAG_INFO) && innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag is null)
            {
                tag.MaybeInnerTag ??= new();
                tag.MaybeInnerTag.Move(GlobalObjects.Transfer);
                if (tag.MaybeInnerTag.Type.Value == FStructProperty.TYPE_NAME)
                    structName = tag.MaybeInnerTag.StructName.Value;
                size = tag.MaybeInnerTag.Size / Math.Max(1, count);
            }
            if (innerType is { } && innerType != FStructProperty.TYPE_NAME)
            {
                elemSize = (tag.Size - 4) / Math.Max(1, count);
            }
            for (int i = 0; i < count; i++)
            {
                if (structName is { } && StructMovers.ContainsKey(structName))
                {
                    object value = StructMovers[structName](GlobalObjects.Transfer, size, list[i]);
                    list[i] = value;
                }
                else if (innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag?.Type?.Value != FStructProperty.TYPE_NAME)
                {
                    if (size > 24)
                    {
                        object members = GlobalObjects.Transfer.MoveTags(new List<object>(), indent, obj);
                        list[i] = members;
                    }
                    else
                    {
                        object value = reader.ReadMemberStruct(Consts.Guid, size, indent, obj);
                        list[i] = value;
                    }
                }
                else
                {
                    var elemTag = new FPropertyTag
                    {
                        Type = tag.InnerType,
                        Size = elemSize,
                        StructName = structName is { } ? new FName(structName) : null
                    };
                    object value = reader.ReadMember(elemTag, indent, baseOffset, obj);
                    list[i] = value;
                }
            }
            if (count != list.Count)
                throw new InvalidOperationException("Empty array");
            return list;
        }
        private static void WriteMemberArray(BinaryWriter writer, FPropertyTag tag, object array, int indent, long baseOffset, UObject obj)
        {
            (_, string structName, _, string innerType, _, int size) = (tag.Name.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.ValueType?.Value, tag.Size);
            int elemSize = 0;
            var list = array.ToObject<List<object>>();
            writer.Write(list.Count);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_INNER_ARRAY_TAG_INFO) && innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag is { })
            {
                tag.MaybeInnerTag.Move(GlobalObjects.Transfer);
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
                if (structName is { } && StructMovers.ContainsKey(structName))
                {
                    StructMovers[structName](GlobalObjects.Transfer, size, list[i]);
                }
                else if (innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag?.Type?.Value != FStructProperty.TYPE_NAME)
                {
                    if (size > 24)
                    {
                        List<object> members = list[i].ToObject<List<object>>();
                        GlobalObjects.Transfer.MoveTags(members, indent, obj);
                    }
                    else
                    {
                        var guid = list[i].ToObject<FGuid>();
                        writer.WriteMemberStruct(Consts.Guid, guid, size, indent, obj);
                    }
                }
                else
                {
                    var elemTag = new FPropertyTag
                    {
                        Type = tag.InnerType,
                        Size = elemSize,
                        StructName = structName is { } ? new FName(structName) : null,
                    };
                    writer.WriterMember(elemTag, indent, baseOffset, list[i], obj);
                }
            }
        }
        #endregion

        static FPropertyTagExt()
        {
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
                    else if (value is JsonElement obj2 && typeof(ITransferible).IsAssignableFrom(t.Item1))
                    {
                        ITransferible self = obj2.ToObject<ITransferible>(t.Item1);
                        value = self.Move(transfer);
                    }
                    #endregion
                    else
                    {
                        return GlobalObjects.Transfer.MoveTags(value.ToObject<List<object>>(), 0, null);
                    }
                    return value;
                });
            });

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

            TransferibleStructAttribute.TypesAndAttributes.ToList().ForEach((Action<(Type, TransferibleStructAttribute)>)(t =>
            {
                if (typeof(ITagConverter).IsAssignableFrom(t.Item1))
                {
                    NativeConstructors.Add(t.Item2.TypeName, (Func<string, object, FPropertyTag>)((key, value) =>
                    {
                        string pattern = t.Item2.TypeName + " '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";
                        var match = Regex.Match(key, pattern);
                        string name = match.Groups[1].Value;
                        string index = match.Groups[2].Value;
                        string guid = match.Groups[3].Value;
                        string structName = t.Item2.TypeName1;
                        object tagValue = null;
                        int size = 0;
                        if (value is JsonElement objs && objs.ValueKind == JsonValueKind.Object && objs.EnumerateObject().Count() > 1 && typeof(ITagConverter).IsAssignableFrom(t.Item1))
                        {
                            var dict = objs.ToObject<Dictionary<string, object>>();
                            var list = dict.Select(pair =>
                            {
                                string type = pair.Key.Split(' ')[0];
                                object tag = NativeConstructors[type](pair.Key, pair.Value);
                                return tag;
                            });
                            tagValue = list.Append(GlobalObjects.TagNone).ToList();
                            size = t.Item2.Size1;
                            structName = t.Item2.TypeName1;
                        }
                        else if (value is JsonElement obj && obj.ValueKind == JsonValueKind.Object && typeof(ITagConverter).IsAssignableFrom(t.Item1))
                        {
                            ITagConverter converter = ((ITagConverter)Activator.CreateInstance(t.Item1));
                            tagValue = converter.TagRead(value);
                            size = converter.TagSize;
                        }
                        else if (value is JsonElement str && str.ValueKind == JsonValueKind.String)
                        {
                            tagValue = ((IJsonConverter)Activator.CreateInstance(t.Item1)).JsonRead(str);
                            size = t.Item2.Size1;
                        }
                        else if (value is ITagConverter tagConverter)
                        {
                            tagValue = tagConverter;
                            size = tagConverter.TagSize;
                        }
                        else if (value is Dictionary<string, object> dict)
                        {
                            var tags = dict.Select(pair =>
                            {
                                string type = pair.Key.Split(' ')[0];
                                object tag = NativeConstructors[type](pair.Key, pair.Value);
                                return tag;
                            });
                            tagValue = tags.Append(GlobalObjects.TagNone).ToList();
                            size = t.Item2.Size1;
                        }
                        return new FPropertyTag
                        {
                            Name = new FName(name),
                            Type = new FName(FStructProperty.TYPE_NAME),
                            StructName = new FName(structName),
                            Value = tagValue,
                            Size = size,
                            ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                            HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                            PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
                        };

                    }));
                }
            }));
        }
    }
}

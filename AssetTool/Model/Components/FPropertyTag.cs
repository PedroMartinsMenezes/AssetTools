using AssetTool.UE.Runtime.Engine;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FPropertyTag& Tag)")]
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

        [JsonIgnore] public string GuidValue => HasPropertyGuid == 0 ? string.Empty : PropertyGuid.ToString();
        [JsonIgnore]
        public string JsonKey => Type?.Value == FStructProperty.TYPE_NAME && StructName is { } ? $"{StructName.Value}" : $"{Type?.Value}";

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FPropertyTag& Tag)")]
        public FPropertyTag Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            if (Name.IsFilled)
            {
                transfer.Move(ref Type);
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
    }

    public static class FPropertyTagExt
    {
        public static Dictionary<string, Func<Transfer, int, object, object>> StructMovers { get; } = new();

        public static Dictionary<string, Func<BinaryReader, int, object>> StructReaders { get; } = new();
        public static Dictionary<string, Action<BinaryWriter, int, object>> StructWriters { get; } = new();

        public static Dictionary<string, Func<FPropertyTag, object>> DerivedConstructors { get; } = new();
        public static Dictionary<string, Func<string, JsonElement, FPropertyTag>> NativeConstructors { get; } = new();

        static FPropertyTagExt()
        {
            StructMovers.Add(FSoftObjectPath.StructName, (transfer, num, value) => value.ToObject<FSoftObjectPath>().Move(transfer));

            #region StructReaders
            StructReaders.Add(FVector2DSelector.StructName, FVector2DSelector.Read);
            StructReaders.Add(FVector3f.StructName, (reader, num) => num == FVector3f.SIZE ? new FVector3f(reader) : new FVector3d(reader));
            StructReaders.Add(Consts.Guid, (reader, num) => reader.ReadFGuid());
            StructReaders.Add(FPointerToUberGraphFrame.StructName, (reader, num) => new FPointerToUberGraphFrame(reader));
            StructReaders.Add(FRotator.StructName, (reader, num) => num == 12 ? new FRotator().ReadFloat(reader) : new FRotator().ReadDouble(reader));
            StructReaders.Add(FLinearColor.StructName, (reader, num) => new FLinearColor(reader));
            StructReaders.Add(FRichCurveKey.StructName, (reader, num) => new FRichCurveKey(reader));
            StructReaders.Add(FColorMaterialInput.StructName, (reader, num) => new FColorMaterialInput(reader));
            StructReaders.Add(FExpressionInput.StructName, (reader, num) => new FExpressionInput(reader));
            StructReaders.Add(FEdGraphPinType.StructName, (reader, num) => new FEdGraphPinType().Move(GlobalObjects.Transfer));
            StructReaders.Add(FColor.StructName, (reader, num) => new FColor(reader));
            StructReaders.Add(FPerPlatformFloat.StructName, (reader, num) => new FPerPlatformFloat().Read(reader));
            StructReaders.Add(FBox.StructName, (reader, num) => new FBox().Read(reader));
            StructReaders.Add(FQuat.StructName, (reader, num) => new FQuat().Read(reader));
            #endregion

            #region StructWriters
            StructWriters.Add(FVector2DSelector.StructName, FVector2DSelector.Write);
            StructWriters.Add(FVector3f.StructName + FVector3f.SIZE, (writer, num, value) => value.ToObject<FVector3f>().Write(writer));
            StructWriters.Add(FVector3d.StructName + FVector3d.SIZE, (writer, num, value) => value.ToObject<FVector3d>().Write(writer));
            StructWriters.Add(FVector3f.StructName, (writer, num, value) => StructWriters[$"{FVector3f.StructName}{num}"](writer, num, value));
            StructWriters.Add(FRotator.StructName + "12", (writer, num, value) => value.ToObject<FRotator>().WriteFloat(writer));
            StructWriters.Add(FRotator.StructName + "24", (writer, num, value) => value.ToObject<FRotator>().WriteDouble(writer));
            StructWriters.Add(FRotator.StructName, (writer, num, value) => StructWriters[$"{FRotator.StructName}{num}"](writer, num, value));
            StructWriters.Add(Consts.Guid, (writer, num, value) => writer.WriteFGuid(value));
            StructWriters.Add(FPointerToUberGraphFrame.StructName, (writer, num, value) => value.ToObject<FPointerToUberGraphFrame>().Write(writer));
            StructWriters.Add(FLinearColor.StructName, (writer, num, value) => value.ToObject<FLinearColor>().Write(writer));
            StructWriters.Add(FRichCurveKey.StructName, (writer, num, value) => value.ToObject<FRichCurveKey>().Write(writer));
            StructWriters.Add(FColorMaterialInput.StructName, (writer, num, value) => value.ToObject<FColorMaterialInput>().Write(writer));
            StructWriters.Add(FExpressionInput.StructName, (writer, num, value) => value.ToObject<FExpressionInput>().Write(writer));
            StructWriters.Add(FEdGraphPinType.StructName, (writer, num, value) => value.ToObject<FEdGraphPinType>().Move(GlobalObjects.Transfer));
            StructWriters.Add(FColor.StructName, (writer, num, value) => value.ToObject<FColor>().Write(writer));
            StructWriters.Add(FPerPlatformFloat.StructName, (writer, num, value) => value.ToObject<FPerPlatformFloat>().Write(writer));
            StructWriters.Add(FBox.StructName, (writer, num, value) => value.ToObject<FBox>().Write(writer));
            StructWriters.Add(FQuat.StructName, (writer, num, value) => value.ToObject<FQuat>().Write(writer));
            #endregion

            #region DerivedConstructors
            DerivedConstructors.Add($"{FVector2DSelector.StructName}", FVector2DSelector.GetDerived);
            DerivedConstructors.Add($"{FLinearColor.StructName}", (tag) => new FLinearColorJson(tag));
            DerivedConstructors.Add($"{FQuat.StructName}", (tag) => new FQuatJson(tag));
            #endregion

            #region NativeConstructors
            NativeConstructors.Add($"{FVector2Df.StructNameKey}", (key, value) => FVector2DfJson.GetNative(key, value.ToString()));
            NativeConstructors.Add($"{FVector2D.StructNameKey}", (key, value) => FVector2DJson.GetNative(key, value.ToString()));
            NativeConstructors.Add($"{FLinearColor.StructName}", (key, value) => FLinearColorJson.GetNative(key, value.ToString()));
            NativeConstructors.Add($"{FQuat.StructName}", (key, value) => FQuatJson.GetNative(key, value.ToString()));
            #endregion
        }

        #region List of Tags
        [Location("void UStruct::SerializeVersionedTaggedProperties")]
        public static List<object> MoveTags(this Transfer transfer, List<object> list, int indent = 0)
        {
            bool quit = false;
            int i = 0;
            FPropertyTag tag;
            while (!quit)
            {
                tag = transfer.IsReading ? new FPropertyTag() : BaseTag(list[i++]);

                tag.Move(transfer);

                long baseOffset = transfer.Position;
                long endOffset = transfer.Position + tag.Size;

                if (tag.Name.IsFilled)
                {
                    if (transfer.IsReading)
                        tag.Value = transfer.reader.ReadMember(tag, indent, baseOffset);
                    else
                        transfer.writer.WriterMember(tag, indent, baseOffset, tag.Value);

                    if (transfer.Position != endOffset)
                    {
                        Log.Info($"{(transfer.IsReading ? "Read" : "Write")} Failed. Expected Offset {endOffset} but was {transfer.Position}");
                        throw new InvalidOperationException();
                    }
                }

                if (transfer.IsReading)
                    list.Add(tag.Name.IsFilled ? DerivedTag(tag) : tag);

                if (!tag.Name.IsFilled)
                    quit = true;
            }
            return list;
        }
        #endregion

        #region DerivedTag and BaseTag
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
            else if (tag.Type.Value == FObjectPropertyBase.TYPE_NAME) return new FObjectPropertyBaseJson(tag);
            else if (tag.Type.Value == FStrProperty.TYPE_NAME) return new FStrPropertyJson(tag);
            else if (tag.Type.Value == FUInt32Property.TYPE_NAME && tag.Size == 4) return new FUInt32PropertyJson(tag);
            else if (tag.Type.Value == FUInt64Property.TYPE_NAME && tag.Size == 8) return new FUInt64PropertyJson(tag);
            else if (tag.Type.Value == FStructProperty.TYPE_NAME && tag.StructName?.Value == Consts.Guid) return new FGuidPropertyJson(tag);
            else if (tag.Type.Value == Consts.ArrayProperty && tag.InnerType?.Value == FObjectPropertyBase.TYPE_NAME) return new FObjectPropertyBaseJsonArray(tag);
            else return tag;
        }

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

                if (type == "soft") return SoftObjectPropertyJson.GetNative(v);
                else if (type == "bool") return FBoolPropertyJson.GetNative(key, value.ToObject<bool>());
                else if (type == "byte32") return FByte32PropertyJson.GetNative(key, value.ToObject<UInt32>());
                else if (type == "byte64") return FByte64PropertyJson.GetNative(key, value.ToObject<UInt64>());
                else if (type == "enum32") return FEnum32PropertyJson.GetNative(key, value.ToObject<UInt32>());
                else if (type == "enum64") return FEnum64PropertyJson.GetNative(key, value.ToObject<UInt64>());
                else if (type == "float") return FFloatPropertyJson.GetNative(key, value.ToObject<float>());
                else if (type == "double") return FDoublePropertyJson.GetNative(key, value.ToObject<double>());
                else if (type == "int") return FIntPropertyJson.GetNative(key, value.ToObject<Int32>());
                else if (type == "name") return FNamePropertyJson.GetNative(v);
                else if (type == "obj") return FObjectPropertyBaseJson.GetNative(key, value.ToObject<UInt32>());
                else if (type == "string") return FStrPropertyJson.GetNative(v);
                else if (type == "uint") return FUInt32PropertyJson.GetNative(key, value.ToObject<UInt32>());
                else if (type == "ulong") return FUInt64PropertyJson.GetNative(key, value.ToObject<UInt64>());
                else if (type == "guid") return FGuidPropertyJson.GetNative(v);
                else if (type == "obj[]") return FObjectPropertyBaseJsonArray.GetNative(key, value.ToString());
            }
            else if (item is IPropertytag propertytag)
            {
                return propertytag.GetNative();
            }

            return item.ToObject<FPropertyTag>();
        }
        #endregion

        #region Tag Value Single
        [Location("void FPropertyTag::SerializeTaggedProperty(FStructuredArchive::FSlot Slot, FProperty* Property, uint8* Value, const uint8* Defaults) const")]
        public static object ReadMember(this BinaryReader reader, FPropertyTag tag, int indent, long baseOffset)
        {
            var transfer = GlobalObjects.Transfer;
            (long startOffset, long endOffset) = (reader.BaseStream.Position, reader.BaseStream.Position + tag.Size);
            (string name, string structName, string type, string innerType, string valueType, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.ValueType?.Value, tag.Size);
            int inc = Log.InfoRead(reader.BaseStream.Position, indent, tag);

            if (type is null) throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            else if (type == FStructProperty.TYPE_NAME) tag.Value = ReadMemberStruct(reader, structName, size, indent + inc);
            else if (type == Consts.ArrayProperty) tag.Value = ReadMemberArray(reader, tag, indent + inc, baseOffset);

            else if (type == Consts.SoftObjectProperty && size == 4) tag.Value = reader.ReadUInt32();
            else if (type == Consts.SoftObjectProperty) tag.Value = tag.Value.ToObject<FSoftObjectPath>().Move(transfer);
            else if (type == FBoolProperty.TYPE_NAME) tag.Value = null;
            else if (type == FByteProperty.TYPE_NAME && size == 4) tag.Value = reader.ReadUInt32();
            else if (type == FByteProperty.TYPE_NAME && size == 8) tag.Value = reader.ReadUInt64();
            else if (type == FEnumProperty.TYPE_NAME && size == 4) tag.Value = reader.ReadUInt32();
            else if (type == FEnumProperty.TYPE_NAME && size == 8) tag.Value = reader.ReadUInt64();
            else if (type == FFloatProperty.TYPE_NAME) tag.Value = reader.ReadSingle();
            else if (type == FDoubleProperty.TYPE_NAME) tag.Value = reader.ReadDouble();
            else if (type == FIntProperty.TYPE_NAME) tag.Value = reader.ReadInt32();
            else if (type == FNameProperty.TYPE_NAME) tag.Value = reader.ReadFName();
            else if (type == FObjectPropertyBase.TYPE_NAME) tag.Value = reader.ReadUInt32();
            else if (type == FStrProperty.TYPE_NAME) tag.Value = reader.ReadFString();
            else if (type == FTextProperty.TYPE_NAME) tag.Value = reader.ReadFText();
            else if (type == FUInt16Property.TYPE_NAME) tag.Value = reader.ReadUInt16();
            else if (type == FUInt32Property.TYPE_NAME && size == 4) tag.Value = reader.ReadUInt32();
            else if (type == FUInt64Property.TYPE_NAME && size == 8) tag.Value = reader.ReadUInt64();
            else if (type == FMapProperty.TYPE_NAME) tag.Value = new FMapProperty().Read(reader, name, valueType, innerType, indent + inc);
            else throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            if (startOffset != endOffset && indent == 0)
                tag.AutoCheck($"{tag.Name} {tag.Type} {tag.Size}", reader.BaseStream, [startOffset, endOffset], (writer, obj) => writer.WriterMember(tag, indent, baseOffset, tag.Value));
            else if (indent == 0 && tag.Size == 0)
                Log.InfoWrite(reader.BaseStream.Position, indent, tag, true);
            return tag.Value;
        }

        public static void WriterMember(this BinaryWriter writer, FPropertyTag tag, int indent, long baseOffset, object value)
        {
            var transfer = GlobalObjects.Transfer;
            (string name, string structName, string type, string innerType, string valueType, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.ValueType?.Value, tag.Size);
            int inc = Log.InfoWrite(writer.BaseStream.Position, indent, tag, false);

            if (type is null) throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            else if (type == FStructProperty.TYPE_NAME) WriteMemberStruct(writer, structName, value, size, indent + inc);
            else if (type == Consts.ArrayProperty) WriteMemberArray(writer, tag, value, indent + inc, baseOffset);

            else if (type == Consts.SoftObjectProperty && size == 4) writer.Write(value.ToObject<UInt32>());
            else if (type == Consts.SoftObjectProperty) value.ToObject<FSoftObjectPath>().Move(transfer);
            else if (type == FBoolProperty.TYPE_NAME) return;
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
            else if (type == FObjectPropertyBase.TYPE_NAME) writer.Write(value.ToObject<UInt32>());
            else if (type == FStrProperty.TYPE_NAME) writer.Write(value.ToObject<FString>());
            else if (type == FTextProperty.TYPE_NAME) writer.Write(value.ToObject<FText>());
            else if (type == FUInt16Property.TYPE_NAME) writer.Write(value.ToObject<UInt16>());
            else if (type == FUInt32Property.TYPE_NAME && size == 4) writer.Write(value.ToObject<UInt32>());
            else if (type == FUInt64Property.TYPE_NAME && size == 8) writer.Write(value.ToObject<UInt64>());
            else if (type == FMapProperty.TYPE_NAME) value.ToObject<FMapProperty>().Write(writer, name, valueType, innerType, indent + inc);
            else throw new InvalidOperationException($"Invalid Tag Type: '{type}'");
        }
        #endregion

        #region Tag Value Struct
        [Location("void UScriptStruct::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)")]
        private static object ReadMemberStruct(this BinaryReader reader, string structName, int size, int indent)
        {
            if (structName is { } && StructMovers.ContainsKey(structName))
                return StructMovers[structName](GlobalObjects.Transfer, size, null);
            else if (structName is { } && StructReaders.ContainsKey(structName))
                return StructReaders[structName](reader, size);
            else
                return GlobalObjects.Transfer.MoveTags(new List<object>(), indent);
        }
        private static void WriteMemberStruct(this BinaryWriter writer, string structName, object value, int size, int indent)
        {
            if (structName is { } && StructMovers.ContainsKey(structName))
                StructMovers[structName](GlobalObjects.Transfer, size, value);
            else if (structName is { } && StructWriters.ContainsKey(structName))
                StructWriters[structName](writer, size, value);
            else
                GlobalObjects.Transfer.MoveTags(value.ToObject<List<object>>(), indent);
        }
        #endregion


        #region Tag Value Array
        [Location("void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)")]
        private static object ReadMemberArray(BinaryReader reader, FPropertyTag tag, int indent, long baseOffset)
        {
            (_, string structName, _, string innerType, _, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.ValueType?.Value, tag.Size);
            int elemSize = 0;
            var list = new List<object>();
            int count = reader.ReadInt32();
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
                if (structName is { } && StructReaders.ContainsKey(structName))
                {
                    object value = reader.ReadMemberStruct(structName, size, indent);
                    list.Add(value);
                }
                else if (innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag?.Type?.Value != FStructProperty.TYPE_NAME)
                {
                    if (size > 24)
                    {
                        object members = GlobalObjects.Transfer.MoveTags(new List<object>(), indent);
                        list.Add(members);
                    }
                    else
                    {
                        object value = reader.ReadMemberStruct(Consts.Guid, size, indent);
                        list.Add(value);
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
                    object value = reader.ReadMember(elemTag, indent, baseOffset);
                    list.Add(value);
                }
            }
            if (count != list.Count)
                throw new InvalidOperationException("Empty array");
            return list;
        }
        private static void WriteMemberArray(BinaryWriter writer, FPropertyTag tag, object array, int indent, long baseOffset)
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
                if (structName is { } && StructWriters.ContainsKey(structName))
                {
                    var obj = list[i].ToObject<object>();
                    writer.WriteMemberStruct(structName, obj, size, indent);
                }
                else if (innerType == FStructProperty.TYPE_NAME && tag.MaybeInnerTag?.Type?.Value != FStructProperty.TYPE_NAME)
                {
                    if (size > 24)
                    {
                        List<object> members = list[i].ToObject<List<object>>();
                        GlobalObjects.Transfer.MoveTags(members, indent);
                    }
                    else
                    {
                        var guid = list[i].ToObject<FGuid>();
                        writer.WriteMemberStruct(Consts.Guid, guid, size, indent);
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
                    writer.WriterMember(elemTag, indent, baseOffset, list[i]);
                }
            }
        }
        #endregion
    }

    public class FPropertyTagJsonConverter : JsonConverter<FPropertyTag>
    {
        public override FPropertyTag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            FPropertyTag obj = new();
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "Name" && reader.Read() && reader.TokenType == JsonTokenType.String)
                obj.Name = new FName(reader.GetString());
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "Type" && reader.Read() && reader.TokenType == JsonTokenType.String)
                obj.Type = new FName(reader.GetString());
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "Size" && reader.Read() && reader.TokenType == JsonTokenType.Number)
                obj.Size = reader.GetInt32();
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "ArrayIndex" && reader.Read() && reader.TokenType == JsonTokenType.Number)
                obj.ArrayIndex = reader.GetInt32();
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "HasPropertyGuid" && reader.Read() && reader.TokenType == JsonTokenType.Number)
                obj.HasPropertyGuid = reader.GetByte();
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "StructName" && reader.Read() && reader.TokenType == JsonTokenType.String)
                obj.StructName = new FName(reader.GetString());
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "StructGuid" && reader.Read() && reader.TokenType == JsonTokenType.String)
                obj.StructGuid = new FGuid(reader.GetString());
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "BoolVal" && reader.Read() && reader.TokenType == JsonTokenType.Number)
                obj.BoolVal = reader.GetByte();
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "EnumName" && reader.Read() && reader.TokenType == JsonTokenType.String)
                obj.EnumName = new FName(reader.GetString());
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "InnerType" && reader.Read() && reader.TokenType == JsonTokenType.String)
                obj.InnerType = new FName(reader.GetString());
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "ValueType" && reader.Read() && reader.TokenType == JsonTokenType.String)
                obj.ValueType = new FName(reader.GetString());
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "MaybeInnerTag" && reader.Read() && reader.TokenType == JsonTokenType.StartObject)
                obj.MaybeInnerTag = JsonSerializer.Deserialize<FPropertyTag>(ref reader, options);
            reader.Read();
            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "Value" && reader.Read() && reader.TokenType != JsonTokenType.Null)
                obj.Value = JsonSerializer.Deserialize<JsonElement>(ref reader, options);

            reader.Read();
            return obj;
        }
        public override void Write(Utf8JsonWriter writer, FPropertyTag value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("Name", value.Name?.Value);
            writer.WriteString("Type", value.Type?.Value);
            writer.WriteNumber("Size", value.Size);
            writer.WriteNumber("ArrayIndex", value.ArrayIndex);
            writer.WriteNumber("HasPropertyGuid", value.HasPropertyGuid);
            writer.WriteString("StructName", value.StructName?.Value);
            writer.WriteString("StructGuid", value.StructGuid?.ToString());
            writer.WriteNumber("BoolVal", value.BoolVal);
            writer.WriteString("EnumName", value.EnumName?.Value);
            writer.WriteString("InnerType", value.InnerType?.Value);
            writer.WriteString("ValueType", value.ValueType?.Value);

            writer.WritePropertyName("MaybeInnerTag");
            if (value.MaybeInnerTag is { })
                writer.WriteRawValue(value.MaybeInnerTag.ToJson());
            else
                writer.WriteNullValue();

            writer.WritePropertyName("Value");
            if (value.Value is { })
                writer.WriteRawValue(value.Value?.ToJson());
            else
                writer.WriteNullValue();

            writer.WriteEndObject();
        }
    }
}

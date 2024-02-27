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
        public FName StructName;
        public FGuid StructGuid;
        public byte BoolVal;
        public FName EnumName;
        public FName InnerType;
        public FName ValueType;
        public FPropertyTag MaybeInnerTag;
        public object Value;
    }

    public static class FPropertyTagExt
    {
        #region List of Tags
        [Location("// Load all stored properties, potentially skipping unknown ones.")]
        public static List<object> ReadTags(this BinaryReader reader, List<object> list)
        {
            FPropertyTag tag;
            do
            {
                tag = new FPropertyTag();
                tag = reader.Read(tag);
                if (tag.Name.IsFilled)
                {
                    long endOffset = reader.BaseStream.Position + tag.Size;
                    tag.Value = reader.ReadTagValue(tag.Name.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size, ref tag.MaybeInnerTag);
                    if (reader.BaseStream.Position != endOffset)
                    {
                        Log.Info($"Read Failed. Expected Offset {endOffset} but was {reader.BaseStream.Position}");
                        throw new InvalidOperationException();
                    }
                }
                list.Add(DerivedTag(tag));
            }
            while (tag.Name.IsFilled);
            return list;
        }
        public static void WriteTags(this BinaryWriter writer, List<object> list)
        {
            foreach (object item in list)
            {
                FPropertyTag tag = BaseTag(item);
                ArgumentNullException.ThrowIfNull(tag.Name);
                writer.Write(tag);
                if (tag.Name.IsFilled)
                {
                    writer.WriteTagValue(tag.Name.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size, tag.Value, tag.MaybeInnerTag);
                }
            }
        }
        #endregion

        #region Tag Header - void operator<<(FStructuredArchive::FSlot Slot, FPropertyTag& Tag)
        [Location("void operator<<(FStructuredArchive::FSlot Slot, FPropertyTag& Tag)")]
        public static FPropertyTag Read(this BinaryReader reader, FPropertyTag tag)
        {
            reader.Read(ref tag.Name);
            if (tag.Name.IsFilled)
            {
                reader.Read(ref tag.Type);
                reader.Read(ref tag.Size);
                reader.Read(ref tag.ArrayIndex);
                if (tag.Type.Number == 0)
                {
                    if (tag.Type.Value == FStructProperty.TYPE_NAME)
                    {
                        reader.Read(ref tag.StructName);
                        if (Supports.VER_UE4_STRUCT_GUID_IN_PROPERTY_TAG)
                            reader.Read(ref tag.StructGuid);
                    }
                    else if (tag.Type.Value == FBoolProperty.TYPE_NAME)
                    {
                        reader.Read(ref tag.BoolVal);
                    }
                    else if (tag.Type.Value == FByteProperty.TYPE_NAME)
                    {
                        reader.Read(ref tag.EnumName);
                    }
                    else if (tag.Type.Value == FEnumProperty.TYPE_NAME)
                    {
                        reader.Read(ref tag.EnumName);
                    }
                    else if (tag.Type.Value == Consts.ArrayProperty && Supports.VAR_UE4_ARRAY_PROPERTY_INNER_TAGS)
                    {
                        reader.Read(ref tag.InnerType);
                    }
                    else if (tag.Type.Value == Consts.OptionalProperty)
                    {
                        reader.Read(ref tag.InnerType);
                    }
                    else if (tag.Type.Value == Consts.SetProperty && Supports.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT)
                    {
                        reader.Read(ref tag.InnerType);
                    }
                    else if (tag.Type.Value == Consts.MapProperty && Supports.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT)
                    {
                        reader.Read(ref tag.InnerType);
                        reader.Read(ref tag.ValueType);
                    }
                }
                reader.Read(ref tag.HasPropertyGuid);
            }
            return tag;
        }

        private static object DerivedTag(FPropertyTag tag)
        {
            if (tag?.Type?.Value == FBoolProperty.TYPE_NAME) return new FBoolPropertyJson(tag);
            else if (tag?.Type?.Value == FStrProperty.TYPE_NAME) return new FStrPropertyJson(tag);
            else if (tag?.Type?.Value == FNameProperty.TYPE_NAME) return new FNamePropertyJson(tag);
            else if (tag?.Type?.Value == FIntProperty.TYPE_NAME) return new FIntPropertyJson(tag);
            else if (tag?.Type?.Value == FUInt32Property.TYPE_NAME) return new FUIntPropertyJson(tag);
            else if (tag?.Type?.Value == FObjectPropertyBase.TYPE_NAME) return new FObjectPropertyBaseJson(tag);
            else if (tag?.Type?.Value == FEnumProperty.TYPE_NAME && tag.Size == 4) return new FEnum32PropertyJson(tag);
            else if (tag?.Type?.Value == FByteProperty.TYPE_NAME && tag.Size == 4) return new FByte32PropertyJson(tag);
            else if (tag?.Type?.Value == Consts.SoftObjectProperty) return new SoftObjectPropertyJson(tag);
            else if (tag?.Type?.Value == FFloatProperty.TYPE_NAME) return new FFloatPropertyJson(tag);
            else if (tag?.Type?.Value == FStructProperty.TYPE_NAME && tag.StructName?.Value == Consts.Guid) return new FGuidPropertyJson(tag);
            else return tag;
        }

        private static FPropertyTag BaseTag(object item)
        {
            if (item is JsonElement elem)
            {
                List<string> v = elem.EnumerateObject().First().Name.Split(' ').Concat(elem.EnumerateObject().First().Value.ToString().Split(' ')).ToList();
                if (v.Count == 2) v.Insert(0, null);
                if (v.Count == 3 || v[0] == "string") v.Insert(1, null);
                if (v.Count > 4) v[3] = string.Join(' ', v.Skip(3));
                (string type, string enumName, string name, string value) = (v[0], v[1], v[2], v[3]);

                if (type == "bool") return new FPropertyTag { Name = new FName(name), Type = new FName(FBoolProperty.TYPE_NAME), BoolVal = bool.Parse(value) ? (byte)1 : (byte)0 };
                else if (type == "string") return new FPropertyTag { Name = new FName(name), Type = new FName(FStrProperty.TYPE_NAME), Value = new FString(value), Size = value.SerializedSize() };
                else if (type == "name") return new FPropertyTag { Name = new FName(name), Type = new FName(FNameProperty.TYPE_NAME), Value = new FName(value), Size = 8 };
                else if (type == "int") return new FPropertyTag { Name = new FName(name), Type = new FName(FIntProperty.TYPE_NAME), Value = Int32.Parse(value), Size = 4 };
                else if (type == "uint") return new FPropertyTag { Name = new FName(name), Type = new FName(FUInt32Property.TYPE_NAME), Value = UInt32.Parse(value), Size = 4 };
                else if (type == "obj") return new FPropertyTag { Name = new FName(name), Type = new FName(FObjectPropertyBase.TYPE_NAME), Value = UInt32.Parse(value), Size = 4 };
                else if (type == "enum32") return new FPropertyTag { EnumName = new FName(enumName), Name = new FName(name), Type = new FName(FEnumProperty.TYPE_NAME), Value = UInt32.Parse(value), Size = 4 };
                else if (type == "enum64") return new FPropertyTag { EnumName = new FName(enumName), Name = new FName(name), Type = new FName(FEnumProperty.TYPE_NAME), Value = UInt64.Parse(value), Size = 8 };
                else if (type == "byte32") return new FPropertyTag { EnumName = new FName(enumName), Name = new FName(name), Type = new FName(FByteProperty.TYPE_NAME), Value = UInt32.Parse(value), Size = 4 };
                else if (type == "byte64") return new FPropertyTag { EnumName = new FName(enumName), Name = new FName(name), Type = new FName(FByteProperty.TYPE_NAME), Value = UInt64.Parse(value), Size = 8 };
                else if (type == "soft") return new FPropertyTag { Name = new FName(name), Type = new FName(Consts.SoftObjectProperty), Value = UInt32.Parse(value), Size = 4 };
                else if (type == "float") return new FPropertyTag { Name = new FName(name), Type = new FName(FFloatProperty.TYPE_NAME), Value = float.Parse(value), Size = 4 };
                else if (type == "guid") return new FPropertyTag { Name = new FName(name), Type = new FName(FStructProperty.TYPE_NAME), Value = new FGuid(value), Size = 16, StructName = new FName(Consts.Guid) };
            }
            else if (item is IPropertytag propertytag) return propertytag.GetNative();
            return item.ToObject<FPropertyTag>();
        }

        public static void Write(this BinaryWriter writer, FPropertyTag tag)
        {
            writer.Write(tag.Name);
            if (tag.Name.IsFilled)
            {
                writer.Write(tag.Type);
                writer.Write(tag.Size);
                writer.Write(tag.ArrayIndex);
                if (tag.Type.Number == 0)
                {
                    if (tag.Type.Value == FStructProperty.TYPE_NAME)
                    {
                        writer.Write(tag.StructName);
                        if (Supports.VER_UE4_STRUCT_GUID_IN_PROPERTY_TAG)
                            writer.Write(tag.StructGuid);
                    }
                    else if (tag.Type.Value == FBoolProperty.TYPE_NAME)
                    {
                        writer.Write(tag.BoolVal);
                    }
                    else if (tag.Type.Value == FByteProperty.TYPE_NAME)
                    {
                        writer.Write(tag.EnumName);
                    }
                    else if (tag.Type.Value == FEnumProperty.TYPE_NAME)
                    {
                        writer.Write(tag.EnumName);
                    }
                    else if (tag.Type.Value == Consts.ArrayProperty && Supports.VAR_UE4_ARRAY_PROPERTY_INNER_TAGS)
                    {
                        writer.Write(tag.InnerType);
                    }
                    else if (tag.Type.Value == Consts.OptionalProperty)
                    {
                        writer.Write(tag.InnerType);
                    }
                    else if (tag.Type.Value == Consts.SetProperty && Supports.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT)
                    {
                        writer.Write(tag.InnerType);
                    }
                    else if (tag.Type.Value == Consts.MapProperty && Supports.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT)
                    {
                        writer.Write(tag.InnerType);
                        writer.Write(tag.ValueType);
                    }
                }
                writer.Write(tag.HasPropertyGuid);
            }
        }
        #endregion

        #region Tag Value Single
        [Location("void FPropertyTag::SerializeTaggedProperty(FStructuredArchive::FSlot Slot, FProperty* Property, uint8* Value, const uint8* Defaults) const")]
        public static object ReadTagValue(this BinaryReader reader, string name, string structName, string type, string innerType, int size, ref FPropertyTag innerTag)
        {
            if (type == FStructProperty.TYPE_NAME) return ReadTagValueStruct(reader, structName);
            else if (type == Consts.ArrayProperty) return ReadTagValueArray(reader, name, structName, innerType, size, ref innerTag);
            else if (type == FStrProperty.TYPE_NAME) return reader.ReadFString();
            else if (type == FNameProperty.TYPE_NAME) return reader.ReadFName();
            else if (type == FTextProperty.TYPE_NAME) return reader.ReadFText();
            else if (type == FIntProperty.TYPE_NAME) return reader.ReadInt32();
            else if (type == FUInt32Property.TYPE_NAME) return reader.ReadUInt32();
            else if (type == FObjectPropertyBase.TYPE_NAME) return reader.ReadUInt32();
            else if (type == FEnumProperty.TYPE_NAME && size == 4) return reader.ReadUInt32();
            else if (type == FByteProperty.TYPE_NAME && size == 4) return reader.ReadUInt32();
            else if (type == FEnumProperty.TYPE_NAME && size == 8) return reader.ReadUInt64();
            else if (type == FByteProperty.TYPE_NAME && size == 8) return reader.ReadUInt64();
            else if (type == Consts.SoftObjectProperty) return reader.ReadUInt32();
            else if (type == FFloatProperty.TYPE_NAME) return reader.ReadSingle();
            else return null;
        }
        public static void WriteTagValue(this BinaryWriter writer, string name, string structName, string type, string innerType, int size, object value, FPropertyTag innerTag)
        {
            if (type == FStructProperty.TYPE_NAME) WriteTagValueStruct(writer, structName, value);
            else if (type == Consts.ArrayProperty) WriteTagValueArray(writer, name, structName, innerType, size, value, innerTag);
            else if (type == FStrProperty.TYPE_NAME) writer.Write(value.ToObject<FString>());
            else if (type == FNameProperty.TYPE_NAME) writer.Write(value.ToObject<FName>());
            else if (type == FTextProperty.TYPE_NAME) writer.Write(value.ToObject<FText>());
            else if (type == FIntProperty.TYPE_NAME) writer.Write(value.ToObject<Int32>());
            else if (type == FUInt32Property.TYPE_NAME) writer.Write(value.ToObject<UInt32>());
            else if (type == FObjectPropertyBase.TYPE_NAME) writer.Write(value.ToObject<UInt32>());
            else if (type == FEnumProperty.TYPE_NAME && size == 4) writer.Write(value.ToObject<UInt32>());
            else if (type == FByteProperty.TYPE_NAME && size == 4) writer.Write(value.ToObject<UInt32>());
            else if (type == FEnumProperty.TYPE_NAME && size == 8) writer.Write(value.ToObject<UInt64>());
            else if (type == FByteProperty.TYPE_NAME && size == 8) writer.Write(value.ToObject<UInt64>());
            else if (type == Consts.SoftObjectProperty) writer.Write(value.ToObject<UInt32>());
            else if (type == FFloatProperty.TYPE_NAME) writer.Write(value.ToObject<float>());
        }
        #endregion

        #region Tag Value Struct
        [Location("void UScriptStruct::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)")]
        private static object ReadTagValueStruct(this BinaryReader reader, string structName)
        {
            if (structName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count == 0) return reader.ReadValue(new FSoftObjectPath(), null);
            else if (structName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count > 0) return reader.ReadInt32().ToString();
            else if (structName == FVector2D.StructName) return new FVector2D(reader);
            else if (structName == FVector.StructName) return new FVector(reader);
            else if (structName == Consts.Guid) return reader.ReadFGuid();
            else if (structName == FPointerToUberGraphFrame.StructName) return new FPointerToUberGraphFrame(reader);
            else if (structName == FRotator.StructName) return new FRotator(reader);
            else if (structName == FLinearColor.StructName) return new FLinearColor(reader);
            else if (structName == FRichCurveKey.StructName) return new FRichCurveKey(reader);
            else return reader.ReadTags(new List<object>());
        }
        private static void WriteTagValueStruct(BinaryWriter writer, string structName, object value)
        {
            if (structName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count == 0) writer.WriteValue(value.ToObject<FSoftObjectPath>(), null);
            else if (structName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count > 0) writer.Write(int.Parse(value.ToString()));
            else if (structName == FVector2D.StructName) (value.ToObject<FVector2D>()).Write(writer);
            else if (structName == FVector.StructName) (value.ToObject<FVector>()).Write(writer);
            else if (structName == Consts.Guid) writer.WriteValue(new FGuid(value.ToString()), null);
            else if (structName == FPointerToUberGraphFrame.StructName) (value.ToObject<FPointerToUberGraphFrame>()).Write(writer);
            else if (structName == FRotator.StructName) (value.ToObject<FRotator>()).Write(writer);
            else if (structName == FLinearColor.StructName) (value.ToObject<FLinearColor>()).Write(writer);
            else if (structName == FRichCurveKey.StructName) (value.ToObject<FRichCurveKey>()).Write(writer);
            else writer.WriteTags(value.ToObject<List<object>>());
        }
        #endregion

        #region Tag Value Array
        [Location("void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const\")]")]
        private static object ReadTagValueArray(BinaryReader reader, string name, string structName, string innerType, int size, ref FPropertyTag innerTag)
        {
            if (innerType == FStructProperty.TYPE_NAME)
            {
                int count = reader.ReadInt32();
                innerTag = reader.Read(new FPropertyTag());
                if (innerTag.StructName?.Value == FRichCurveKey.StructName)
                {
                    var list = new List<object>();
                    for (int i = 0; i < count; i++)
                    {
                        FPropertyTag innerTagItem = null;
                        object value = reader.ReadTagValue(innerTag.Name.Value, innerTag.StructName?.Value, innerType, innerTag.InnerType?.Value, innerTag.Size, ref innerTagItem);
                        if (innerTagItem is { })
                        {
                            (value as FPropertyTag).MaybeInnerTag = innerTagItem;
                        }
                        list.Add(value);
                    }
                    return list;
                }
                else
                {
                    var list = new List<List<object>>();
                    list.Resize(count);
                    list.ForEach(x => reader.ReadTags(x));
                    return list;
                }
            }
            else
            {
                var list = new List<object>();
                int count = reader.ReadInt32();
                for (int i = 0; i < count; i++)
                {
                    FPropertyTag innerTagItem = null;
                    object value = reader.ReadTagValue(name, structName, innerType, null, size, ref innerTagItem);
                    if (innerTagItem is { })
                    {
                        (value as FPropertyTag).MaybeInnerTag = innerTagItem;
                    }
                    list.Add(value);
                }
                return list;
            }
        }
        private static void WriteTagValueArray(BinaryWriter writer, string name, string structName, string innerType, int size, object value, FPropertyTag innerTag)
        {
            if (innerType == FStructProperty.TYPE_NAME)
            {
                if (innerTag?.StructName?.Value == FRichCurveKey.StructName)
                {
                    var list = value.ToObject<List<object>>();
                    writer.Write(list.Count);
                    writer.Write(innerTag);
                    for (int i = 0; i < list.Count; i++)
                    {
                        writer.WriteTagValue(innerTag.Name.Value, innerTag.StructName?.Value, innerType, innerTag.InnerType?.Value, innerTag.Size, list[i], innerTag);
                    }
                }
                else
                {
                    var list = value.ToObject<List<List<object>>>();
                    writer.Write(list.Count);
                    writer.Write(innerTag);
                    list.ForEach(writer.WriteTags);
                }
            }
            else
            {
                var list = value.ToObject<List<object>>();
                writer.Write(list.Count);
                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteTagValue(name, structName, innerType, null, size, list[i], null);
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

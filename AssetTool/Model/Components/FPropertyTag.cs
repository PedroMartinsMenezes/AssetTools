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
    }

    public static class FPropertyTagExt
    {
        #region List of Tags
        [Location("void UStruct::SerializeVersionedTaggedProperties")]
        public static List<object> ReadTags(this BinaryReader reader, List<object> list)
        {
            FPropertyTag tag;
            do
            {
                tag = new FPropertyTag();
                tag = reader.Read(tag);
                if (tag.Name.IsFilled)
                {
                    long startOffset = reader.BaseStream.Position;
                    long endOffset = reader.BaseStream.Position + tag.Size;

                    tag.Value = reader.ReadMember(tag.Name.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size, ref tag.MaybeInnerTag);

                    tag.AutoCheck($"[{list.Count}] {tag.Name} {tag.Type} {tag.Size}", reader.BaseStream, [startOffset, endOffset], (writer, obj) => writer.WriterMember(tag.Name.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size, tag.Value, tag.MaybeInnerTag));

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
                    writer.WriterMember(tag.Name.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size, tag.Value, tag.MaybeInnerTag);
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

                    else if (tag.Type.Value == Consts.SetProperty && Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT))
                    {
                        reader.Read(ref tag.InnerType);
                    }
                    else if (tag.Type.Value == Consts.MapProperty && Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT))
                    {
                        reader.Read(ref tag.InnerType);
                        reader.Read(ref tag.ValueType);
                    }
                }
                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG))
                {
                    reader.Read(ref tag.HasPropertyGuid);
                    if (tag.HasPropertyGuid == 1)
                    {
                        reader.Read(ref tag.PropertyGuid);
                    }
                }
            }
            return tag;
        }

        private static object DerivedTag(FPropertyTag tag)
        {
            if (tag is null || tag.Type is null) return tag;
            else if (tag.Type.Value == Consts.SoftObjectProperty && tag.Size == 4) return new SoftObjectPropertyJson(tag);
            else if (tag.Type.Value == FBoolProperty.TYPE_NAME) return new FBoolPropertyJson(tag);
            else if (tag.Type.Value == FByteProperty.TYPE_NAME && tag.Size == 4) return new FByte32PropertyJson(tag);
            else if (tag.Type.Value == FByteProperty.TYPE_NAME && tag.Size == 8) return new FByte64PropertyJson(tag);
            else if (tag.Type.Value == FEnumProperty.TYPE_NAME && tag.Size == 4) return new FEnum32PropertyJson(tag);
            else if (tag.Type.Value == FEnumProperty.TYPE_NAME && tag.Size == 8) return new FEnum64PropertyJson(tag);
            else if (tag.Type.Value == FFloatProperty.TYPE_NAME) return new FFloatPropertyJson(tag);
            else if (tag.Type.Value == FIntProperty.TYPE_NAME) return new FIntPropertyJson(tag);
            else if (tag.Type.Value == FNameProperty.TYPE_NAME) return new FNamePropertyJson(tag);
            else if (tag.Type.Value == FObjectPropertyBase.TYPE_NAME) return new FObjectPropertyBaseJson(tag);
            else if (tag.Type.Value == FStrProperty.TYPE_NAME) return new FStrPropertyJson(tag);
            else if (tag.Type.Value == FStructProperty.TYPE_NAME && tag.StructName?.Value == Consts.Guid) return new FGuidPropertyJson(tag);
            else if (tag.Type.Value == FUInt32Property.TYPE_NAME) return new FUIntPropertyJson(tag);
            else return tag;
        }

        private static FPropertyTag BaseTag(object item)
        {
            if (item is JsonElement elem)
            {
                string[] v = elem.EnumerateObject().First().Name.Split(' ').Concat(elem.EnumerateObject().First().Value.ToString().Split(' ')).ToArray();
                string type = v[0];

                if (type == "bool") return FBoolPropertyJson.GetNative(v);
                else if (type == "string") return FStrPropertyJson.GetNative(v);
                else if (type == "name") return FNamePropertyJson.GetNative(v);
                else if (type == "int") return FIntPropertyJson.GetNative(v);
                else if (type == "uint") return FUIntPropertyJson.GetNative(v);
                else if (type == "obj") return FObjectPropertyBaseJson.GetNative(v);
                else if (type == "enum32") return FEnum32PropertyJson.GetNative(v);
                else if (type == "enum64") return FEnum64PropertyJson.GetNative(v);
                else if (type == "byte32") return FByte32PropertyJson.GetNative(v);
                else if (type == "byte64") return FByte64PropertyJson.GetNative(v);
                else if (type == "soft") return SoftObjectPropertyJson.GetNative(v);
                else if (type == "float") return FFloatPropertyJson.GetNative(v);
                else if (type == "guid") return FGuidPropertyJson.GetNative(v);
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
                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG))
                {
                    writer.Write(tag.HasPropertyGuid);
                    if (tag.HasPropertyGuid == 1)
                    {
                        writer.Write(tag.PropertyGuid);
                    }
                }
            }
        }
        #endregion

        #region Tag Value Single
        [Location("void FPropertyTag::SerializeTaggedProperty(FStructuredArchive::FSlot Slot, FProperty* Property, uint8* Value, const uint8* Defaults) const")]
        public static object ReadMember(this BinaryReader reader, string name, string structName, string type, string innerType, int size, ref FPropertyTag innerTag)
        {
            if (type is null) throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            else if (type == FStructProperty.TYPE_NAME) return ReadMemberStruct(reader, structName, size);
            else if (type == Consts.ArrayProperty) return ReadMemberArray(reader, name, structName, innerType, size, ref innerTag);

            else if (type == Consts.SoftObjectProperty && size == 4) return reader.ReadUInt32();
            else if (type == Consts.SoftObjectProperty) return new FSoftObjectPath().Read(reader);
            else if (type == FBoolProperty.TYPE_NAME) return null;
            else if (type == FByteProperty.TYPE_NAME && size == 4) return reader.ReadUInt32();
            else if (type == FByteProperty.TYPE_NAME && size == 8) return reader.ReadUInt64();
            else if (type == FEnumProperty.TYPE_NAME && size == 4) return reader.ReadUInt32();
            else if (type == FEnumProperty.TYPE_NAME && size == 8) return reader.ReadUInt64();
            else if (type == FFloatProperty.TYPE_NAME) return reader.ReadSingle();
            else if (type == FIntProperty.TYPE_NAME) return reader.ReadInt32();
            else if (type == FNameProperty.TYPE_NAME) return reader.ReadFName();
            else if (type == FObjectPropertyBase.TYPE_NAME) return reader.ReadUInt32();
            else if (type == FStrProperty.TYPE_NAME) return reader.ReadFString();
            else if (type == FTextProperty.TYPE_NAME) return reader.ReadFText();
            else if (type == FUInt16Property.TYPE_NAME) return reader.ReadUInt16();
            else if (type == FUInt32Property.TYPE_NAME) return reader.ReadUInt32();
            else throw new InvalidOperationException($"Invalid Tag Type: '{type}'");
        }

        public static void WriterMember(this BinaryWriter writer, string name, string structName, string type, string innerType, int size, object value, FPropertyTag innerTag)
        {
            if (type is null) throw new InvalidOperationException($"Invalid Tag Type: '{type}'");

            else if (type == FStructProperty.TYPE_NAME) WriteMemberStruct(writer, structName, value, size);
            else if (type == Consts.ArrayProperty) WriteMemberArray(writer, name, structName, innerType, value, innerTag);

            else if (type == Consts.SoftObjectProperty && size == 4) writer.Write(value.ToObject<UInt32>());
            else if (type == Consts.SoftObjectProperty) value.ToObject<FSoftObjectPath>().Write(writer);
            else if (type == FBoolProperty.TYPE_NAME) return;
            else if (type == FByteProperty.TYPE_NAME && size == 4) writer.Write(value.ToObject<UInt32>());
            else if (type == FByteProperty.TYPE_NAME && size == 8) writer.Write(value.ToObject<UInt64>());
            else if (type == FEnumProperty.TYPE_NAME && size == 4) writer.Write(value.ToObject<UInt32>());
            else if (type == FEnumProperty.TYPE_NAME && size == 8) writer.Write(value.ToObject<UInt64>());
            else if (type == FFloatProperty.TYPE_NAME) writer.Write(value.ToObject<float>());
            else if (type == FInt8Property.TYPE_NAME) writer.Write(value.ToObject<sbyte>());
            else if (type == FInt16Property.TYPE_NAME) writer.Write(value.ToObject<Int16>());
            else if (type == FIntProperty.TYPE_NAME) writer.Write(value.ToObject<Int32>());
            else if (type == FInt64Property.TYPE_NAME) writer.Write(value.ToObject<Int64>());
            else if (type == FNameProperty.TYPE_NAME) writer.Write(value.ToObject<FName>());
            else if (type == FObjectPropertyBase.TYPE_NAME) writer.Write(value.ToObject<UInt32>());
            else if (type == FStrProperty.TYPE_NAME) writer.Write(value.ToObject<FString>());
            else if (type == FTextProperty.TYPE_NAME) writer.Write(value.ToObject<FText>());
            else if (type == FUInt16Property.TYPE_NAME) writer.Write(value.ToObject<UInt16>());
            else if (type == FUInt32Property.TYPE_NAME) writer.Write(value.ToObject<UInt32>());
            else if (type == FUInt64Property.TYPE_NAME) writer.Write(value.ToObject<UInt64>());
            else throw new InvalidOperationException($"Invalid Tag Type: '{type}'");
        }
        #endregion

        #region Tag Value Struct
        [Location("void UScriptStruct::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)")]
        private static object ReadMemberStruct(this BinaryReader reader, string structName, int size)
        {
            if (structName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count == 0) return new FSoftObjectPath().Read(reader);
            else if (structName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count > 0) return reader.ReadInt32().ToString();
            else if (structName == FVector2f.StructName && size == FVector2f.SIZE) return new FVector2f(reader);
            else if (structName == FVector2D.StructName && size == FVector2D.SIZE) return new FVector2D(reader);
            else if (structName == FVector3f.StructName && size == FVector3f.SIZE) return new FVector3f(reader);
            else if (structName == FVector3d.StructName && size == FVector3d.SIZE) return new FVector3d(reader);
            else if (structName == Consts.Guid) return reader.ReadFGuid();
            else if (structName == FPointerToUberGraphFrame.StructName) return new FPointerToUberGraphFrame(reader);
            else if (structName == FRotator.StructName) return new FRotator(reader);
            else if (structName == FLinearColor.StructName) return new FLinearColor(reader);
            else if (structName == FRichCurveKey.StructName) return new FRichCurveKey(reader);
            else if (structName == FColorMaterialInput.StructName) return new FColorMaterialInput(reader);
            else if (structName == FExpressionInput.StructName) return new FExpressionInput(reader);
            else if (structName == FEdGraphPinType.StructName) return new FEdGraphPinType().Read(reader);
            else return reader.ReadTags(new List<object>());
        }
        private static void WriteMemberStruct(BinaryWriter writer, string structName, object value, int size)
        {
            if (structName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count == 0) value.ToObject<FSoftObjectPath>().Write(writer);
            else if (structName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count > 0) writer.Write(int.Parse(value.ToString()));
            else if (structName == FVector2f.StructName && size == FVector2f.SIZE) (value.ToObject<FVector2f>()).Write(writer);
            else if (structName == FVector2D.StructName && size == FVector2D.SIZE) (value.ToObject<FVector2D>()).Write(writer);
            else if (structName == FVector3f.StructName && size == FVector3f.SIZE) (value.ToObject<FVector3f>()).Write(writer);
            else if (structName == FVector3d.StructName && size == FVector3d.SIZE) (value.ToObject<FVector3d>()).Write(writer);
            else if (structName == Consts.Guid) writer.WriteFGuid(value);
            else if (structName == FPointerToUberGraphFrame.StructName) (value.ToObject<FPointerToUberGraphFrame>()).Write(writer);
            else if (structName == FRotator.StructName) (value.ToObject<FRotator>()).Write(writer);
            else if (structName == FLinearColor.StructName) (value.ToObject<FLinearColor>()).Write(writer);
            else if (structName == FRichCurveKey.StructName) (value.ToObject<FRichCurveKey>()).Write(writer);
            else if (structName == FColorMaterialInput.StructName) (value.ToObject<FColorMaterialInput>()).Write(writer);
            else if (structName == FExpressionInput.StructName) (value.ToObject<FExpressionInput>()).Write(writer);
            else if (structName == FEdGraphPinType.StructName) (value.ToObject<FEdGraphPinType>()).Write(writer);
            else writer.WriteTags(value.ToObject<List<object>>());
        }
        #endregion

        #region Tag Value Array
        [Location("void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)")]
        private static object ReadMemberArray(BinaryReader reader, string name, string structName, string innerType, int size, ref FPropertyTag innerTag)
        {
            var list = new List<object>();
            int count = reader.ReadInt32();
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_INNER_ARRAY_TAG_INFO) && innerType == FStructProperty.TYPE_NAME && innerTag is null)
            {
                innerTag = reader.Read(new FPropertyTag());
                if (innerTag.Type.Value == FStructProperty.TYPE_NAME)
                    structName = innerTag.StructName.Value;
            }
            for (int i = 0; i < count; i++)
            {
                if (innerType == FStructProperty.TYPE_NAME && innerTag?.Type?.Value != FStructProperty.TYPE_NAME)
                {
                    object members = reader.ReadTags(new List<object>());
                    list.Add(members);
                }
                else
                {
                    FPropertyTag innerTagItem = null;
                    object value = reader.ReadMember(name, structName, innerType, null, 0, ref innerTagItem);
                    list.Add(value);
                }
            }
            return list;

        }
        private static void WriteMemberArray(BinaryWriter writer, string name, string structName, string innerType, object array, FPropertyTag innerTag)
        {
            var list = array.ToObject<List<object>>();
            writer.Write(list.Count);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_INNER_ARRAY_TAG_INFO) && innerType == FStructProperty.TYPE_NAME && innerTag is { })
            {
                writer.Write(innerTag);
                if (innerTag.Type.Value == FStructProperty.TYPE_NAME)
                    structName = innerTag.StructName.Value;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (innerType == FStructProperty.TYPE_NAME && innerTag?.Type.Value != FStructProperty.TYPE_NAME)
                {
                    List<object> members = list[i].ToObject<List<object>>();
                    writer.WriteTags(members);
                }
                else
                {
                    writer.WriterMember(name, structName, innerType, null, 0, list[i], null);
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

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FPropertyTag& Tag)")]
    public class FPropertyTag
    {
        [Location("Slot << SA_ATTRIBUTE(TEXT(\"Name\"), Tag.Name);")]
        public FName Name;

        [Location("Slot << SA_ATTRIBUTE(TEXT(\"Type\"), Tag.Type);")]
        public FName Type;

        [Location("Slot << SA_ATTRIBUTE(TEXT(\"Size\"), Tag.Size);")]
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
        public static List<FPropertyTag> ReadTags(this BinaryReader reader, List<FPropertyTag> list)
        {
            FPropertyTag tag;
            // Load all stored properties, potentially skipping unknown ones.
            do
            {
                tag = new FPropertyTag();
                list.Add(reader.Read(tag));
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
            }
            while (tag.Name.IsFilled);
            return list;
        }

        public static void WriteTags(this BinaryWriter writer, List<FPropertyTag> list)
        {
            foreach (FPropertyTag tag in list)
            {
                writer.Write(tag);
                if (tag.Name.IsFilled && tag.Value is { })
                {
                    writer.WriteTagValue(tag.Name.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size, tag.Value, tag.MaybeInnerTag);
                }
            }
        }
        #endregion

        #region Tag Header Data
        public static FPropertyTag Read(this BinaryReader reader, FPropertyTag tag)
        {
            reader.Read(ref tag.Name);
            if (tag.Name.IsFilled)
            {
                reader.Read(ref tag.Type);
                reader.Read(ref tag.Size);
                reader.Read(ref tag.ArrayIndex);
                reader.ReadExtra(tag);
                reader.Read(ref tag.HasPropertyGuid);
            }
            return tag;
        }

        public static void Write(this BinaryWriter writer, FPropertyTag tag)
        {
            writer.Write(tag.Name);
            if (tag.Name.IsFilled)
            {
                writer.Write(tag.Type);
                writer.Write(tag.Size);
                writer.Write(tag.ArrayIndex);
                writer.WriteExtra(tag);
                writer.Write(tag.HasPropertyGuid);
            }
        }
        #endregion

        #region Tag Extra Header Data
        public static FPropertyTag ReadExtra(this BinaryReader reader, FPropertyTag tag)
        {
            if (tag.Type.Number == 0)
            {
                if (tag.Type.Value == FStructProperty.TYPE_NAME)
                {
                    reader.Read(ref tag.StructName);
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
                else if (tag.Type.Value == Consts.ArrayProperty)
                {
                    reader.Read(ref tag.InnerType);
                }
                else if (tag.Type.Value == Consts.OptionalProperty)
                {
                    reader.Read(ref tag.InnerType);
                }
                else if (tag.Type.Value == Consts.SetProperty)
                {
                    reader.Read(ref tag.InnerType);
                }
                else if (tag.Type.Value == Consts.MapProperty)
                {
                    reader.Read(ref tag.InnerType);
                    reader.Read(ref tag.ValueType);
                }
            }
            return tag;
        }

        public static void WriteExtra(this BinaryWriter writer, FPropertyTag item)
        {
            if (item.Type.Number == 0)
            {
                if (item.Type.Value == FStructProperty.TYPE_NAME)
                {
                    writer.Write(item.StructName);
                    writer.Write(item.StructGuid);
                }
                else if (item.Type.Value == FBoolProperty.TYPE_NAME)
                {
                    writer.Write(item.BoolVal);
                }
                else if (item.Type.Value == FByteProperty.TYPE_NAME)
                {
                    writer.Write(item.EnumName);
                }
                else if (item.Type.Value == FEnumProperty.TYPE_NAME)
                {
                    writer.Write(item.EnumName);
                }
                else if (item.Type.Value == Consts.ArrayProperty)
                {
                    writer.Write(item.InnerType);
                }
                else if (item.Type.Value == Consts.OptionalProperty)
                {
                    writer.Write(item.InnerType);
                }
                else if (item.Type.Value == Consts.SetProperty)
                {
                    writer.Write(item.InnerType);
                }
                else if (item.Type.Value == Consts.MapProperty)
                {
                    writer.Write(item.InnerType);
                    writer.Write(item.ValueType);
                }
            }
        }
        #endregion

        #region Tag Body Data

        #region void FPropertyTag::SerializeTaggedProperty(FStructuredArchive::FSlot Slot, FProperty* Property, uint8* Value, const uint8* Defaults) const
        public static object ReadTagValue(this BinaryReader reader, string name, string structName, string type, string innerType, int size, ref FPropertyTag innerTag)
        {
            //check Name
            if (name is Consts.Guid or Consts.VarGuid) return reader.ReadFGuid();
            else if (name == Consts.PinValueType) return reader.ReadTags(new List<FPropertyTag>());
            //check Type
            else if (type == FStructProperty.TYPE_NAME) return ReadTagValueStruct(reader, structName);
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
            //check Name
            if (name is Consts.Guid or Consts.VarGuid) writer.Write(value.ToObject<FGuid>());
            else if (name == Consts.PinValueType) writer.WriteTags(value.ToObject<List<FPropertyTag>>());
            //check Type
            else if (type == FStructProperty.TYPE_NAME) WriteTagValueStruct(writer, structName, value);
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

        #region void UScriptStruct::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)
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
            else return reader.ReadTags(new List<FPropertyTag>());
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
            else writer.WriteTags(value.ToObject<List<FPropertyTag>>());
        }
        #endregion

        #region void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
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
                    var list = new List<List<FPropertyTag>>();
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
                    var list = value.ToObject<List<List<FPropertyTag>>>();
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

        #endregion
    }


    public class FPropertyTagJsonConverter : JsonConverter<FPropertyTag>
    {
        public override FPropertyTag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FPropertyTag();
        }
        public override void Write(Utf8JsonWriter writer, FPropertyTag value, JsonSerializerOptions options)
        {
            if (value.Name.Value == Consts.None)
            {
                writer.WriteString("Name", "None");
            }
            else if (value.Name.Value is Consts.Guid or Consts.VarGuid)
            {
                writer.WriteStartObject();
                writer.WriteString("Type", "Guid");
                writer.WriteString("Value", value.Value.ToJson());
                writer.WriteEndObject();
            }
        }
    }
}

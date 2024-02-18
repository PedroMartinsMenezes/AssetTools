namespace AssetTool
{
    public class PropertyValue
    {
        #region JsonIgnore
        public string Name;
        public string StructName;
        public string Type;
        public string InnerType;
        public int Size;
        #endregion

        public object Value_Struct;
        public FPropertyTag MaybeInnerTag;

        public void UpdateFrom(FPropertyTag other)
        {
            Name = other.Name.Value;
            StructName = other.StructName?.Value;
            Type = other.Type.Value;
            InnerType = other.InnerType?.Value;
            Size = other.Size;
        }
    }

    public static class PropertyValueExt
    {
        #region void FPropertyTag::SerializeTaggedProperty(FStructuredArchive::FSlot Slot, FProperty* Property, uint8* Value, const uint8* Defaults) const
        public static PropertyValue ReadTagValue(this BinaryReader reader, PropertyValue prop)
        {
            //check Name
            if (prop.Name is Consts.Guid or Consts.VarGuid) prop.Value_Struct = reader.ReadFGuid();
            else if (prop.Name == Consts.PinValueType) prop.Value_Struct = reader.ReadPropertyTags();
            //check Type
            else if (prop.Type == FStrProperty.TYPE_NAME) prop.Value_Struct = reader.ReadFString();
            else if (prop.Type == FNameProperty.TYPE_NAME) prop.Value_Struct = reader.ReadFName();
            else if (prop.Type == FTextProperty.TYPE_NAME) prop.Value_Struct = reader.ReadFText();
            else if (prop.Type == FIntProperty.TYPE_NAME) prop.Value_Struct = reader.ReadInt32();
            else if (prop.Type == FUInt32Property.TYPE_NAME) prop.Value_Struct = reader.ReadUInt32();
            else if (prop.Type == FObjectPropertyBase.TYPE_NAME) prop.Value_Struct = reader.ReadUInt32();
            else if (prop.Type == FEnumProperty.TYPE_NAME && prop.Size == 4) prop.Value_Struct = reader.ReadUInt32();
            else if (prop.Type == FByteProperty.TYPE_NAME && prop.Size == 4) prop.Value_Struct = reader.ReadUInt32();
            else if (prop.Type == FEnumProperty.TYPE_NAME && prop.Size == 8) prop.Value_Struct = reader.ReadUInt64();
            else if (prop.Type == FByteProperty.TYPE_NAME && prop.Size == 8) prop.Value_Struct = reader.ReadUInt64();
            else if (prop.Type == Consts.SoftObjectProperty) prop.Value_Struct = reader.ReadUInt32();
            else if (prop.Type == FFloatProperty.TYPE_NAME) prop.Value_Struct = reader.ReadSingle();
            else if (prop.Type == Consts.ArrayProperty) prop.Value_Struct = ReadTagValueArray(reader, prop);
            else if (prop.Type == FStructProperty.TYPE_NAME) prop.Value_Struct = ReadTagValueStruct(reader, prop.StructName);
            else return null;
            return prop;
        }

        public static void WriteTagValue(this BinaryWriter writer, PropertyValue prop)
        {
            //check Name
            if (prop.Name is Consts.Guid or Consts.VarGuid) writer.Write(prop.Value_Struct.ToObject<FGuid>());
            else if (prop.Name == Consts.PinValueType) writer.Write(prop.Value_Struct.ToObject<List<FPropertyTag>>());
            //check Type
            else if (prop.Type == FStrProperty.TYPE_NAME) writer.Write(prop.Value_Struct.ToObject<FString>());
            else if (prop.Type == FNameProperty.TYPE_NAME) writer.Write(prop.Value_Struct.ToObject<FName>());
            else if (prop.Type == FTextProperty.TYPE_NAME) writer.Write(prop.Value_Struct.ToObject<FText>());
            else if (prop.Type == FIntProperty.TYPE_NAME) writer.Write(prop.Value_Struct.ToObject<Int32>());
            else if (prop.Type == FUInt32Property.TYPE_NAME) writer.Write(prop.Value_Struct.ToObject<UInt32>());
            else if (prop.Type == FObjectPropertyBase.TYPE_NAME) writer.Write(prop.Value_Struct.ToObject<UInt32>());
            else if (prop.Type == FEnumProperty.TYPE_NAME && prop.Size == 4) writer.Write(prop.Value_Struct.ToObject<UInt32>());
            else if (prop.Type == FByteProperty.TYPE_NAME && prop.Size == 4) writer.Write(prop.Value_Struct.ToObject<UInt32>());
            else if (prop.Type == FEnumProperty.TYPE_NAME && prop.Size == 8) writer.Write(prop.Value_Struct.ToObject<UInt64>());
            else if (prop.Type == FByteProperty.TYPE_NAME && prop.Size == 8) writer.Write(prop.Value_Struct.ToObject<UInt64>());
            else if (prop.Type == Consts.SoftObjectProperty) writer.Write(prop.Value_Struct.ToObject<UInt32>());
            else if (prop.Type == FFloatProperty.TYPE_NAME) writer.Write(prop.Value_Struct.ToObject<float>());
            else if (prop.Type == Consts.ArrayProperty) WriteTagValueArray(writer, prop);
            else if (prop.Type == FStructProperty.TYPE_NAME) WriteTagValueStruct(writer, prop.StructName, prop.Value_Struct);
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
            else return reader.Read(new List<FPropertyTag>());
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
            else writer.Write(value.ToObject<List<FPropertyTag>>());
        }
        #endregion

        #region void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        private static object ReadTagValueArray(BinaryReader reader, PropertyValue prop)
        {
            if (prop.InnerType == FStructProperty.TYPE_NAME)
            {
                int count = reader.ReadInt32();
                prop.MaybeInnerTag = reader.Read(new FPropertyTag());
                if (prop.MaybeInnerTag?.StructName?.Value == FRichCurveKey.StructName)
                {
                    var list = new List<PropertyValue>();
                    prop.Value_Struct = list;
                    list.Resize(count);
                    list.ForEach(propertValue =>
                    {
                        propertValue.Type = prop.InnerType;
                        propertValue.StructName = prop.MaybeInnerTag?.StructName?.Value;
                    });
                    list.ForEach(propertValue => reader.ReadTagValue(propertValue));
                    return list;
                }
                else
                {
                    var list = new List<List<FPropertyTag>>();
                    prop.Value_Struct = list;
                    list.Resize(count);
                    list.ForEach(x => reader.Read(x));
                    return list;
                }
            }
            else
            {
                var list = new List<PropertyValue>();
                prop.Value_Struct = list;
                list.Resize(reader.ReadInt32());
                list.ForEach(x => x.Type = prop.InnerType);
                list.ForEach(x => reader.ReadTagValue(x));
                return list;
            }
        }

        private static void WriteTagValueArray(BinaryWriter writer, PropertyValue prop)
        {
            if (prop.InnerType == FStructProperty.TYPE_NAME)
            {
                if (prop.MaybeInnerTag?.StructName?.Value == FRichCurveKey.StructName)
                {
                    var list = prop.Value_Struct.ToObject<List<PropertyValue>>();
                    writer.Write(list.Count);
                    writer.Write(prop.MaybeInnerTag);
                    list.ForEach(x => writer.WriteTagValue(x));
                }
                else
                {
                    var list = prop.Value_Struct.ToObject<List<List<FPropertyTag>>>();
                    writer.Write(list.Count);
                    writer.Write(prop.MaybeInnerTag);
                    list.ForEach(writer.Write);
                }
            }
            else
            {
                var list = prop.Value_Struct.ToObject<List<PropertyValue>>();
                writer.Write(list.Count);
                list.ForEach(x => x.Type = prop.InnerType);
                list.ForEach(x => writer.WriteTagValue(x));
            }
        }
        #endregion
    }
}

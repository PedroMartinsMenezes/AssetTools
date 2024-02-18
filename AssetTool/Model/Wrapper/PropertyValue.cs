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
        public static PropertyValue Read(this BinaryReader reader, PropertyValue prop)
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
            else if (prop.Type == Consts.ArrayProperty) ReadArrayProperty(reader, prop);
            else if (prop.Type == FStructProperty.TYPE_NAME) ReadStructProperty(reader, prop);
            else return null;
            return prop;
        }

        public static void Write(this BinaryWriter writer, PropertyValue prop)
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
            else if (prop.Type == Consts.ArrayProperty) WriteArrayProperty(writer, prop);
            else if (prop.Type == FStructProperty.TYPE_NAME) WriteStructProperty(writer, prop);
        }
        #endregion

        #region void UScriptStruct::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)
        private static void ReadStructProperty(this BinaryReader reader, PropertyValue prop)
        {
            if (prop.StructName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count == 0) prop.Value_Struct = reader.ReadValue(new FSoftObjectPath(), null);
            else if (prop.StructName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count > 0) prop.Value_Struct = reader.ReadInt32().ToString();
            else if (prop.StructName == FVector2D.StructName) prop.Value_Struct = new FVector2D(reader);
            else if (prop.StructName == FVector.StructName) prop.Value_Struct = new FVector(reader);
            else if (prop.StructName == Consts.Guid) prop.Value_Struct = reader.ReadFGuid();
            else if (prop.StructName == FPointerToUberGraphFrame.StructName) prop.Value_Struct = new FPointerToUberGraphFrame(reader);
            else if (prop.StructName == FRotator.StructName) prop.Value_Struct = new FRotator(reader);
            else if (prop.StructName == FLinearColor.StructName) prop.Value_Struct = new FLinearColor(reader);
            else if (prop.StructName == FRichCurveKey.StructName) prop.Value_Struct = new FRichCurveKey(reader);
            else prop.Value_Struct = reader.Read(new List<FPropertyTag>());
        }

        private static void WriteStructProperty(BinaryWriter writer, PropertyValue prop)
        {
            if (prop.StructName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count == 0) writer.WriteValue(prop.Value_Struct.ToObject<FSoftObjectPath>(), null);
            else if (prop.StructName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count > 0) writer.Write(int.Parse(prop.Value_Struct.ToString()));
            else if (prop.StructName == FVector2D.StructName) (prop.Value_Struct.ToObject<FVector2D>()).Write(writer);
            else if (prop.StructName == FVector.StructName) (prop.Value_Struct.ToObject<FVector>()).Write(writer);
            else if (prop.StructName == Consts.Guid) writer.WriteValue(new FGuid(prop.Value_Struct.ToString()), null);
            else if (prop.StructName == FPointerToUberGraphFrame.StructName) (prop.Value_Struct.ToObject<FPointerToUberGraphFrame>()).Write(writer);
            else if (prop.StructName == FRotator.StructName) (prop.Value_Struct.ToObject<FRotator>()).Write(writer);
            else if (prop.StructName == FLinearColor.StructName) (prop.Value_Struct.ToObject<FLinearColor>()).Write(writer);
            else if (prop.StructName == FRichCurveKey.StructName) (prop.Value_Struct.ToObject<FRichCurveKey>()).Write(writer);
            else writer.Write(prop.Value_Struct.ToObject<List<FPropertyTag>>());
        }
        #endregion

        #region void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        private static void ReadArrayProperty(BinaryReader reader, PropertyValue prop)
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
                    list.ForEach(x => reader.Read(x));
                }
                else
                {
                    var list = new List<List<FPropertyTag>>();
                    prop.Value_Struct = list;
                    list.Resize(count);
                    list.ForEach(x => reader.Read(x));
                }
            }
            else
            {
                var list = new List<PropertyValue>();
                prop.Value_Struct = list;
                list.Resize(reader.ReadInt32());
                list.ForEach(x => x.Type = prop.InnerType);
                list.ForEach(x => reader.Read(x));
            }
        }

        private static void WriteArrayProperty(BinaryWriter writer, PropertyValue prop)
        {
            if (prop.InnerType == FStructProperty.TYPE_NAME)
            {
                if (prop.MaybeInnerTag?.StructName?.Value == FRichCurveKey.StructName)
                {
                    var list = prop.Value_Struct.ToObject<List<PropertyValue>>();
                    writer.Write(list.Count);
                    writer.Write(prop.MaybeInnerTag);
                    list.ForEach(x => writer.Write(x));
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
                list.ForEach(x => writer.Write(x));
            }
        }
        #endregion
    }
}

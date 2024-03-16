namespace AssetTool
{
    [Location("bool FEdGraphPinType::Serialize(FArchive& Ar)")]
    public class FEdGraphPinType
    {
        public const string StructName = "EdGraphPinType";

        public FName PinCategory;
        public FString PinCategoryStr;
        public FName PinSubCategory;
        public FString PinSubCategoryStr;
        public UInt32 PinSubCategoryObject;
        public byte ContainerType;
        public FEdGraphTerminalType PinValueType;
        public FBool bIsMap;
        public FBool bIsSet;
        public FBool bIsArray;
        public FBool bIsReferenceBool;
        public FBool bIsWeakPointerBool;
        public FSimpleMemberReference PinSubCategoryMemberReference;
        public FBool bIsConstBool;
        public FBool bIsUObjectWrapperBool;
        public FBool bSerializeAsSinglePrecisionFloatBool;

        public FEdGraphPinType Read(BinaryReader reader)
        {
            return reader.Read(this);
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(this);
        }
    }

    public static class FEdGraphPinTypeExt
    {
        public static void Write(this BinaryWriter writer, FEdGraphPinType item)
        {
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_EDGRAPHPINTYPE_SERIALIZATION))
                return;

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.PinsStoreFName))
            {
                writer.Write(item.PinCategory);
                writer.Write(item.PinSubCategory);
            }
            else
            {
                writer.Write(item.PinCategoryStr);
                writer.Write(item.PinSubCategoryStr);
            }

            writer.Write(item.PinSubCategoryObject);

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.EdGraphPinContainerType))
            {
                writer.Write(item.ContainerType);
                if ((EPinContainerType)item.ContainerType == EPinContainerType.Map)
                {
                    item.PinValueType.Write(writer);
                }
            }
            else
            {
                if (Supports.CustomVer(FBlueprintsObjectVersion.Enums.AdvancedContainerSupport))
                {
                    writer.Write(item.bIsMap);
                    if (item.bIsMap.Value)
                    {
                        item.PinValueType.Write(writer);
                    }
                    writer.Write(item.bIsSet);
                }
                writer.Write(item.bIsArray);
            }

            writer.Write(item.bIsReferenceBool);
            writer.Write(item.bIsWeakPointerBool);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_MEMBERREFERENCE_IN_PINTYPE))
                writer.Write(item.PinSubCategoryMemberReference);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_PINTYPE_CONST))
                writer.Write(item.bIsConstBool);

            if (Supports.CustomVer(FReleaseObjectVersion.Enums.PinTypeIncludesUObjectWrapperFlag))
                writer.Write(item.bIsUObjectWrapperBool);

            if (Supports.CustomVer(FUE5ReleaseStreamObjectVersion.Enums.SerializeFloatPinDefaultValuesAsSinglePrecision))
                writer.Write(item.bSerializeAsSinglePrecisionFloatBool);
        }

        public static FEdGraphPinType Read(this BinaryReader reader, FEdGraphPinType item)
        {
            return reader.Read(ref item);
        }

        public static FEdGraphPinType Read(this BinaryReader reader, ref FEdGraphPinType item)
        {
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_EDGRAPHPINTYPE_SERIALIZATION))
                return null;
            item ??= new();

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.PinsStoreFName))
            {
                reader.Read(ref item.PinCategory);
                reader.Read(ref item.PinSubCategory);
            }
            else
            {
                item.PinCategoryStr = reader.ReadFString();
                item.PinSubCategoryStr = reader.ReadFString();
            }

            reader.Read(ref item.PinSubCategoryObject);

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.EdGraphPinContainerType))
            {
                reader.Read(ref item.ContainerType);
                if ((EPinContainerType)item.ContainerType == EPinContainerType.Map)
                {
                    item.PinValueType = new FEdGraphTerminalType().Read(reader);
                }
            }
            else
            {
                if (Supports.CustomVer(FBlueprintsObjectVersion.Enums.AdvancedContainerSupport))
                {
                    reader.Read(ref item.bIsMap);
                    if (item.bIsMap.Value)
                    {
                        item.PinValueType = new FEdGraphTerminalType().Read(reader);
                    }
                    reader.Read(ref item.bIsSet);
                }
                reader.Read(ref item.bIsArray);
            }

            reader.Read(ref item.bIsReferenceBool);
            reader.Read(ref item.bIsWeakPointerBool);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_MEMBERREFERENCE_IN_PINTYPE))
                reader.Read(ref item.PinSubCategoryMemberReference);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_PINTYPE_CONST))
                reader.Read(ref item.bIsConstBool);

            if (Supports.CustomVer(FReleaseObjectVersion.Enums.PinTypeIncludesUObjectWrapperFlag))
                reader.Read(ref item.bIsUObjectWrapperBool);

            if (Supports.CustomVer(FUE5ReleaseStreamObjectVersion.Enums.SerializeFloatPinDefaultValuesAsSinglePrecision))
                reader.Read(ref item.bSerializeAsSinglePrecisionFloatBool);

            return item;
        }
    }
}

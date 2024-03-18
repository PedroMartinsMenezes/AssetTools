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
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_EDGRAPHPINTYPE_SERIALIZATION))
                return null;

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.PinsStoreFName))
            {
                reader.Read(ref PinCategory);
                reader.Read(ref PinSubCategory);
            }
            else
            {
                PinCategoryStr = reader.ReadFString();
                PinSubCategoryStr = reader.ReadFString();
            }

            reader.Read(ref PinSubCategoryObject);

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.EdGraphPinContainerType))
            {
                reader.Read(ref ContainerType);
                if ((EPinContainerType)ContainerType == EPinContainerType.Map)
                {
                    PinValueType = new FEdGraphTerminalType().Read(reader);
                }
            }
            else
            {
                if (Supports.CustomVer(FBlueprintsObjectVersion.Enums.AdvancedContainerSupport))
                {
                    reader.Read(ref bIsMap);
                    if (bIsMap.Value)
                    {
                        PinValueType = new FEdGraphTerminalType().Read(reader);
                    }
                    reader.Read(ref bIsSet);
                }
                reader.Read(ref bIsArray);
            }

            reader.Read(ref bIsReferenceBool);
            reader.Read(ref bIsWeakPointerBool);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_MEMBERREFERENCE_IN_PINTYPE))
                reader.Read(ref PinSubCategoryMemberReference);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_PINTYPE_CONST))
                reader.Read(ref bIsConstBool);

            if (Supports.CustomVer(FReleaseObjectVersion.Enums.PinTypeIncludesUObjectWrapperFlag))
                reader.Read(ref bIsUObjectWrapperBool);

            if (Supports.CustomVer(FUE5ReleaseStreamObjectVersion.Enums.SerializeFloatPinDefaultValuesAsSinglePrecision))
                reader.Read(ref bSerializeAsSinglePrecisionFloatBool);

            return this;
        }

        public void Write(BinaryWriter writer)
        {
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_EDGRAPHPINTYPE_SERIALIZATION))
                return;

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.PinsStoreFName))
            {
                writer.Write(PinCategory);
                writer.Write(PinSubCategory);
            }
            else
            {
                writer.Write(PinCategoryStr);
                writer.Write(PinSubCategoryStr);
            }

            writer.Write(PinSubCategoryObject);

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.EdGraphPinContainerType))
            {
                writer.Write(ContainerType);
                if ((EPinContainerType)ContainerType == EPinContainerType.Map)
                {
                    PinValueType.Write(writer);
                }
            }
            else
            {
                if (Supports.CustomVer(FBlueprintsObjectVersion.Enums.AdvancedContainerSupport))
                {
                    writer.Write(bIsMap);
                    if (bIsMap.Value)
                    {
                        PinValueType.Write(writer);
                    }
                    writer.Write(bIsSet);
                }
                writer.Write(bIsArray);
            }

            writer.Write(bIsReferenceBool);
            writer.Write(bIsWeakPointerBool);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_MEMBERREFERENCE_IN_PINTYPE))
                writer.Write(PinSubCategoryMemberReference);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_PINTYPE_CONST))
                writer.Write(bIsConstBool);

            if (Supports.CustomVer(FReleaseObjectVersion.Enums.PinTypeIncludesUObjectWrapperFlag))
                writer.Write(bIsUObjectWrapperBool);

            if (Supports.CustomVer(FUE5ReleaseStreamObjectVersion.Enums.SerializeFloatPinDefaultValuesAsSinglePrecision))
                writer.Write(bSerializeAsSinglePrecisionFloatBool);
        }
    }
}

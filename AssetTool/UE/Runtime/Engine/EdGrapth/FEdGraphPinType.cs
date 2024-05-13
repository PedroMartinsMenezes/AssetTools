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
        public FSimpleMemberReference PinSubCategoryMemberReference = new();
        public FBool bIsConstBool;
        public FBool bIsUObjectWrapperBool;
        public FBool bSerializeAsSinglePrecisionFloatBool;

        public FEdGraphPinType Move(Transfer transfer)
        {
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_EDGRAPHPINTYPE_SERIALIZATION))
                return null;

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.PinsStoreFName))
            {
                transfer.Move(ref PinCategory);
                transfer.Move(ref PinSubCategory);
            }
            else
            {
                transfer.Move(ref PinCategoryStr);
                transfer.Move(ref PinSubCategoryStr);
            }

            transfer.Move(ref PinSubCategoryObject);

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.EdGraphPinContainerType))
            {
                transfer.Move(ref ContainerType);
                if ((EPinContainerType)ContainerType == EPinContainerType.Map)
                {
                    PinValueType = new FEdGraphTerminalType().Move(transfer);
                }
            }
            else
            {
                if (Supports.CustomVer(FBlueprintsObjectVersion.Enums.AdvancedContainerSupport))
                {
                    transfer.Move(ref bIsMap);
                    if (bIsMap.Value)
                    {
                        PinValueType = new FEdGraphTerminalType().Move(transfer);
                    }
                    transfer.Move(ref bIsSet);
                }
                transfer.Move(ref bIsArray);
            }

            transfer.Move(ref bIsReferenceBool);
            transfer.Move(ref bIsWeakPointerBool);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_MEMBERREFERENCE_IN_PINTYPE))
                PinSubCategoryMemberReference.Move(transfer);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_PINTYPE_CONST))
                transfer.Move(ref bIsConstBool);

            if (Supports.CustomVer(FReleaseObjectVersion.Enums.PinTypeIncludesUObjectWrapperFlag))
                transfer.Move(ref bIsUObjectWrapperBool);

            if (Supports.CustomVer(FUE5ReleaseStreamObjectVersion.Enums.SerializeFloatPinDefaultValuesAsSinglePrecision))
                transfer.Move(ref bSerializeAsSinglePrecisionFloatBool);

            return this;
        }


    }
}

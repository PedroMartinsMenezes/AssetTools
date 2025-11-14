namespace AssetTool
{
    [TransferableStruct("EdGraphPinType")]
    public class FEdGraphPinType : ITransferable
    {
        public const string StructName = "EdGraphPinType";

        public FName PinCategory;
        public FString PinCategoryStr;
        public FName PinSubCategory;
        public FString PinSubCategoryStr;
        public FPackageIndex PinSubCategoryObject;
        public EPinContainerType? ContainerType;
        public FEdGraphTerminalType PinValueType;
        public FBool? bIsMap;
        public FBool? bIsSet;
        public FBool? bIsArray;
        public FBool bIsReferenceBool;
        public FBool bIsWeakPointerBool;
        public FSimpleMemberReference PinSubCategoryMemberReference;
        public FBool? bIsConstBool;
        public FBool? bIsUObjectWrapperBool;
        public FBool? bSerializeAsSinglePrecisionFloatBool;

        [Location("bool FEdGraphPinType::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.VER_UE4_EDGRAPHPINTYPE_SERIALIZATION)
                return default;

            if (transfer.Supports.PinsStoreFName)
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

            if (transfer.Supports.EdGraphPinContainerType)
            {
                transfer.MoveEnum(ref ContainerType);
                if (ContainerType == EPinContainerType.Map)
                {
                    transfer.Move(ref PinValueType);
                }
            }
            else
            {
                if (transfer.Supports.AdvancedContainerSupport)
                {
                    transfer.Move(ref bIsMap);
                    if (bIsMap is { })
                    {
                        transfer.Move(ref PinValueType);
                    }
                    transfer.Move(ref bIsSet);
                }
                transfer.Move(ref bIsArray);
            }

            transfer.Move(ref bIsReferenceBool);
            transfer.Move(ref bIsWeakPointerBool);

            if (transfer.Supports.VER_UE4_MEMBERREFERENCE_IN_PINTYPE)
            {
                transfer.Move(ref PinSubCategoryMemberReference);
            }
            if (transfer.Supports.VER_UE4_SERIALIZE_PINTYPE_CONST)
                transfer.Move(ref bIsConstBool);

            if (transfer.Supports.PinTypeIncludesUObjectWrapperFlag)
                transfer.Move(ref bIsUObjectWrapperBool);

            if (transfer.Supports.SerializeFloatPinDefaultValuesAsSinglePrecision)
                transfer.Move(ref bSerializeAsSinglePrecisionFloatBool);

            return this;
        }


    }
}

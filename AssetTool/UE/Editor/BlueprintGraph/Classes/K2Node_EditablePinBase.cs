namespace AssetTool
{
    [JsonAsset("K2Node_EditablePinBase")]
    public class UK2Node_EditablePinBase : UK2Node
    {
        public List<FUserPinInfo> SerializedItems;

        [Location("void UK2Node_EditablePinBase::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SerializedItems);
            return this;
        }
    }

    public class FUserPinInfo : ITransferable
    {
        public FName PinName;
        public FString PinNameStr;
        public FEdGraphPinType PinType;
        public byte DesiredPinDirection;
        public FString PinDefaultValue;
        public FBool bIsArray;
        public FBool bIsReference;
        public FString PinCategoryStr;

        public FString PinSubCategoryStr;
        public UInt32 PinSubCategoryObject;

        [Location("FArchive& operator<<(FArchive& Ar, FUserPinInfo& Info)")]
        public ITransferable Move(Transfer transfer)
        {
            if (transfer.Supports.PinsStoreFName)
            {
                transfer.Move(ref PinName);
            }
            else
            {
                transfer.Move(ref PinNameStr);
            }
            if (transfer.Supports.VER_UE4_SERIALIZE_PINTYPE_CONST)
            {
                transfer.Move(ref PinType);
                transfer.Move(ref DesiredPinDirection);
            }
            else
            {
                transfer.Move(ref bIsArray);
                transfer.Move(ref bIsReference);
                transfer.Move(ref PinCategoryStr);
                transfer.Move(ref PinSubCategoryStr);
                transfer.Move(ref PinSubCategoryObject);
            }
            transfer.Move(ref PinDefaultValue);
            return this;
        }
    }
}
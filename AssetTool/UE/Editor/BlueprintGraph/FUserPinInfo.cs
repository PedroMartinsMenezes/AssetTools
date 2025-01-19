namespace AssetTool
{
    public class FUserPinInfo : ITransferible
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
        public ITransferible Move(Transfer transfer)
        {
            if (Supports.PinsStoreFName)
            {
                transfer.Move(ref PinName);
            }
            else
            {
                transfer.Move(ref PinNameStr);
            }
            if (Supports.VER_UE4_SERIALIZE_PINTYPE_CONST)
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

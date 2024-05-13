namespace AssetTool
{
    public class FUserPinInfo
    {
        public FName PinName;
        public FEdGraphPinType PinType = new();
        public byte DesiredPinDirection;
        public FString PinDefaultValue;

        public FUserPinInfo Move(Transfer transfer)
        {
            transfer.Move(ref PinName);
            PinType.Move(transfer);
            transfer.Move(ref DesiredPinDirection);
            transfer.Move(ref PinDefaultValue);
            return this;
        }
    }
}

namespace AssetTool
{
    public class FUserPinInfo : ITransferible
    {
        public FName PinName;
        public FEdGraphPinType PinType;
        public byte DesiredPinDirection;
        public FString PinDefaultValue;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref PinName);
            transfer.Move(ref PinType);
            transfer.Move(ref DesiredPinDirection);
            transfer.Move(ref PinDefaultValue);
            return this;
        }
    }
}

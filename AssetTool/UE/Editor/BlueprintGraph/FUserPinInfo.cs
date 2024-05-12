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
            if (transfer.IsReading)
                return Read(transfer.reader);
            else
                return Write(transfer.writer);
        }

        private FUserPinInfo Read(BinaryReader reader)
        {
            reader.Read(ref PinName);
            PinType.Read(reader);
            reader.Read(ref DesiredPinDirection);
            reader.Read(ref PinDefaultValue);
            return this;
        }

        private FUserPinInfo Write(BinaryWriter writer)
        {
            writer.Write(PinName);
            PinType.Write(writer);
            writer.Write(DesiredPinDirection);
            writer.Write(PinDefaultValue);
            return this;
        }
    }
}

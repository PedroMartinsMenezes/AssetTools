namespace AssetTool
{
    public class FUserPinInfo
    {
        public FName PinName;
        public FEdGraphPinType PinType = new();
        public byte DesiredPinDirection;
        public FString PinDefaultValue;

        public FUserPinInfo Read(BinaryReader reader)
        {
            reader.Read(ref PinName);
            PinType.Read(reader);
            reader.Read(ref DesiredPinDirection);
            reader.Read(ref PinDefaultValue);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(PinName);
            PinType.Write(writer);
            writer.Write(DesiredPinDirection);
            writer.Write(PinDefaultValue);
        }
    }
}

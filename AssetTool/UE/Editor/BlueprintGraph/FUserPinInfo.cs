namespace AssetTool
{
    public class FUserPinInfo
    {
        public FName PinName;
        public FEdGraphPinType PinType;
        public byte DesiredPinDirection;
        public FString PinDefaultValue;
    }

    public static class FUserPinInfoExt
    {
        public static void Write(this BinaryWriter writer, FUserPinInfo item)
        {
            writer.Write(item.PinName);
            writer.Write(item.PinType);
            writer.Write(item.DesiredPinDirection);
            writer.Write(item.PinDefaultValue);
        }

        public static FUserPinInfo Read(this BinaryReader reader, FUserPinInfo item)
        {
            reader.Read(ref item.PinName);
            reader.Read(ref item.PinType);
            reader.Read(ref item.DesiredPinDirection);
            reader.Read(ref item.PinDefaultValue);
            return item;
        }
    }
}

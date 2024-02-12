namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FFormatArgumentValue& Value)")]
    public class FFormatArgumentValue
    {
        public byte Type;

        public Int64 IntValue;
        public UInt64 UIntValue;
        public float FloatValue;
        public double DoubleValue;
        public FText TextValue;

        public void Read(BinaryReader reader)
        {
            reader.Read(ref Type);
            switch ((EFormatArgumentType)Type)
            {
                case EFormatArgumentType.Double:
                    reader.Read(ref DoubleValue);
                    break;
                case EFormatArgumentType.Float:
                    reader.Read(ref FloatValue);
                    break;
                case EFormatArgumentType.Int:
                    reader.Read(ref IntValue);
                    break;
                case EFormatArgumentType.UInt:
                    reader.Read(ref UIntValue);
                    break;
                case EFormatArgumentType.Gender:
                    reader.Read(ref UIntValue);
                    break;
                case EFormatArgumentType.Text:
                    reader.Read(ref TextValue);
                    break;
            }
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(Type);
            switch ((EFormatArgumentType)Type)
            {
                case EFormatArgumentType.Double:
                    writer.Write(DoubleValue);
                    break;
                case EFormatArgumentType.Float:
                    writer.Write(FloatValue);
                    break;
                case EFormatArgumentType.Int:
                    writer.Write(IntValue);
                    break;
                case EFormatArgumentType.UInt:
                    writer.Write(UIntValue);
                    break;
                case EFormatArgumentType.Gender:
                    writer.Write(UIntValue);
                    break;
                case EFormatArgumentType.Text:
                    writer.Write(TextValue);
                    break;
            }
        }

        enum EFormatArgumentType
        {
            Int,
            UInt,
            Float,
            Double,
            Text,
            Gender,
        };
    }
}

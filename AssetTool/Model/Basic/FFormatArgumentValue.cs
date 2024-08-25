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

        public void Move(Transfer transfer)
        {
            transfer.Move(ref Type);
            switch ((EFormatArgumentType)Type)
            {
                case EFormatArgumentType.Double:
                    transfer.Move(ref DoubleValue);
                    break;
                case EFormatArgumentType.Float:
                    transfer.Move(ref FloatValue);
                    break;
                case EFormatArgumentType.Int:
                    transfer.Move(ref IntValue);
                    break;
                case EFormatArgumentType.UInt:
                    transfer.Move(ref UIntValue);
                    break;
                case EFormatArgumentType.Gender:
                    transfer.Move(ref UIntValue);
                    break;
                case EFormatArgumentType.Text:
                    transfer.Move(ref TextValue);
                    break;
            }
        }

        public enum EFormatArgumentType
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

namespace AssetTool
{
    public class FFormatArgumentValue : ITransferible
    {
        public byte Type;

        public Int64 IntValue;
        public UInt64 UIntValue;
        public float FloatValue;
        public double DoubleValue;
        public FText TextValue;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FFormatArgumentValue& Value)")]
        public ITransferible Move(Transfer transfer)
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
            return this;
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

namespace AssetTool
{
    public class FFormatArgumentValue : ITransferable
    {
        public EFormatArgumentType Type;
        public Int64? IntValue;
        public UInt64? UIntValue;
        public float? FloatValue;
        public double? DoubleValue;
        public FText TextValue;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FFormatArgumentValue& Value)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Type);
            if ((int)Type < (int)EFormatArgumentType.Int || (int)Type > (int)EFormatArgumentType.Gender)
            {
                throw new InvalidOperationException("Invalid EFormatArgumentType");
            }
            switch (Type)
            {
                case EFormatArgumentType.Int:
                    transfer.Move(ref IntValue);
                    break;
                case EFormatArgumentType.UInt:
                    transfer.Move(ref UIntValue);
                    break;
                case EFormatArgumentType.Float:
                    transfer.Move(ref FloatValue);
                    break;
                case EFormatArgumentType.Double:
                    transfer.Move(ref DoubleValue);
                    break;
                case EFormatArgumentType.Text:
                    transfer.Move(ref TextValue);
                    break;
                case EFormatArgumentType.Gender:
                    transfer.Move(ref UIntValue);
                    break;
            }
            return this;
        }

        public object ToStringOrObject()
        {
            switch (Type)
            {
                case EFormatArgumentType.Int:
                    return $"int {IntValue}";
                case EFormatArgumentType.UInt:
                    return $"uint {UIntValue}";
                case EFormatArgumentType.Float:
                    return $"float {FloatValue}";
                case EFormatArgumentType.Double:
                    return $"double {DoubleValue}";
                case EFormatArgumentType.Text:
                    return TextValue.ToStringOrObject();
                case EFormatArgumentType.Gender:
                    return $"gender {UIntValue}";
            }
            return null;
        }

        public static FFormatArgumentValue FromStringOrObject(object obj)
        {
            if (obj is string s)
            {
                string type = s.Substring(0, s.IndexOf(' '));
                switch (type)
                {
                    case "int":
                        return new() { Type = EFormatArgumentType.Int, IntValue = long.Parse(s.Substring(s.IndexOf(' '))) };
                    case "uint":
                        return new() { Type = EFormatArgumentType.UInt, UIntValue = ulong.Parse(s.Substring(s.IndexOf(' '))) };
                    case "float":
                        return new() { Type = EFormatArgumentType.Float, FloatValue = float.Parse(s.Substring(s.IndexOf(' '))) };
                    case "double":
                        return new() { Type = EFormatArgumentType.Double, DoubleValue = double.Parse(s.Substring(s.IndexOf(' '))) };
                    case "gender":
                        return new() { Type = EFormatArgumentType.Gender, UIntValue = uint.Parse(s.Substring(s.IndexOf(' '))) };
                    default:
                        return new() { Type = EFormatArgumentType.Text, TextValue = FText.FromStringOrObject(obj) };
                }
            }
            else
            {
                return new() { Type = EFormatArgumentType.Text, TextValue = FText.FromStringOrObject(obj) };
            }
        }

        public string GetText() => Type == EFormatArgumentType.Text ? TextValue?.GetSourceString() : ToStringOrObject().ToString();

        public string GetKey() => TextValue?.GetKey();

        public string GetNamespace() => TextValue?.GetNamespace();

        public string GetFlag() => TextValue?.Flags.ToString();

        public string GetHistoryType() => TextValue?.HistoryType.ToString();

        public enum EFormatArgumentType : byte
        {
            Int,
            UInt,
            Float,
            Double,
            Text,
            Gender,
        }
    }
}

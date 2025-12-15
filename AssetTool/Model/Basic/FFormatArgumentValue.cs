using System.Text.Json.Serialization;

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
        [JsonIgnore] public int EndPosition;

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

        public override string ToString()
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
                    return $"{TextValue}";
                case EFormatArgumentType.Gender:
                    return $"gender {UIntValue}";
            }
            return string.Empty;
        }

        public static FFormatArgumentValue FromString(string value)
        {
            FFormatArgumentValue result = new();
            if (value.StartsWith("text"))
            {
                result = new() { Type = EFormatArgumentType.Text, TextValue = FText.FromString(value) };
            }
            else
            {
                string type = value.Substring(0, value.IndexOf(' ') + 1);
                switch (type)
                {
                    case "int":
                        result = new() { Type = EFormatArgumentType.Int, IntValue = long.Parse(value.Substring(value.IndexOf(' ') + 1)) };
                        break;
                    case "uint":
                        result = new() { Type = EFormatArgumentType.UInt, UIntValue = ulong.Parse(value.Substring(value.IndexOf(' ') + 1)) };
                        break;
                    case "float":
                        result = new() { Type = EFormatArgumentType.Float, FloatValue = float.Parse(value.Substring(value.IndexOf(' ') + 1)) };
                        break;
                    case "double":
                        result = new() { Type = EFormatArgumentType.Double, DoubleValue = double.Parse(value.Substring(value.IndexOf(' ') + 1)) };
                        break;
                    case "gender":
                        result = new() { Type = EFormatArgumentType.Gender, UIntValue = ulong.Parse(value.Substring(value.IndexOf(' ') + 1)) };
                        break;
                }
            }
            return result;
        }

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

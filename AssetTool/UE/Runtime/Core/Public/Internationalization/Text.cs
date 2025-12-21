using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{ArgumentName} {ArgumentValueType}")]
    public class FFormatArgumentData : ITransferable
    {
        public FString ArgumentName;
        public FText TempValue;
        public EFormatArgumentType ArgumentValueType;
        public int64? ArgumentValueInt;
        public float? ArgumentValueFloat;
        public double? ArgumentValueDouble;
        public FText ArgumentValue;
        public ETextGender? ArgumentValueGender;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FFormatArgumentData& Value)")]
        public ITransferable Move(Transfer transfer)
        {
            if (transfer.Supports.VER_UE4_K2NODE_VAR_REFERENCEGUIDS)
            {
                transfer.Move(ref ArgumentName);
            }
            else
            {
                transfer.Move(ref TempValue);
            }
            if (transfer.Supports.TextFormatArgumentDataIsVariant)
            {
                transfer.MoveEnum(ref ArgumentValueType);
            }
            else
            {
                ArgumentValueType = EFormatArgumentType.Text;
            }
            switch (ArgumentValueType)
            {
                case EFormatArgumentType.Int:
                    if (transfer.Supports.TextFormatArgumentData64bitSupport)
                        transfer.Move(ref ArgumentValueInt);
                    else
                        transfer.MoveAsInt(ref ArgumentValueInt);
                    break;
                case EFormatArgumentType.Float:
                    transfer.Move(ref ArgumentValueFloat);
                    break;
                case EFormatArgumentType.Double:
                    transfer.Move(ref ArgumentValueDouble);
                    break;
                case EFormatArgumentType.Text:
                    transfer.Move(ref ArgumentValue);
                    break;
                case EFormatArgumentType.Gender:
                    transfer.MoveEnum(ref ArgumentValueGender);
                    break;
            }
            return this;
        }

        public string GetArgumentName(Transfer transfer) => transfer.Supports.VER_UE4_K2NODE_VAR_REFERENCEGUIDS ? ArgumentName.ToString() : TempValue.ToString();

        public object ToStringOrObject()
        {
            switch (ArgumentValueType)
            {
                case EFormatArgumentType.Int:
                    return $"int ArgumentName('{ArgumentName}') {ArgumentValueInt}";
                case EFormatArgumentType.Float:
                    return $"float ArgumentName('{ArgumentName}') {ArgumentValueFloat}";
                case EFormatArgumentType.Double:
                    return $"double ArgumentName('{ArgumentName}') {ArgumentValueDouble}";
                case EFormatArgumentType.Text:
                    return new Dictionary<string, object> { { $"text ArgumentName('{ArgumentName}')", ArgumentValue.ToStringOrObject() } };
                case EFormatArgumentType.Gender:
                    return $"gender ArgumentName('{ArgumentName}') {ArgumentValueGender}";
            }
            return null;
        }

        public static FFormatArgumentData FromStringOrObject(object obj)
        {
            if (obj is string s)
            {
                string type = s.Substring(0, s.IndexOf(' '));
                switch (type)
                {
                    case "int":
                        return new() { ArgumentValueType = EFormatArgumentType.Int, ArgumentValueInt = long.Parse(s.Substring(s.IndexOf(' ') + 1)) };
                    case "float":
                        return new() { ArgumentValueType = EFormatArgumentType.Float, ArgumentValueFloat = float.Parse(s.Substring(s.IndexOf(' ') + 1)) };
                    case "double":
                        return new() { ArgumentValueType = EFormatArgumentType.Double, ArgumentValueDouble = double.Parse(s.Substring(s.IndexOf(' ') + 1)) };
                    case "gender":
                        return new() { ArgumentValueType = EFormatArgumentType.Gender, ArgumentValueGender = Enum.Parse<ETextGender>(s.Substring(s.IndexOf(' ') + 1)) };
                    default:
                        return new() { ArgumentValueType = EFormatArgumentType.Text, ArgumentValue = FText.FromStringOrObject(obj) };
                }
            }
            else
            {
                return new() { ArgumentValueType = EFormatArgumentType.Text, ArgumentValue = FText.FromStringOrObject(obj) };
            }
        }
    }

    public enum EFormatArgumentType : uint8
    {
        Int,
        UInt,
        Float,
        Double,
        Text,
        Gender,
    }

    public enum EDateTimeStyle : uint8
    {
        Default,
        Short,
        Medium,
        Long,
        Full,
        Custom,
    }

    public enum ETextGender : uint8
    {
        Masculine,
        Feminine,
        Neuter,
    }
}

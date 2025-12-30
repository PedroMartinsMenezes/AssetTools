using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{ArgumentNameStr} {ArgumentValueType}")]
    public class FFormatArgumentData : ITransferable
    {
        public FString ArgumentNameStr;
        public FText ArgumentNameText;
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
                transfer.Move(ref ArgumentNameStr);
            }
            else
            {
                transfer.Move(ref ArgumentNameText);
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

        public string GetKey()
        {
            if (ArgumentNameStr is { })
                return ArgumentNameStr.ToString();
            else
                return ArgumentNameText.ToSimpleString();
        }

        public string GetValue()
        {
            switch (ArgumentValueType)
            {
                case EFormatArgumentType.Int:
                    return $"int {ArgumentValueInt}";
                case EFormatArgumentType.Float:
                    return $"float {ArgumentValueFloat}";
                case EFormatArgumentType.Double:
                    return $"double {ArgumentValueDouble}";
                case EFormatArgumentType.Gender:
                    return $"gender {ArgumentValueGender}";
                case EFormatArgumentType.Text:
                    return $"text {ArgumentValue.ToSimpleString()}";
            }
            return string.Empty;
        }

        public FFormatArgumentData FromkeyValue(string key, string value)
        {
            ArgumentNameStr = new FString(key);
            ArgumentNameText = key.Contains("Flags(") ? FText.FromSimpleString(key) : null;

            string type = value.Substring(0, value.IndexOf(' '));
            switch (type)
            {
                case "int":
                    ArgumentValueType = EFormatArgumentType.Int;
                    ArgumentValueInt = long.Parse(value[value.IndexOf(' ')..]);
                    break;
                case "float":
                    ArgumentValueType = EFormatArgumentType.Float;
                    ArgumentValueFloat = float.Parse(value[value.IndexOf(' ')..]);
                    break;
                case "double":
                    ArgumentValueType = EFormatArgumentType.Double;
                    ArgumentValueDouble = double.Parse(value[value.IndexOf(' ')..]);
                    break;
                case "gender":
                    ArgumentValueType = EFormatArgumentType.Gender;
                    ArgumentValueGender = Enum.Parse<ETextGender>(value[value.IndexOf(' ')..]);
                    break;
                default:
                    ArgumentValueType = EFormatArgumentType.Text;
                    ArgumentValue = FText.FromSimpleString(value[value.IndexOf(' ')..]);
                    break;
            }
            return this;
        }
    }

    public static class FFormatArgumentDataExt
    {
        public static string ToSimpleString(this List<FFormatArgumentData> self)
        {
            string keys = string.Join("` `", self.Select(x => x.GetKey()));
            string values = string.Join("` `", self.Select(x => x.GetValue()));
            return $"Keys( `{keys}` ) Values( `{values}` )";
        }

        public static List<FFormatArgumentData> FromStringList(this string str)
        {
            string allKeys = str.GetNonNull("Keys( `{0}` )", x => x);
            string allValues = str.GetNonNull("Values( `{0}` )", x => x);
            string[] keys = allKeys.Split("` `");
            string[] values = allValues.Split("` `");
            return keys.Select((x, i) => new FFormatArgumentData().FromkeyValue(keys[i], values[i])).ToList();
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

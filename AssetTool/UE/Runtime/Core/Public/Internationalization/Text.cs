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

        public string GetArgumentName(Transfer transfer) => transfer.Supports.VER_UE4_K2NODE_VAR_REFERENCEGUIDS ? ArgumentNameStr.ToString() : ArgumentNameText.ToSimpleString();

        public string ToSimpleString()
        {
            string name = ArgumentNameStr is { } ? $"name=`{ArgumentNameStr}`" : $"name({ArgumentNameText.ToSimpleString()})";
            switch (ArgumentValueType)
            {
                case EFormatArgumentType.Int:
                    return $"(int {name} value=`{ArgumentValueInt}`)";
                case EFormatArgumentType.Float:
                    return $"float {name} value=`{ArgumentValueFloat}`";
                case EFormatArgumentType.Double:
                    return $"double {name} value=`{ArgumentValueDouble}`";
                case EFormatArgumentType.Text:
                    return $"text {name} value({ArgumentValue.ToSimpleString()})";
                case EFormatArgumentType.Gender:
                    return $"gender {name} value=`{ArgumentValueGender}`";
            }
            return string.Empty;
        }

        public FFormatArgumentData FromSimpleString(string str)
        {
            FFormatArgumentData result = new();

            if (str.Contains("name=`"))
                result.ArgumentNameStr = str.GetNonNull("name=`{0}`", (x) => new FString(x));
            else
                result.ArgumentNameText = str.GetNonNull("name({0})", (x) => FText.FromSimpleString(x));

            string type = str.Substring(0, str.IndexOf(' '));
            switch (type)
            {
                case "int":
                    result.ArgumentValueType = EFormatArgumentType.Int;
                    ArgumentValueInt = str.GetNonNull("value=`{0}`", (x) => int.Parse(x));
                    break;
                case "float":
                    result.ArgumentValueType = EFormatArgumentType.Float;
                    ArgumentValueFloat = str.GetNonNull("value=`{0}`", (x) => float.Parse(x));
                    break;
                case "double":
                    result.ArgumentValueType = EFormatArgumentType.Double;
                    ArgumentValueDouble = str.GetNonNull("value=`{0}`", (x) => double.Parse(x));
                    break;
                case "gender":
                    result.ArgumentValueType = EFormatArgumentType.Gender;
                    ArgumentValueGender = str.GetNonNull("value=`{0}`", (x) => Enum.Parse<ETextGender>(x));
                    break;
                default:
                    result.ArgumentValueType = EFormatArgumentType.Text;
                    result.ArgumentValue = str.GetNonNull("value({0})", (x) => FText.FromSimpleString(x));
                    break;
            }
            return result;
        }

    }

    public static class FFormatArgumentDataExt
    {
        public static string ToSimpleString(this List<FFormatArgumentData> self)
        {
            string values = string.Join(" ", self.Select(x => x.ToSimpleString()));
            return $"Values({values})";
        }

        public static List<FFormatArgumentData> FromStringList(this string str)
        {
            string allValues = str.GetNonNull("Values(`{0}`)", x => x);
            string[] values = allValues.Split("` `");
            return values.Select(x => new FFormatArgumentData().FromSimpleString(x)).ToList();
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

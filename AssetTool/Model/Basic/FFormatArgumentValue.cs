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

        public string ToSimpleString()
        {
            switch (Type)
            {
                case EFormatArgumentType.Int:
                    return $"int({IntValue})";
                case EFormatArgumentType.UInt:
                    return $"uint({UIntValue})";
                case EFormatArgumentType.Float:
                    return $"float({FloatValue})";
                case EFormatArgumentType.Double:
                    return $"double({DoubleValue})";
                case EFormatArgumentType.Text:
                    return $"text(«{TextValue.ToSimpleString()}»)";
                case EFormatArgumentType.Gender:
                    return $"gender({UIntValue})";
            }
            return string.Empty;
        }

        public FFormatArgumentValue FromSimpleString(string str)
        {
            string type = str.Substring(0, str.IndexOf('('));
            switch (type)
            {
                case "int":
                    return new() { Type = EFormatArgumentType.Int, IntValue = long.Parse(str[(str.IndexOf('(') + 1)..str.IndexOf(')')]) };
                case "uint":
                    return new() { Type = EFormatArgumentType.UInt, UIntValue = ulong.Parse(str[(str.IndexOf('(') + 1)..str.IndexOf(')')]) };
                case "float":
                    return new() { Type = EFormatArgumentType.Float, FloatValue = float.Parse(str[(str.IndexOf('(') + 1)..str.IndexOf(')')]) };
                case "double":
                    return new() { Type = EFormatArgumentType.Double, DoubleValue = double.Parse(str[(str.IndexOf('(') + 1)..str.IndexOf(')')]) };
                case "gender":
                    return new() { Type = EFormatArgumentType.Gender, UIntValue = uint.Parse(str[(str.IndexOf('(') + 1)..str.IndexOf(')')]) };
                case "text":
                    return new() { Type = EFormatArgumentType.Text, TextValue = FText.FromSimpleString(str[(str.IndexOf('«') + 1)..]) };
                default:
                    return null;
            }
        }

        public string GetText() => Type == EFormatArgumentType.Text ? TextValue?.GetSourceString() : ToSimpleString();

        public string GetId() => TextValue?.GetId();

        public string GetNamespace() => TextValue?.GetNamespace();

        public string GetFlag() => TextValue?.Flags.ToString();

        public string GetHistoryType() => TextValue?.HistoryType.ToString();

        public bool IsSimple() => Type != EFormatArgumentType.Text || TextValue.TextData.IsSimple();
    }

    public static class FFormatArgumentValueExt
    {
        public static string ToSimpleString(this Dictionary<FString, FFormatArgumentValue> self)
        {
            string keys = string.Join("` `", self.Keys.Select(x => x.Value));
            string values = string.Join("` `", self.Values.Select(x => x.ToSimpleString()));
            return $"Keys(`{keys}`) Values« `{values}` »";
        }

        public static Dictionary<FString, FFormatArgumentValue> FromStringDictionary(this string str)
        {
            Dictionary<FString, FFormatArgumentValue> result = [];

            string allKeys = str.GetNonNull("Keys(`{0}`)", x => x);
            string allValues = str.GetNonNull("Values« `{0}` »", x => x);

            string[] keys = allKeys.Split("` `");
            List<string> values = allValues.Split("` `").ToList();

            while (values.Count > keys.Length)
            {
                values[^2] = values[^2] + "` `" + values[^1];
                values.RemoveAt(values.Count - 1);
            }

            for (int i = 0; i < keys.Length; i++)
            {
                result.Add(new FString(keys[i]), new FFormatArgumentValue().FromSimpleString(values[i]));
            }

            return result;
        }

        public static string ToSimpleString(this List<FFormatArgumentValue> self)
        {
            string values = string.Join("` `", self.Select(x => x.ToSimpleString()));
            return $"Values« `{values}` »";
        }

        public static List<FFormatArgumentValue> FromStringList(this string str)
        {
            string allValues = str.GetNonNull("Values« `{0}` »", x => x);
            string[] values = allValues.Split("` `");
            return values.Select(x => new FFormatArgumentValue().FromSimpleString(x)).ToList();
        }
    }
}

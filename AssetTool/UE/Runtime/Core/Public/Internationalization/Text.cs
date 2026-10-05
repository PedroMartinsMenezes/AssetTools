using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region FFormatArgumentValue
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
    #endregion

    #region FFormatArgumentData
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
                case "text":
                    ArgumentValueType = EFormatArgumentType.Text;
                    ArgumentValue = FText.FromSimpleString(value[(value.IndexOf(' ') + 1)..]);
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
            return $"Keys( `{keys}` ) Values« `{values}` »";
        }

        public static List<FFormatArgumentData> FromStringList(this string str)
        {
            string allKeys = str.GetNonNull("Keys( `{0}` )", x => x);
            string allValues = str.GetNonNull("Values« `{0}` »", x => x);
            string[] keys = allKeys.Split("` `");
            string[] values = allValues.Split("` `");
            return keys.Select((x, i) => new FFormatArgumentData().FromkeyValue(keys[i], values[i])).ToList();
        }
    }
    #endregion

    #region FText
    [DebuggerDisplay("{ToSimpleString()}")]
    public class FText : ITransferable
    {
        #region Remove
        #endregion
        public ETextFlag Flags;
        public ETextHistoryType HistoryType = (ETextHistoryType)(-1);
        public bool bHasCultureInvariantString;
        public ITextData TextData;
        public FString SourceStringToImplantIntoHistory;
        public FTextKey Namespace;
        public FTextKey Key;

        [Location("void FText::SerializeText(FStructuredArchive::FSlot Slot, FText& Value)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.VER_UE4_FTEXT_HISTORY)
            {
                transfer.Move(ref SourceStringToImplantIntoHistory);
                if (transfer.Supports.VER_UE4_ADDED_NAMESPACE_AND_KEY_DATA_TO_FTEXT)
                {
                    transfer.Move(ref Namespace);
                    transfer.Move(ref Key);
                }
            }
            transfer.MoveEnum(ref Flags);
            if (transfer.Supports.VER_UE4_FTEXT_HISTORY)
            {
                transfer.MoveEnum(ref HistoryType);
                bool bSerializeHistory = true;
                switch (HistoryType)
                {
                    #region
                    case ETextHistoryType.Base:
                        TextData ??= new FTextHistory_Base();
                        break;
                    case ETextHistoryType.NamedFormat:
                        TextData ??= new FTextHistory_NamedFormat();
                        break;
                    case ETextHistoryType.OrderedFormat:
                        TextData ??= new FTextHistory_OrderedFormat();
                        break;
                    case ETextHistoryType.ArgumentFormat:
                        TextData ??= new FTextHistory_ArgumentDataFormat();
                        break;
                    case ETextHistoryType.AsNumber:
                        TextData ??= new FTextHistory_AsNumber();
                        break;
                    case ETextHistoryType.AsPercent:
                        TextData ??= new FTextHistory_AsPercent();
                        break;
                    case ETextHistoryType.AsCurrency:
                        TextData ??= new FTextHistory_AsCurrency();
                        break;
                    case ETextHistoryType.AsDate:
                        TextData ??= new FTextHistory_AsDate();
                        break;
                    case ETextHistoryType.AsTime:
                        TextData ??= new FTextHistory_AsTime();
                        break;
                    case ETextHistoryType.AsDateTime:
                        TextData ??= new FTextHistory_AsDateTime();
                        break;
                    case ETextHistoryType.Transform:
                        TextData ??= new FTextHistory_Transform();
                        break;
                    case ETextHistoryType.StringTableEntry:
                        TextData ??= new FTextHistory_StringTableEntry();
                        break;
                    case ETextHistoryType.TextGenerator:
                        TextData ??= new FTextHistory_TextGenerator();
                        break;
                    #endregion
                    default:
                        bSerializeHistory = false;
                        if (transfer.Supports.CultureInvariantTextSerializationKeyStability)
                        {
                            transfer.Move(ref bHasCultureInvariantString);
                            if (bHasCultureInvariantString)
                            {
                                TextData ??= new FTextHistory_Base();
                                FTextHistory_Base textData = TextData as FTextHistory_Base;
                                transfer.Move(ref textData.SourceString);
                            }
                        }
                        break;
                }
                if (bSerializeHistory)
                {
                    TextData.Move(transfer);
                }
            }
            return this;
        }

        #region Simplified Json to use in JsonConverter
        [JsonIgnore] public bool IsNull => Flags == ETextFlag.None && HistoryType == (ETextHistoryType)(-1) && !bHasCultureInvariantString && TextData == null && SourceStringToImplantIntoHistory == null && Namespace == null && Key == null;

        public string GetSourceString() => (TextData as FTextHistory_Base)?.SourceString?.ToString();

        public string GetId() => (TextData as FTextHistory_Base)?.Key?.ToString();

        public string GetNamespace() => (TextData as FTextHistory_Base)?.Namespace?.ToString();

        public string ToSimpleString()
        {
            string header = WriteHeader();
            if (HistoryType != (ETextHistoryType)(-1))
            {
                return TextData.ToSimpleString(header);
            }
            else
            {
                string sourceString = GetSourceString() is string value ? $"SourceString=`{value}`" : string.Empty;
                return $"text {header} {sourceString}";
            }
        }

        public static FText FromSimpleString(string txt)
        {
            FText result = new();
            string type = txt.Substring(0, txt.IndexOf(" "));
            result.ReadHeader(txt);
            if (txt.Contains("old-header="))
                return result;
            switch (type)
            {
                case "text-base":
                    result.TextData = new FTextHistory_Base();
                    result.HistoryType = ETextHistoryType.Base;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text":
                    result.HistoryType = (ETextHistoryType)(-1);
                    string sourceString = txt.GetNonNull("SourceString=`{0}`", x => x);
                    result.bHasCultureInvariantString = sourceString is { };
                    result.TextData = sourceString is { } ? new FTextHistory_Base { SourceString = new FString(sourceString) } : null;
                    break;
                case "text-named-format":
                    result.TextData = new FTextHistory_NamedFormat();
                    result.HistoryType = ETextHistoryType.NamedFormat;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text-ordered-format":
                    result.TextData = new FTextHistory_OrderedFormat();
                    result.HistoryType = ETextHistoryType.OrderedFormat;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text-argument-format":
                    result.TextData = new FTextHistory_ArgumentDataFormat();
                    result.HistoryType = ETextHistoryType.ArgumentFormat;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text-as-number":
                    result.TextData = new FTextHistory_AsNumber();
                    result.HistoryType = ETextHistoryType.AsNumber;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text-as-percent":
                    result.TextData = new FTextHistory_AsPercent();
                    result.HistoryType = ETextHistoryType.AsPercent;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text-as-currency":
                    result.TextData = new FTextHistory_AsCurrency();
                    result.HistoryType = ETextHistoryType.AsCurrency;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text-as-date":
                    result.TextData = new FTextHistory_AsDate();
                    result.HistoryType = ETextHistoryType.AsDate;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text-as-time":
                    result.TextData = new FTextHistory_AsTime();
                    result.HistoryType = ETextHistoryType.AsTime;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text-as-date-time":
                    result.TextData = new FTextHistory_AsDateTime();
                    result.HistoryType = ETextHistoryType.AsDateTime;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text-transform":
                    result.TextData = new FTextHistory_Transform();
                    result.HistoryType = ETextHistoryType.Transform;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text-string-table-entry":
                    result.TextData = new FTextHistory_StringTableEntry();
                    result.HistoryType = ETextHistoryType.StringTableEntry;
                    result.TextData.FromSimpleString(txt);
                    break;
                case "text-generator":
                    result.TextData = new FTextHistory_TextGenerator();
                    result.HistoryType = ETextHistoryType.TextGenerator;
                    result.TextData.FromSimpleString(txt);
                    break;

            }
            return result;
        }

        private string WriteHeader()
        {
            if (SourceStringToImplantIntoHistory is { } || Namespace is { } || Key is { })
                return $"old-header=(`{Flags}` `{SourceStringToImplantIntoHistory}` `{Namespace}` `{Key}`)";
            else
                return $"header=`{Flags}`";
        }

        private void ReadHeader(string text)
        {
            if (text.Contains("old-header="))
            {
                string header = text.GetNonNull("old-header=(`{0}`)", x => x);
                string[] parts = header.Split("` `");
                Flags = Enum.Parse<ETextFlag>(parts[0]);
                SourceStringToImplantIntoHistory = new FString(parts[1]);
                Namespace = new FTextKey(parts[2]);
                Key = new FTextKey(parts[3]);
            }
            else if (text.Contains("header=`"))
            {
                Flags = text.GetNonNull("header=`{0}`", x => Enum.Parse<ETextFlag>(x));
            }
        }
        #endregion
    }

    public class FTextJsonConverter : JsonConverter<FText>
    {
        public override FText Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return FText.FromSimpleString(reader.GetString()!);
        }

        public override void Write(Utf8JsonWriter writer, FText value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToSimpleString());
        }
    }
    #endregion

    public class FNumberFormattingOptions : ITransferable
    {
        public bool AlwaysSign;
        public bool UseGrouping;
        public ERoundingMode RoundingMode;
        public int32 MinimumIntegralDigits;
        public int32 MaximumIntegralDigits;
        public int32 MinimumFractionalDigits;
        public int32 MaximumFractionalDigits;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FNumberFormattingOptions& Value)")]
        public ITransferable Move(Transfer transfer)
        {
            if (transfer.Supports.AddedAlwaysSignNumberFormattingOption)
                transfer.Move(ref AlwaysSign);
            transfer.Move(ref UseGrouping);
            transfer.MoveEnum(ref RoundingMode);
            transfer.Move(ref MinimumIntegralDigits);
            transfer.Move(ref MaximumIntegralDigits);
            transfer.Move(ref MinimumFractionalDigits);
            transfer.Move(ref MaximumFractionalDigits);
            return this;
        }

        public override string ToString() => $"{AlwaysSign} {UseGrouping} {RoundingMode} {MinimumIntegralDigits} {MaximumIntegralDigits} {MinimumFractionalDigits} {MaximumFractionalDigits}";

        public static FNumberFormattingOptions FromString(string text)
        {
            if (string.IsNullOrEmpty(text))
                return null;
            string[] v = text.Split(" ");
            return new FNumberFormattingOptions
            {
                AlwaysSign = bool.Parse(v[0]),
                UseGrouping = bool.Parse(v[1]),
                RoundingMode = Enum.Parse<ERoundingMode>(v[2]),
                MinimumIntegralDigits = int.Parse(v[3]),
                MaximumIntegralDigits = int.Parse(v[4]),
                MinimumFractionalDigits = int.Parse(v[5]),
                MaximumFractionalDigits = int.Parse(v[6]),
            };
        }
    }

    #region Enums
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

    public enum ETextFlag : uint32
    {
        None = 0,
        Transient = (1 << 0),
        CultureInvariant = (1 << 1),
        ConvertedProperty = (1 << 2),
        Immutable = (1 << 3),
        InitializedFromString = (1 << 4),
    }

    public enum ERoundingMode : byte
    {
        HalfToEven,
        HalfFromZero,
        HalfToZero,
        FromZero,
        ToZero,
        ToNegativeInfinity,
        ToPositiveInfinity,
    }
    #endregion
}

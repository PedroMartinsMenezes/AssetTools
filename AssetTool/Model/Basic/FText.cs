using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{TextData?.Value ?? SourceStringToImplantIntoHistory?.Value ?? Key?.Value}")]
    public class FText : ITransferable
    {
        public ETextFlag Flags;
        public ETextHistoryType HistoryType;
        public FBool bHasCultureInvariantString;
        public ITextData TextData;
        public FString SourceStringToImplantIntoHistory;
        public FTextKey Namespace;
        public FTextKey Key;
        [JsonIgnore] public int EndPosition;

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

        public override string ToString()
        {
            StringBuilder builder = new();
            switch (HistoryType)
            {
                case ETextHistoryType.Base:
                    builder.Append($"text-base {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.NamedFormat:
                    builder.Append($"text-named-format {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.OrderedFormat:
                    builder.Append($"text-ordered-format {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.ArgumentFormat:
                    builder.Append($"text-argument-format {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.AsNumber:
                    builder.Append($"text-as-number {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.AsPercent:
                    builder.Append($"text-as-percent {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.AsCurrency:
                    builder.Append($"text-as-currency {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.AsDate:
                    builder.Append($"text-as-date {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.AsTime:
                    builder.Append($"text-as-time {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.AsDateTime:
                    builder.Append($"text-as-date-time {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.Transform:
                    builder.Append($"text-transform {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.StringTableEntry:
                    builder.Append($"text-string-table-entry {WriteHeader()} | {TextData}");
                    break;
                case ETextHistoryType.TextGenerator:
                    builder.Append($"text-generator {WriteHeader()} | {TextData}");
                    break;
                default:
                    if (bHasCultureInvariantString)
                    {
                        builder.Append($"text {WriteHeader()} | {TextData}");
                    }
                    else
                    {
                        builder.Append("null");
                        return builder.ToString();
                    }
                    break;
            }
            return builder.ToString();
        }

        public static FText FromString(string text)
        {
            if (text == "null")
            {
                return new FText { HistoryType = (ETextHistoryType)(-1) };
            }
            string type = text.Substring(0, text.IndexOf(' '));
            switch (type)
            {
                case "text-base":
                    return FromTextBase(text.Substring(text.IndexOf(' ') + 1));
                case "text-named-format":
                    return FromNamedFormat(text.Substring(text.IndexOf(' ') + 1));
                case "text-ordered-format":
                    return FromOrderedFormat(text.Substring(text.IndexOf(' ') + 1));
                case "text-argument-format":
                    return FromArgumentDataFormat(text.Substring(text.IndexOf(' ') + 1));
                case "text-as-number":
                    return FromNumber(text.Substring(text.IndexOf(' ') + 1));
                case "text-as-percent":
                    return FromPercent(text.Substring(text.IndexOf(' ') + 1));
                case "text-as-currency":
                    return FromCurrency(text.Substring(text.IndexOf(' ') + 1));
                case "text-as-date":
                    return FromDate(text.Substring(text.IndexOf(' ') + 1));
                case "text-as-time":
                    return FromTime(text.Substring(text.IndexOf(' ') + 1));
                case "text-as-date-time":
                    return FromDateTime(text.Substring(text.IndexOf(' ') + 1));
                case "text-transform":
                    return FromTransform(text.Substring(text.IndexOf(' ') + 1));
                case "text-string-table-entry":
                    return FromStringTableEntry(text.Substring(text.IndexOf(' ') + 1));
                case "text-generator":
                    return FromGenerator(text.Substring(text.IndexOf(' ') + 1));
                case "text":
                    return FromCultureInvariantString(text.Substring(text.IndexOf(' ') + 1));
            }
            return null;
        }

        public string WriteHeader()
        {
            StringBuilder builder = new();

            builder.Append($"Flags('{Flags}') ");

            if (SourceStringToImplantIntoHistory is { } || Namespace is { } || Key is { })
            {
                if (SourceStringToImplantIntoHistory is { })
                    builder.Append($"SourceStringToImplantIntoHistory('{SourceStringToImplantIntoHistory}') ");
                if (Namespace is { })
                    builder.Append($"Namespace('{Namespace.Value}') ");
                if (Key is { })
                    builder.Append($"Key('{Key.Value}') ");
            }

            return builder.ToString();
        }

        private void ReadHeader(string text)
        {
            EndPosition = TextData.EndPosition;
            (int i, int a, int b) = (0, 0, 0);
            int pipePosition = text.IndexOf(" | ");
            if ((i = text.IndexOf("Flags('")) >= 0 && i < pipePosition)
            {
                a = i + "Flags('".Length;
                EndPosition = b = text.IndexOf("')", a);
                Flags = Enum.Parse<ETextFlag>(text[a..b]);
            }
            if ((i = text.IndexOf("SourceStringToImplantIntoHistory('")) >= 0 && i < pipePosition)
            {
                a = i + "SourceStringToImplantIntoHistory('".Length;
                EndPosition = b = text.IndexOf("')", a);
                SourceStringToImplantIntoHistory = new FString(text[a..b]);
            }
            if ((i = text.IndexOf("Namespace('")) >= 0 && i < pipePosition)
            {
                a = i + "Namespace('".Length;
                EndPosition = b = text.IndexOf("')", a);
                Namespace = new FTextKey(text[a..b]);
            }
            if ((i = text.IndexOf("Key('")) >= 0 && i < pipePosition)
            {
                a = i + "Key('".Length;
                EndPosition = b = text.IndexOf("')", a);
                Key = new FTextKey(text[a..b]);
            }
        }

        private static FText FromTextBase(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.Base;
            result.TextData = FTextHistory_Base.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromNamedFormat(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.NamedFormat;
            result.TextData = FTextHistory_NamedFormat.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromOrderedFormat(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.OrderedFormat;
            result.TextData = FTextHistory_OrderedFormat.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromArgumentDataFormat(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.ArgumentFormat;
            result.TextData = FTextHistory_ArgumentDataFormat.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromNumber(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsNumber;
            result.TextData = FTextHistory_AsNumber.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromPercent(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsPercent;
            result.TextData = FTextHistory_AsPercent.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromCurrency(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsCurrency;
            result.TextData = FTextHistory_AsCurrency.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromDate(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsDate;
            result.TextData = FTextHistory_AsDate.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromTime(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsTime;
            result.TextData = FTextHistory_AsTime.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromDateTime(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsDateTime;
            result.TextData = FTextHistory_AsDateTime.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromTransform(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.Transform;
            result.TextData = FTextHistory_Transform.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromStringTableEntry(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.StringTableEntry;
            result.TextData = FTextHistory_StringTableEntry.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromGenerator(string text)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.TextGenerator;
            result.TextData = FTextHistory_TextGenerator.FromString(text);
            result.ReadHeader(text);
            return result;
        }

        private static FText FromCultureInvariantString(string text)
        {
            FText result = new();
            result.HistoryType = (ETextHistoryType)(-1);
            FTextHistory_Base textData = FTextHistory_Base.FromString(text);
            result.TextData = textData;
            result.ReadHeader(text);
            if (textData.Key is { } || textData.Namespace is { } || textData.SourceString is { })
            {
                result.bHasCultureInvariantString = true;
            }
            return result;
        }
    }

    public enum ETextHistoryType : sbyte
    {
        Base,
        NamedFormat,
        OrderedFormat,
        ArgumentFormat,
        AsNumber,
        AsPercent,
        AsCurrency,
        AsDate,
        AsTime,
        AsDateTime,
        Transform,
        StringTableEntry,
        TextGenerator,
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

    public class FNumberFormattingOptions : ITransferable
    {
        public FBool AlwaysSign;
        public FBool UseGrouping;
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
            string[] v = text.Split(' ');
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

    public enum ETextFlag : uint32
    {
        None = 0,
        Transient = (1 << 0),
        CultureInvariant = (1 << 1),
        ConvertedProperty = (1 << 2),
        Immutable = (1 << 3),
        InitializedFromString = (1 << 4),
    }

    public class FTextJsonConverter : JsonConverter<FText>
    {
        public override FText Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string text = reader.GetString();
            return FText.FromString(text);
        }

        public override void Write(Utf8JsonWriter writer, FText value, JsonSerializerOptions options)
        {
            string text = value.ToString();
            writer.WriteStringValue(text);
        }
    }
}

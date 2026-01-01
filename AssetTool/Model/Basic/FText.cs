using System.Diagnostics;
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
            if (text.Contains("old-header=`"))
            {
                string header = text.GetNonNull("header=(`{0}`)", x => x);
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
            return FText.FromSimpleString(reader.GetString()!);
        }

        public override void Write(Utf8JsonWriter writer, FText value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToSimpleString());
        }
    }
}

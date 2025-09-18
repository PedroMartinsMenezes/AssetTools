using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{TextData?.Value}")]
    public class FText : ITransferible
    {
        public ETextFlag Flags;
        public ETextHistoryType HistoryType;
        public FBool bHasCultureInvariantString;
        public ITextData TextData;
        public FString SourceStringToImplantIntoHistory;
        public FTextKey Namespace;
        public FTextKey Key;

        [Location("void FText::SerializeText(FStructuredArchive::FSlot Slot, FText& Value)")]
        public ITransferible Move(Transfer transfer)
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

    public class FNumberFormattingOptions : ITransferible
    {
        public FBool AlwaysSign;
        public FBool UseGrouping;
        public ERoundingMode RoundingMode;
        public int32 MinimumIntegralDigits;
        public int32 MaximumIntegralDigits;
        public int32 MinimumFractionalDigits;
        public int32 MaximumFractionalDigits;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FNumberFormattingOptions& Value)")]
        public ITransferible Move(Transfer transfer)
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
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                return new FText { HistoryType = (ETextHistoryType)(-1) };
            }
            else
            {
                reader.Read();
                FText value = new FText();
                while (reader.TokenType != JsonTokenType.EndObject)
                {
                    string propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        case "Flags":
                            value.Flags = Enum.Parse<ETextFlag>(reader.GetString());
                            break;
                        case "HistoryType":
                            value.HistoryType = Enum.Parse<ETextHistoryType>(reader.GetString());
                            break;
                        case "bHasCultureInvariantString":
                            value.bHasCultureInvariantString = new FBool(reader.GetString());
                            break;
                        case "TextData":
                            value.TextData = JsonSerializer.Deserialize<ITextData>(ref reader, options);
                            break;
                        case "TextData!":
                            value.TextData = FTextHistory_Base.FromString(reader.GetString());
                            break;
                    }
                    reader.Read();
                }
                return value;
            }
        }

        public override void Write(Utf8JsonWriter writer, FText value, JsonSerializerOptions options)
        {
            if (value.Flags == 0 && (int)value.HistoryType == -1 && !value.bHasCultureInvariantString)
            {
                writer.WriteStringValue("null");
            }
            else
            {
                writer.WriteStartObject();
                writer.WriteString("Flags", value.Flags.ToString());
                writer.WriteString("HistoryType", value.HistoryType.ToString());
                writer.WriteString("bHasCultureInvariantString", value.bHasCultureInvariantString.ToString());

                if (value.TextData is FTextHistory_Base textData)
                {
                    writer.WriteString("TextData!", textData.ToString());
                }
                else
                {
                    writer.WritePropertyName("TextData");
                    JsonSerializer.Serialize(writer, value.TextData, options);
                }

                writer.WriteEndObject();
            }

        }
    }
}



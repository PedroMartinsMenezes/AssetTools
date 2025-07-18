using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{TextData?.Value}")]
    public class FText : ITransferible
    {
        public UInt32 Flags;
        public ETextHistoryType HistoryType;
        public FBool bHasCultureInvariantString;
        public ITextData TextData;

        [Location("void FText::SerializeText(FStructuredArchive::FSlot Slot, FText& Value)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Flags);
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
                    if (transfer.GlobalObjects.CustomVer(FEditorObjectVersion.Guid) >= (int)FEditorObjectVersion.Enums.CultureInvariantTextSerializationKeyStability)
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
                reader.Read(); // Move to first property
                FText value = new FText();
                while (reader.TokenType != JsonTokenType.EndObject)
                {
                    string propertyName = reader.GetString();
                    reader.Read(); // Move to value
                    switch (propertyName)
                    {
                        case "Flags":
                            value.Flags = reader.GetUInt32();
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
                    }
                    reader.Read(); // Move to next property or end object
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
                writer.WriteNumber("Flags", value.Flags);
                writer.WriteString("HistoryType", value.HistoryType.ToString());
                writer.WriteString("bHasCultureInvariantString", value.bHasCultureInvariantString.ToString());

                writer.WritePropertyName("TextData");
                JsonSerializer.Serialize(writer, value.TextData, options);

                writer.WriteEndObject();
            }

        }
    }
}



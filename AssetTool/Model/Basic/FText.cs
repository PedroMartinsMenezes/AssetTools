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

        [Location("void FText::SerializeText(FStructuredArchive::FSlot Slot, FText& Value)")]
        public ITransferable Move(Transfer transfer)
        {
            long[] offsets = [0, 0];
            if (AppConfig.DebugFText)
                offsets[0] = transfer.Position;

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
            if (AppConfig.DebugFText && transfer.IsReading)
            {
                offsets[1] = transfer.Position;
                string index = transfer.GlobalObjects.CurrentObject.Index.ToString();
                AppConfig.DebugCheckMember = true;
                bool success = this.AutoCheck<FText>(transfer, index, transfer.Stream, offsets);
                AppConfig.DebugCheckMember = false;
            }

            return this;
        }

        #region Simplified Json to use in JsonConverter
        [JsonIgnore] public bool IsNull => Flags == ETextFlag.None && HistoryType == (ETextHistoryType)(-1) && !bHasCultureInvariantString && TextData == null && SourceStringToImplantIntoHistory == null && Namespace == null && Key == null;

        public string GetSourceString() => (TextData as FTextHistory_Base)?.SourceString?.ToString();

        public string GetId() => (TextData as FTextHistory_Base)?.Key?.ToString();

        public string GetNamespace() => (TextData as FTextHistory_Base)?.Namespace?.ToString();

        public object ToStringOrObject()
        {
            (string key, object value) = (null, null);
            switch (HistoryType)
            {
                case ETextHistoryType.Base:
                    (key, value) = ($"text-base {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.NamedFormat:
                    (key, value) = ($"text-named-format {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.OrderedFormat:
                    (key, value) = ($"text-ordered-format {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.ArgumentFormat:
                    (key, value) = ($"text-argument-format {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.AsNumber:
                    (key, value) = ($"text-as-number {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.AsPercent:
                    (key, value) = ($"text-as-percent {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.AsCurrency:
                    (key, value) = ($"text-as-currency {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.AsDate:
                    (key, value) = ($"text-as-date {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.AsTime:
                    (key, value) = ($"text-as-time {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.AsDateTime:
                    (key, value) = ($"text-as-date-time {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.Transform:
                    (key, value) = ($"text-transform {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.StringTableEntry:
                    (key, value) = ($"text-string-table-entry {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                case ETextHistoryType.TextGenerator:
                    (key, value) = ($"text-generator {WriteHeader()}", TextData?.ToStringOrObject());
                    break;
                default:
                    (key, value) = ($"text {WriteHeader()}", bHasCultureInvariantString ? TextData?.ToStringOrObject() : null);
                    break;
            }
            if (value is null)
                return key;
            else if (value is string)
                return $"{key} | {value}";
            else
                return new Dictionary<string, object> { { key, value } };
        }

        public static FText FromStringOrObject(object obj)
        {
            string type = null;
            Dictionary<string, object> dict = null;
            if (obj is string txt)
            {
                type = txt.Substring(0, txt.IndexOf(" "));
            }
            else
            {
                dict = obj as Dictionary<string, object>;
                string key = dict.First().Key;
                type = key.Substring(0, key.IndexOf(" "));
            }
            switch (type)
            {
                case "text-base":
                    return FromTextBase(obj.ToString());
                case "text-named-format":
                    return FromNamedFormat(obj);
                case "text-ordered-format":
                    return FromOrderedFormat(dict);
                case "text-argument-format":
                    return FromArgumentDataFormat(dict);
                case "text-as-number":
                    return FromNumber(obj);
                case "text-as-percent":
                    return FromPercent(obj);
                case "text-as-currency":
                    return FromCurrency(obj);
                case "text-as-date":
                    return FromDate(obj);
                case "text-as-time":
                    return FromTime(obj);
                case "text-as-date-time":
                    return FromDateTime(obj);
                case "text-transform":
                    return FromTransform(obj);
                case "text-string-table-entry":
                    return FromStringTableEntry(obj);
                case "text-generator":
                    return FromGenerator(obj);
                case "text":
                    return FromCultureInvariantString(obj.ToString());
            }
            return null;
        }

        private string WriteHeader()
        {
            StringBuilder builder = new();

            builder.Append($"Flags(`{Flags}`) ");

            if (SourceStringToImplantIntoHistory is { } || Namespace is { } || Key is { })
            {
                if (SourceStringToImplantIntoHistory is { })
                    builder.Append($"SourceStringToImplantIntoHistory(`{SourceStringToImplantIntoHistory}`) ");
                if (Namespace is { })
                    builder.Append($"Namespace(`{Namespace.Value}`) ");
                if (Key is { })
                    builder.Append($"Key(`{Key.Value}`) ");
            }

            return builder.ToString();
        }

        private void ReadHeader(string text)
        {
            if (text.Contains("|"))
                text = text.Substring(0, text.IndexOf("|"));

            if (JsonSerializerExt.GetField(text, "Flags(`", "`)", out string flags) && flags.Length > 0)
                Flags = Enum.Parse<ETextFlag>(flags);

            if (JsonSerializerExt.GetField(text, "SourceStringToImplantIntoHistory(`", "`)", out string sourceStringToImplantIntoHistory) && sourceStringToImplantIntoHistory.Length > 0)
                SourceStringToImplantIntoHistory = new FString(sourceStringToImplantIntoHistory);

            if (JsonSerializerExt.GetField(text, "Namespace(`", "`)", out string ns) && ns.Length > 0)
                Namespace = new FTextKey(ns);

            if (JsonSerializerExt.GetField(text, "Key(`", "`)", out string key) && key.Length > 0)
                Key = new FTextKey(key);
        }

        private static FText FromTextBase(string obj)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.Base;
            result.TextData = FTextHistory_Base.FromStringOrObject(obj);
            result.ReadHeader(obj);
            return result;
        }

        private static FText FromNamedFormat(object obj)
        {
            if (obj is string str)
            {
                FText result = new();
                result.HistoryType = ETextHistoryType.NamedFormat;
                result.TextData = FTextHistory_NamedFormat.FromString(str);
                result.ReadHeader(str);
                return result;
            }
            else
            {
                Dictionary<string, object> dict = obj as Dictionary<string, object>;
                FText result = new();
                result.HistoryType = ETextHistoryType.NamedFormat;
                result.TextData = FTextHistory_NamedFormat.FromStringOrObject(dict.First().Value.ToObject<Dictionary<string, JsonElement>>());
                result.ReadHeader(dict.First().Key);
                return result;
            }
        }

        private static FText FromOrderedFormat(Dictionary<string, object> dict)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.OrderedFormat;
            result.TextData = FTextHistory_OrderedFormat.FromStringOrObject(dict.First().Value.ToObject<Dictionary<string, JsonElement>>());
            result.ReadHeader(dict.First().Key);
            return result;
        }

        private static FText FromArgumentDataFormat(Dictionary<string, object> dict)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.ArgumentFormat;
            result.TextData = FTextHistory_ArgumentDataFormat.FromStringOrObject(dict.First().Value.ToObject<Dictionary<string, JsonElement>>());
            result.ReadHeader(dict.First().Key);
            return result;
        }

        private static FText FromNumber(object obj)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsNumber;
            result.TextData = FTextHistory_AsNumber.FromStringOrObject<FTextHistory_AsNumber>(obj);
            result.ReadHeader(obj.ToString());
            return result;
        }

        private static FText FromPercent(object obj)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsPercent;
            result.TextData = FTextHistory_AsPercent.FromStringOrObject<FTextHistory_AsPercent>(obj);
            result.ReadHeader(obj.ToString());
            return result;
        }

        private static FText FromCurrency(object obj)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsCurrency;
            result.TextData = FTextHistory_AsCurrency.FromStringOrObject<FTextHistory_AsCurrency>(obj);
            result.ReadHeader(obj.ToString());
            return result;
        }

        private static FText FromDate(object obj)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsDate;
            result.TextData = FTextHistory_AsDate.FromStringOrObject(obj.ToString());
            result.ReadHeader(obj.ToString());
            return result;
        }

        private static FText FromTime(object obj)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsTime;
            result.TextData = FTextHistory_AsTime.FromStringOrObject(obj.ToString());
            result.ReadHeader(obj.ToString());
            return result;
        }

        private static FText FromDateTime(object obj)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.AsDateTime;
            result.TextData = FTextHistory_AsDateTime.FromStringOrObject(obj.ToString());
            result.ReadHeader(obj.ToString());
            return result;
        }

        private static FText FromTransform(object obj)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.Transform;
            result.TextData = FTextHistory_Transform.FromStringOrObject(obj);
            result.ReadHeader(obj.ToString());
            return result;
        }

        private static FText FromStringTableEntry(object obj)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.StringTableEntry;
            result.TextData = FTextHistory_StringTableEntry.FromStringOrObject(obj.ToString());
            result.ReadHeader(obj.ToString());
            return result;
        }

        private static FText FromGenerator(object obj)
        {
            FText result = new();
            result.HistoryType = ETextHistoryType.TextGenerator;
            result.TextData = FTextHistory_TextGenerator.FromStringOrObject(obj.ToString());
            result.ReadHeader(obj.ToString());
            return result;
        }

        private static FText FromCultureInvariantString(string obj)
        {
            FText result = new();
            result.HistoryType = (ETextHistoryType)(-1);
            FTextHistory_Base textData = FTextHistory_Base.FromStringOrObject(obj);
            result.TextData = textData;
            result.ReadHeader(obj);
            result.bHasCultureInvariantString = textData?.Key is { } || textData?.Namespace is { } || textData?.SourceString is { };
            return result;
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
            if (reader.TokenType == JsonTokenType.String)
            {
                return FText.FromStringOrObject(reader.GetString());
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                var dict = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
                return FText.FromStringOrObject(dict);
            }
            else
            {
                throw new JsonException($"FText should be a string or an object. Received a {reader.TokenType}");
            }
        }

        public override void Write(Utf8JsonWriter writer, FText value, JsonSerializerOptions options)
        {
            object obj = value.ToStringOrObject();
            if (obj is string str)
            {
                writer.WriteStringValue(str);
            }
            else
            {
                var dict = obj as Dictionary<string, object>;
                JsonSerializer.Serialize(writer, dict, options);
            }
        }
    }
}

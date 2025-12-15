using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FTextHistory : ITextData
    {
    }

    public class FTextHistory_Generated : FTextHistory
    {
        [Location("void FTextHistory_Generated::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FTextHistory_FormatNumber : FTextHistory_Generated
    {
        public FFormatArgumentValue SourceValue;
        public FBool bHasFormatOptions;
        public FNumberFormattingOptions Options;
        public FString CultureName;

        [Location("void FTextHistory_FormatNumber::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SourceValue);
            transfer.Move(ref bHasFormatOptions);
            if (bHasFormatOptions)
            {
                transfer.Move(ref Options);
            }
            transfer.Move(ref CultureName);
            return this;
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            builder.Append($"SourceValue('{SourceValue}') bHasFormatOptions('{bHasFormatOptions}') CultureName('{CultureName}') Options('{Options}')");
            return builder.ToString();
        }

        public static T FromString<T>(string text) where T : FTextHistory_FormatNumber, new()
        {
            T result = new();
            (int i, int a, int b) = (0, 0, 0);
            if ((i = text.IndexOf("SourceValue('")) >= 0)
            {
                a = i + "SourceValue('".Length;
                result.EndPosition = b = text.IndexOf("')", a);
                result.SourceValue = FFormatArgumentValue.FromString(text[a..b]);
            }
            if ((i = text.IndexOf("bHasFormatOptions('")) >= 0)
            {
                a = i + "bHasFormatOptions('".Length;
                result.EndPosition = b = text.IndexOf("')", a);
                result.bHasFormatOptions = new FBool(text[a..b]);
            }
            if ((i = text.IndexOf("CultureName('")) >= 0)
            {
                a = i + "CultureName('".Length;
                result.EndPosition = b = text.IndexOf("')", a);
                result.CultureName = new FString(text[a..b]);
            }
            if ((i = text.IndexOf("Options('")) >= 0)
            {
                a = i + "Options('".Length;
                result.EndPosition = b = text.IndexOf("')", a);
                result.Options = FNumberFormattingOptions.FromString(text[a..b]);
            }
            return result;
        }
    }

    [DebuggerDisplay("Key('{Key}') Namespace('{Namespace}') SourceString('{SourceString}')")]
    public class FTextHistory_Base : FTextHistory
    {
        public FTextKey Namespace;
        public FTextKey Key;
        public FString SourceString;
        [JsonIgnore] public override string Value => SourceString?.Value;

        [Location("void FTextHistory_Base::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            transfer.Move(ref Namespace);
            transfer.Move(ref Key);
            transfer.Move(ref SourceString);
            return this;
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            if (Key is { })
                builder.Append($"Key('{Key}') ");
            if (Namespace is { })
                builder.Append($"Namespace('{Namespace}') ");
            builder.Append($"SourceString('{SourceString}') ");
            return builder.ToString();
        }

        public static FTextHistory_Base FromString(string text)
        {
            FTextHistory_Base result = new();
            (int i, int a, int b) = (0, 0, 0);
            if ((i = text.IndexOf("Key('")) >= 0)
            {
                a = i + "Key('".Length;
                result.EndPosition = b = text.IndexOf("')", a);
                result.Key = new FTextKey(text[a..b]);
            }
            if ((i = text.IndexOf("Namespace('")) >= 0)
            {
                a = i + "Namespace('".Length;
                result.EndPosition = b = text.IndexOf("')", a);
                result.Namespace = new FTextKey(text[a..b]);
            }
            if ((i = text.IndexOf("SourceString('")) >= 0)
            {
                a = i + "SourceString('".Length;
                result.EndPosition = b = text.IndexOf("')", a);
                result.SourceString = new FString(text[a..b]);
            }
            return result;
        }
    }

    public class FTextHistory_NamedFormat : FTextHistory_Generated
    {
        public FText SourceFmt;
        public Dictionary<FString, FFormatArgumentValue> Arguments = [];

        [Location("void FTextHistory_NamedFormat::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            transfer.Move(ref SourceFmt);
            transfer.Move(ref Arguments);
            return this;
        }

        public override string ToString()
        {
            string keys = string.Join(' ', Arguments.Keys.Select(x => $"'{x}'"));
            string values = string.Join(' ', Arguments.Values.Select(x => $"'{x}'"));
            string result = $"SourceFmt('{SourceFmt}') Keys({keys}) Values({values})";
            return result;
        }

        public static FTextHistory_NamedFormat FromString(string text)
        {
            FTextHistory_NamedFormat result = new();
            List<FString> keys = [];
            List<FFormatArgumentValue> values = [];
            (int i, int i1, int i2, int a, int b) = (0, 0, 0, 0, 0);
            if ((i = text.IndexOf("SourceFmt('")) >= 0)
            {
                a = i + "SourceFmt('".Length;
                b = text.IndexOf(" ')", a);
                result.SourceFmt = FText.FromString(text[a..b]);
            }
            if ((i = text.IndexOf("Keys('")) >= 0)
            {
                a = i + "Keys('".Length;
                do
                {
                    (i1, i2) = (text.IndexOf("' '", a), text.IndexOf("')", a));
                    result.EndPosition = b = (i1 > 0 && i1 < i2) ? i1 : i2;
                    keys.Add(new FString(text[a..b]));
                    a = b + 3;
                }
                while (i1 > 0 && i1 < i2);
            }
            if ((i = text.IndexOf("Values('")) >= 0)
            {
                a = i + "Values('".Length;
                do
                {
                    (i1, i2) = (text.IndexOf("' '", a), text.IndexOf(" ')", a));
                    result.EndPosition = b = (i1 > 0 && i1 < i2) ? i1 : i2;
                    var value = FFormatArgumentValue.FromString(text[a..b]);
                    values.Add(value);
                    a = b + 3;
                }
                while (i1 > 0 && i1 < i2);
            }
            if (keys.Count == values.Count)
            {
                for (int index = 0; index < keys.Count; index++)
                {
                    result.Arguments.Add(keys[index], values[index]);
                }
            }
            return result;
        }
    }

    public class FTextHistory_OrderedFormat : FTextHistory_Generated
    {
        public FText FormatText;
        public List<FFormatArgumentValue> Arguments = [];

        [Location("void FTextHistory_OrderedFormat::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref FormatText);
            transfer.Move(ref Arguments);
            return this;
        }

        public override string ToString()
        {
            string args = string.Join(' ', Arguments.Select(x => $"'{x}'"));
            return $"FormatText('{FormatText}') Arguments({args})";
        }

        public static FTextHistory_OrderedFormat FromString(string text)
        {
            FTextHistory_OrderedFormat result = new();
            (int i, int i1, int i2, int a, int b) = (0, 0, 0, 0, 0);
            if ((i = text.IndexOf("FormatText('")) >= 0)
            {
                a = i + "FormatText('".Length;
                result.FormatText = FText.FromString(text[a..]);
            }
            if ((i = text.IndexOf("Arguments('")) >= 0)
            {
                a = i + "Arguments('".Length;
                do
                {
                    (i1, i2) = (text.IndexOf("' '", a), text.IndexOf(" ')", a));
                    result.EndPosition = b = (i1 > 0 && i1 < i2) ? i1 : i2;
                    var value = FFormatArgumentValue.FromString(text[a..b]);
                    result.Arguments.Add(value);
                    a = b + 3;
                }
                while (i1 > 0 && i1 < i2);
            }
            return result;
        }
    }

    public class FTextHistory_ArgumentDataFormat : FTextHistory_Generated
    {
        public FText FormatText;
        public List<FFormatArgumentData> Arguments;

        [Location("void FTextHistory_ArgumentDataFormat::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref FormatText);
            transfer.Move(ref Arguments);
            return this;
        }

        public override string ToString()
        {
            string args = string.Join(' ', Arguments.Select(x => $"'{x}'"));
            return $"FormatText('{FormatText}') Arguments({args})";
        }

        public static FTextHistory_ArgumentDataFormat FromString(string text)
        {
            FTextHistory_ArgumentDataFormat result = new();
            (int i, int a, int b) = (0, 0, 0);
            if ((i = text.IndexOf("FormatText('")) >= 0)
            {
                a = i + "FormatText('".Length;
                result.FormatText = FText.FromString(text[a..]);
            }
            if ((i = text.IndexOf("Arguments(")) >= 0)
            {
                a = i + "Keys('".Length;
                while (text.IndexOf("' '", a) < text.IndexOf("')", a))
                {
                    result.Arguments.Add(FFormatArgumentData.FromString(text[a..b]));
                    a = text.IndexOf("' '", a);
                }
            }
            return result;
        }
    }

    public class FTextHistory_AsNumber : FTextHistory_FormatNumber
    {
        [Location("void FTextHistory_AsNumber::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        public static FTextHistory_AsNumber FromString(string text) => FromString<FTextHistory_AsNumber>(text);
    }

    public class FTextHistory_AsPercent : FTextHistory_FormatNumber
    {
        [Location("void FTextHistory_AsPercent::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        public static FTextHistory_AsPercent FromString(string text) => FromString<FTextHistory_AsPercent>(text);
    }

    public class FTextHistory_AsCurrency : FTextHistory_FormatNumber
    {
        public FString CurrencyCode;

        [Location("void FTextHistory_AsCurrency::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            if (transfer.Supports.VER_UE4_ADDED_CURRENCY_CODE_TO_FTEXT)
            {
                transfer.Move(ref CurrencyCode);
            }
            base.Move(transfer);
            return this;
        }

        public override string ToString()
        {
            return $"CurrencyCode('{CurrencyCode}') {base.ToString()}";
        }

        public static FTextHistory_AsCurrency FromString(string text)
        {
            var result = FromString<FTextHistory_AsCurrency>(text);
            (int i, int a, int b) = (0, 0, 0);
            if ((i = text.IndexOf("CurrencyCode('")) >= 0)
            {
                a = i + "FormatText('".Length;
                b = text.IndexOf("')", a);
                result.CurrencyCode = new FString(text[a..b]);
            }
            return result;
        }
    }

    public class FTextHistory_AsDate : FTextHistory_Generated
    {
        public FDateTime SourceDateTime;
        public EDateTimeStyle DateStyle;
        public FString TimeZone;
        public FString CultureName;

        [Location("void FTextHistory_AsDate::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SourceDateTime);
            transfer.MoveEnum(ref DateStyle);
            if (transfer.Supports.VER_UE4_FTEXT_HISTORY_DATE_TIMEZONE)
            {
                transfer.Move(ref TimeZone);
            }
            transfer.Move(ref CultureName);
            return this;
        }

        public override string ToString()
        {
            return $"SourceDateTime('{SourceDateTime}') DateStyle('{DateStyle}') TimeZone('{TimeZone}') CultureName('{CultureName}')";
        }

        public static FTextHistory_AsDate FromString(string text)
        {
            FTextHistory_AsDate result = new();
            (int i, int a, int b) = (0, 0, 0);
            if ((i = text.IndexOf("SourceDateTime('")) >= 0)
            {
                a = i + "SourceDateTime('".Length;
                b = text.IndexOf("')", a);
                result.SourceDateTime = FDateTime.FromString(text[a..b]);
            }
            if ((i = text.IndexOf("DateStyle('")) >= 0)
            {
                a = i + "DateStyle('".Length;
                b = text.IndexOf("')", a);
                result.DateStyle = Enum.Parse<EDateTimeStyle>(text[a..b]);
            }
            if ((i = text.IndexOf("TimeZone('")) >= 0)
            {
                a = i + "TimeZone('".Length;
                b = text.IndexOf("')", a);
                result.TimeZone = new FString(text[a..b]);
            }
            if ((i = text.IndexOf("CultureName('")) >= 0)
            {
                a = i + "CultureName('".Length;
                b = text.IndexOf("')", a);
                result.TimeZone = new FString(text[a..b]);
            }
            return result;
        }
    }

    public class FTextHistory_AsTime : FTextHistory_Generated
    {
        public FDateTime SourceDateTime;
        public EDateTimeStyle TimeStyle;
        public FString TimeZone;
        public FString CultureName;

        [Location("void FTextHistory_AsTime::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SourceDateTime);
            transfer.MoveEnum(ref TimeStyle);
            transfer.Move(ref TimeZone);
            transfer.Move(ref CultureName);
            return this;
        }

        public override string ToString()
        {
            return $"SourceDateTime('{SourceDateTime}') TimeStyle('{TimeStyle}') TimeZone('{TimeZone}') CultureName('{CultureName}')";
        }

        public static FTextHistory_AsTime FromString(string text)
        {
            FTextHistory_AsTime result = new();
            (int i, int a, int b) = (0, 0, 0);
            if ((i = text.IndexOf("SourceDateTime('")) >= 0)
            {
                a = i + "SourceDateTime('".Length;
                b = text.IndexOf("')", a);
                result.SourceDateTime = FDateTime.FromString(text[a..b]);
            }
            if ((i = text.IndexOf("TimeStyle('")) >= 0)
            {
                a = i + "TimeStyle('".Length;
                b = text.IndexOf("')", a);
                result.TimeStyle = Enum.Parse<EDateTimeStyle>(text[a..b]);
            }
            if ((i = text.IndexOf("TimeZone('")) >= 0)
            {
                a = i + "TimeZone('".Length;
                b = text.IndexOf("')", a);
                result.TimeZone = new FString(text[a..b]);
            }
            if ((i = text.IndexOf("CultureName('")) >= 0)
            {
                a = i + "CultureName('".Length;
                b = text.IndexOf("')", a);
                result.TimeZone = new FString(text[a..b]);
            }
            return result;
        }
    }

    public class FTextHistory_AsDateTime : FTextHistory_Generated
    {
        public FDateTime SourceDateTime;
        public EDateTimeStyle DateStyle;
        public EDateTimeStyle TimeStyle;
        public FString TimeZone;
        public FString CultureName;

        [Location("void FTextHistory_AsDateTime::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SourceDateTime);
            transfer.MoveEnum(ref DateStyle);
            transfer.MoveEnum(ref TimeStyle);
            transfer.Move(ref TimeZone);
            transfer.Move(ref CultureName);
            return this;
        }

        public override string ToString()
        {
            return $"SourceDateTime('{SourceDateTime}') DateStyle('{DateStyle}') TimeStyle('{TimeStyle}') TimeZone('{TimeZone}') CultureName('{CultureName}')";
        }

        public static FTextHistory_AsDateTime FromString(string text)
        {
            FTextHistory_AsDateTime result = new();
            (int i, int a, int b) = (0, 0, 0);
            if ((i = text.IndexOf("SourceDateTime('")) >= 0)
            {
                a = i + "SourceDateTime('".Length;
                b = text.IndexOf("')", a);
                result.SourceDateTime = FDateTime.FromString(text[a..b]);
            }
            if ((i = text.IndexOf("DateStyle('")) >= 0)
            {
                a = i + "DateStyle('".Length;
                b = text.IndexOf("')", a);
                result.TimeStyle = Enum.Parse<EDateTimeStyle>(text[a..b]);
            }
            if ((i = text.IndexOf("TimeStyle('")) >= 0)
            {
                a = i + "TimeStyle('".Length;
                b = text.IndexOf("')", a);
                result.TimeStyle = Enum.Parse<EDateTimeStyle>(text[a..b]);
            }
            if ((i = text.IndexOf("TimeZone('")) >= 0)
            {
                a = i + "TimeZone('".Length;
                b = text.IndexOf("')", a);
                result.TimeZone = new FString(text[a..b]);
            }
            if ((i = text.IndexOf("CultureName('")) >= 0)
            {
                a = i + "CultureName('".Length;
                b = text.IndexOf("')", a);
                result.TimeZone = new FString(text[a..b]);
            }
            return result;
        }
    }

    public class FTextHistory_Transform : FTextHistory_Generated
    {
        public FText SourceText;
        public ETransformType TransformType;

        [Location("void FTextHistory_Transform::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SourceText);
            transfer.MoveEnum(ref TransformType);
            return this;
        }

        public override string ToString()
        {
            return $"SourceText({SourceText}) TransformType('{TransformType}')";
        }

        public static FTextHistory_Transform FromString(string text)
        {
            FTextHistory_Transform result = new();
            (int i, int a, int b) = (0, 0, 0);
            if ((i = text.IndexOf("SourceText('")) >= 0)
            {
                a = i + "SourceText(".Length;
                result.SourceText = FText.FromString(text[a..]);
            }
            if ((i = text.IndexOf("TransformType('")) >= 0)
            {
                a = i + "TransformType('".Length;
                b = text.IndexOf("')", a);
                result.TransformType = Enum.Parse<ETransformType>(text[a..b]);
            }
            return result;
        }
    }

    public class FTextHistory_StringTableEntry : FTextHistory
    {
        public FName TableId;
        public FString Key;

        [Location("void FTextHistory_StringTableEntry::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            transfer.Move(ref TableId);
            transfer.Move(ref Key);
            return this;
        }

        public override string ToString()
        {
            return $"TableId('{TableId}') Key('{Key}')";
        }

        public static FTextHistory_StringTableEntry FromString(string text)
        {
            FTextHistory_StringTableEntry result = new();
            (int i, int a, int b) = (0, 0, 0);
            if ((i = text.IndexOf("TableId('")) >= 0)
            {
                a = i + "TableId(".Length;
                result.TableId = new FName(text.Substring(a));
            }
            if ((i = text.IndexOf("Key('")) >= 0)
            {
                a = i + "Key('".Length;
                b = text.IndexOf("')", a);
                result.Key = new FString(text[a..b]);
            }
            return result;
        }
    }

    public class FTextHistory_TextGenerator : FTextHistory_Generated
    {
        public FName GeneratorTypeID;
        public uint8[] GeneratorContents;

        [Location("void FTextHistory_TextGenerator::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref GeneratorTypeID);
            if (GeneratorTypeID.IsFilled())
            {
                transfer.Move(ref GeneratorContents);
                throw new NotImplementedException("TextGenerator->Serialize");
            }
            return this;
        }

        public override string ToString()
        {
            return $"GeneratorTypeID('{GeneratorTypeID}') GeneratorContents('{string.Join(' ', GeneratorContents)}')";
        }

        public static FTextHistory_TextGenerator FromString(string text)
        {
            FTextHistory_TextGenerator result = new();
            (int i, int a, int b) = (0, 0, 0);
            if ((i = text.IndexOf("GeneratorTypeID('")) >= 0)
            {
                a = i + "GeneratorTypeID(".Length;
                result.GeneratorTypeID = new FName(text.Substring(a));
            }
            if ((i = text.IndexOf("GeneratorContents('")) >= 0)
            {
                a = i + "GeneratorContents('".Length;
                b = text.IndexOf("')", a);
                result.GeneratorContents = text[a..b].Split(' ').Select(uint8.Parse).ToArray();
            }
            return result;
        }
    }

    public enum ETransformType : uint8
    {
        ToLower,
        ToUpper,
    }
}

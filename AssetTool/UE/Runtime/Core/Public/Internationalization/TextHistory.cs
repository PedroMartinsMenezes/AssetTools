using System.Diagnostics;
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
        public bool bHasFormatOptions;
        public FNumberFormattingOptions Options;
        public FString CultureName;
        public override bool IsSimple() => SourceValue.IsSimple();

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

        public override string ToSimpleString(string header)
        {
            return $"{header} SourceValue«{SourceValue.ToSimpleString()}» bHasFormatOptions=`{bHasFormatOptions}` CultureName=`{CultureName}` Options=`{Options}`";
        }

        public override void FromSimpleString(string txt)
        {
            SourceValue = txt.GetNonNull(" SourceValue«{0}»", (x) => new FFormatArgumentValue().FromSimpleString(x));
            bHasFormatOptions = txt.GetNonNull(" bHasFormatOptions=`{0}`", (x) => bool.Parse(x));
            CultureName = txt.GetNonNull(" CultureName=`{0}`", (x) => new FString(x));
            Options = txt.GetNonNull(" Options=`{0}`", (x) => FNumberFormattingOptions.FromString(x));
        }
    }

    [DebuggerDisplay("Key(`{Key}`) Namespace(`{Namespace}`) SourceString(`{SourceString}`)")]
    public class FTextHistory_Base : FTextHistory
    {
        public FTextKey Namespace;
        public FTextKey Key;
        public FString SourceString;
        [JsonIgnore] public override string Value => SourceString?.Value;
        public override bool IsSimple() => true;

        [Location("void FTextHistory_Base::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            transfer.Move(ref Namespace);
            transfer.Move(ref Key);
            transfer.Move(ref SourceString);
            return this;
        }

        public override string ToSimpleString(string header)
        {
            return $"text-base {header} Key=`{Key}` Namespace=`{Namespace}` SourceString=`{SourceString}`";
        }

        public override void FromSimpleString(string txt)
        {
            Key = txt.GetNonNull(" Key=`{0}`", (x) => new FTextKey(x));
            Namespace = txt.GetNonNull("` Namespace=`{0}`", (x) => new FTextKey(x));
            SourceString = txt.GetNonNull("` SourceString=`{0}`", (x) => new FString(x));
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

        public override bool IsSimple() => Arguments.All(x => x.Value.IsSimple());

        public override string ToSimpleString(string header)
        {
            string sourceFmt = SourceFmt.ToSimpleString();
            string arguments = Arguments.ToSimpleString();
            return $"text-named-format {header} SourceFmt«{sourceFmt}» {arguments}";
        }

        public override void FromSimpleString(string txt)
        {
            SourceFmt = txt.GetNonNull(" SourceFmt«{0}»", (x) => FText.FromSimpleString(x));
            Arguments = FFormatArgumentValueExt.FromStringDictionary(txt);
        }
    }

    public class FTextHistory_OrderedFormat : FTextHistory_Generated
    {
        public FText FormatText;
        public List<FFormatArgumentValue> Arguments = [];
        public override bool IsSimple() => false;

        [Location("void FTextHistory_OrderedFormat::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref FormatText);
            transfer.Move(ref Arguments);
            return this;
        }

        public override string ToSimpleString(string header)
        {
            string formatText = FormatText.ToSimpleString();
            string arguments = Arguments.ToSimpleString();
            return $"text-ordered-format {header} FormatText«{formatText}» {arguments}";
        }

        public override void FromSimpleString(string txt)
        {
            FormatText = txt.GetNonNull(" FormatText«{0}»", (x) => FText.FromSimpleString(x));
            Arguments = FFormatArgumentValueExt.FromStringList(txt);
        }
    }

    public class FTextHistory_ArgumentDataFormat : FTextHistory_Generated
    {
        public FText FormatText;
        public List<FFormatArgumentData> Arguments;
        public override bool IsSimple() => false;

        [Location("void FTextHistory_ArgumentDataFormat::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref FormatText);
            transfer.Move(ref Arguments);
            return this;
        }

        public override string ToSimpleString(string header)
        {
            string formatText = FormatText.ToSimpleString();
            string arguments = Arguments.ToSimpleString();
            return $"text-argument-format {header} FormatText«{formatText}» {arguments}";
        }

        public override void FromSimpleString(string txt)
        {
            FormatText = txt.GetNonNull(" FormatText«{0}»", (x) => FText.FromSimpleString(x));
            Arguments = FFormatArgumentDataExt.FromStringList(txt);
        }
    }

    public class FTextHistory_AsNumber : FTextHistory_FormatNumber
    {
        [Location("void FTextHistory_AsNumber::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        public override string ToSimpleString(string header)
        {
            return $"text-as-number {base.ToSimpleString(header)}";
        }
    }

    public class FTextHistory_AsPercent : FTextHistory_FormatNumber
    {
        [Location("void FTextHistory_AsPercent::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        public override string ToSimpleString(string header)
        {
            return $"text-as-percent {base.ToSimpleString(header)}";
        }
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

        public override string ToSimpleString(string header)
        {
            return $"text-as-currency {base.ToSimpleString(header)} CurrencyCode=`{CurrencyCode}`";
        }

        public override void FromSimpleString(string txt)
        {
            base.FromSimpleString(txt);
            CurrencyCode = txt.GetNonNull(" CurrencyCode=`{0}`", (x) => new FString(x));
        }
    }

    public class FTextHistory_AsDate : FTextHistory_Generated
    {
        public FDateTime SourceDateTime;
        public EDateTimeStyle DateStyle;
        public FString TimeZone;
        public FString CultureName;
        public override bool IsSimple() => true;

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

        public override string ToSimpleString(string header)
        {
            return $"text-as-date {header} SourceDateTime=`{SourceDateTime}` DateStyle=`{DateStyle}` TimeZone=`{TimeZone}` CultureName=`{CultureName}`";
        }

        public override void FromSimpleString(string txt)
        {
            SourceDateTime = txt.GetNonNull(" SourceDateTime=`{0}`", (x) => FDateTime.FromString(x));
            DateStyle = txt.GetNonNull("` DateStyle=`{0}`", (x) => Enum.Parse<EDateTimeStyle>(x));
            TimeZone = txt.GetNonNull("` TimeZone=`{0}`", (x) => new FString(x));
            CultureName = txt.GetNonNull("` CultureName=`{0}`", (x) => new FString(x));
        }
    }

    public class FTextHistory_AsTime : FTextHistory_Generated
    {
        public FDateTime SourceDateTime;
        public EDateTimeStyle TimeStyle;
        public FString TimeZone;
        public FString CultureName;
        public override bool IsSimple() => true;

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

        public override string ToSimpleString(string header)
        {
            return $"text-as-time {header} SourceDateTime=`{SourceDateTime}` TimeStyle=`{TimeStyle}` TimeZone=`{TimeZone}` CultureName=`{CultureName}`";
        }

        public override void FromSimpleString(string txt)
        {
            SourceDateTime = txt.GetNonNull(" SourceDateTime=`{0}`", (x) => FDateTime.FromString(x));
            TimeStyle = txt.GetNonNull("` TimeStyle=`{0}`", (x) => Enum.Parse<EDateTimeStyle>(x));
            TimeZone = txt.GetNonNull("` TimeZone=`{0}`", (x) => new FString(x));
            CultureName = txt.GetNonNull("` CultureName=`{0}`", (x) => new FString(x));
        }
    }

    public class FTextHistory_AsDateTime : FTextHistory_Generated
    {
        public FDateTime SourceDateTime;
        public EDateTimeStyle DateStyle;
        public EDateTimeStyle TimeStyle;
        public FString TimeZone;
        public FString CultureName;
        public override bool IsSimple() => true;

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

        public override string ToSimpleString(string header)
        {
            return $"text-as-date-time {header} SourceDateTime=`{SourceDateTime}` DateStyle=`{DateStyle}` TimeStyle=`{TimeStyle}` TimeZone=`{TimeZone}` CultureName=`{CultureName}`";
        }

        public override void FromSimpleString(string txt)
        {
            SourceDateTime = txt.GetNonNull(" SourceDateTime=`{0}`", (x) => FDateTime.FromString(x));
            DateStyle = txt.GetNonNull("` DateStyle=`{0}`", (x) => Enum.Parse<EDateTimeStyle>(x));
            TimeStyle = txt.GetNonNull("` TimeStyle=`{0}`", (x) => Enum.Parse<EDateTimeStyle>(x));
            TimeZone = txt.GetNonNull("` TimeZone=`{0}`", (x) => new FString(x));
            CultureName = txt.GetNonNull("` CultureName=`{0}`", (x) => new FString(x));
        }
    }

    public class FTextHistory_Transform : FTextHistory_Generated
    {
        public FText SourceText;
        public ETransformType TransformType;
        public override bool IsSimple() => false;

        [Location("void FTextHistory_Transform::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SourceText);
            transfer.MoveEnum(ref TransformType);
            return this;
        }

        public override string ToSimpleString(string header)
        {
            return $"text-transform {header} SourceText«{SourceText.ToSimpleString()}» TransformType=`{TransformType}`";
        }

        public override void FromSimpleString(string txt)
        {
            SourceText = txt.GetNonNull(" SourceText«{0}»", (x) => FText.FromSimpleString(x));
            TransformType = txt.GetNonNull(" TransformType=`{0}`", (x) => Enum.Parse<ETransformType>(x));
        }
    }

    public class FTextHistory_StringTableEntry : FTextHistory
    {
        public FName TableId;
        public FString Key;
        public override bool IsSimple() => true;

        [Location("void FTextHistory_StringTableEntry::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            transfer.Move(ref TableId);
            transfer.Move(ref Key);
            return this;
        }

        public override string ToSimpleString(string header)
        {
            return $"text-string-table-entry {header} TableId=`{TableId}` Key=`{Key}`";
        }

        public override void FromSimpleString(string txt)
        {
            TableId = txt.GetNonNull(" TableId=`{0}`", (x) => new FName(x));
            Key = txt.GetNonNull(" Key=`{0}`", (x) => new FString(x));
        }
    }

    public class FTextHistory_TextGenerator : FTextHistory_Generated
    {
        public FName GeneratorTypeID;
        public uint8[] GeneratorContents;
        public override bool IsSimple() => true;

        [Location("void FTextHistory_TextGenerator::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref GeneratorTypeID);
            if (GeneratorTypeID.IsFilled())
            {
                transfer.Move(ref GeneratorContents);
            }
            return this;
        }

        public override string ToSimpleString(string header)
        {
            return $"text-generator {header} GeneratorTypeID=`{GeneratorTypeID}` GeneratorContents=`{string.Join(" ", GeneratorContents)}`";
        }

        public override void FromSimpleString(string txt)
        {
            GeneratorTypeID = txt.GetNonNull(" GeneratorTypeID=`{0}`", (x) => new FName(x));
            GeneratorContents = txt.GetNonNull("` GeneratorContents=`{0}`", (x) => x.Split(" ").Select(byte.Parse).ToArray());
        }
    }

    public enum ETransformType : uint8
    {
        ToLower,
        ToUpper,
    }
}

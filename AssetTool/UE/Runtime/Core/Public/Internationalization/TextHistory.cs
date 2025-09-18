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
    }

    public class FTextHistory_Base : FTextHistory
    {
        public FTextKey Namespace;
        public FTextKey Key;
        public FString SourceString;

        [JsonIgnore] public override string Value => SourceString?.Value;

        public override string ToString()
        {
            return $"'{Key}' '{Namespace}' '{SourceString}'";
        }

        public static FTextHistory_Base FromString(string value)
        {
            var parts = value.Split("' '");
            return new() { Key = new(parts[0][1..]), Namespace = new(parts[1]), SourceString = new(parts[2][0..^1]) };
        }

        [Location("void FTextHistory_Base::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            transfer.Move(ref Namespace);
            transfer.Move(ref Key);
            transfer.Move(ref SourceString);
            return this;
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
    }

    public class FTextHistory_OrderedFormat : FTextHistory_Generated
    {
        public FText FormatText;
        public List<FFormatArgumentValue> Arguments;

        [Location("void FTextHistory_OrderedFormat::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref FormatText);
            transfer.Move(ref Arguments);
            return this;
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
    }

    public class FTextHistory_AsNumber : FTextHistory_FormatNumber
    {
        [Location("void FTextHistory_AsNumber::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FTextHistory_AsPercent : FTextHistory_FormatNumber
    {
        [Location("void FTextHistory_AsPercent::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            return base.Move(transfer);
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
    }

    public enum ETransformType : uint8
    {
        ToLower,
        ToUpper,
    }
}

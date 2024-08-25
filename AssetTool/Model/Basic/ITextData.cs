using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("class ITextData")]
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FTextHistory), "FTextHistory")]
    [JsonDerivedType(typeof(FTextHistory_Generated), "FTextHistory_Generated")]
    [JsonDerivedType(typeof(FTextHistory_FormatNumber), "FTextHistory_FormatNumber")]
    [JsonDerivedType(typeof(FTextHistory_Base), "FTextHistory_Base")]
    [JsonDerivedType(typeof(FTextHistory_NamedFormat), "FTextHistory_NamedFormat")]
    [JsonDerivedType(typeof(FTextHistory_OrderedFormat), "FTextHistory_OrderedFormat")]
    [JsonDerivedType(typeof(FTextHistory_ArgumentDataFormat), "FTextHistory_ArgumentDataFormat")]
    [JsonDerivedType(typeof(FTextHistory_AsNumber), "FTextHistory_AsNumber")]
    [JsonDerivedType(typeof(FTextHistory_AsPercent), "FTextHistory_AsPercent")]
    [JsonDerivedType(typeof(FTextHistory_AsCurrency), "FTextHistory_AsCurrency")]
    [JsonDerivedType(typeof(FTextHistory_AsDate), "FTextHistory_AsDate")]
    [JsonDerivedType(typeof(FTextHistory_AsTime), "FTextHistory_AsTime")]
    [JsonDerivedType(typeof(FTextHistory_AsDateTime), "FTextHistory_AsDateTime")]
    [JsonDerivedType(typeof(FTextHistory_Transform), "FTextHistory_Transform")]
    [JsonDerivedType(typeof(FTextHistory_StringTableEntry), "FTextHistory_StringTableEntry")]
    [JsonDerivedType(typeof(FTextHistory_TextGenerator), "FTextHistory_TextGenerator")]
    public class ITextData
    {
        public virtual ITextData Move(Transfer transfer) { return this; }
    }

    public class FTextHistory : ITextData
    {
        public string Value;
    }

    [Location("void FTextHistory_Generated::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_Generated : FTextHistory
    {
    }
    [Location("void FTextHistory_FormatNumber::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_FormatNumber : FTextHistory_Generated
    {

    }
    [Location("void FTextHistory_Base::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_Base : FTextHistory
    {
        public FTextKey Namespace;
        public FTextKey Key;
        public FString SourceString;

        public override ITextData Move(Transfer transfer)
        {
            transfer.Move(ref Namespace);
            transfer.Move(ref Key);
            transfer.Move(ref SourceString);
            return this;
        }

    }
    [Location("void FTextHistory_NamedFormat::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_NamedFormat : FTextHistory_Generated
    {
        public FText SourceFmt;
        public Dictionary<FString, FFormatArgumentValue> Arguments = [];

        public override ITextData Move(Transfer transfer)
        {
            transfer.Move(ref SourceFmt);
            Arguments.Resize(transfer);
            foreach (var pair in Arguments)
            {
                transfer.Move(pair.Key);
                pair.Value.Move(transfer);

            }
            return this;
        }
    }
    [Location("void FTextHistory_OrderedFormat::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_OrderedFormat : FTextHistory_Generated
    {

    }
    [Location("void FTextHistory_ArgumentDataFormat::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_ArgumentDataFormat : FTextHistory_Generated
    {

    }
    [Location("void FTextHistory_AsNumber::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_AsNumber : FTextHistory_FormatNumber
    {

    }
    [Location("void FTextHistory_AsPercent::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_AsPercent : FTextHistory_FormatNumber
    {

    }
    [Location("void FTextHistory_AsCurrency::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_AsCurrency : FTextHistory_FormatNumber
    {

    }
    [Location("void FTextHistory_AsDate::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_AsDate : FTextHistory_Generated
    {

    }
    [Location("void FTextHistory_AsTime::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_AsTime : FTextHistory_Generated
    {

    }
    [Location("void FTextHistory_AsDateTime::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_AsDateTime : FTextHistory_Generated
    {

    }
    [Location("void FTextHistory_Transform::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_Transform : FTextHistory_Generated
    {

    }
    [Location("void FTextHistory_StringTableEntry::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_StringTableEntry : FTextHistory
    {

    }
    [Location("void FTextHistory_TextGenerator::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_TextGenerator : FTextHistory_Generated
    {

    }
}

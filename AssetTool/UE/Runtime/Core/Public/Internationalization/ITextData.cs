using System.Text.Json.Serialization;

namespace AssetTool
{
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

        [JsonIgnore] public virtual string Value { get; }

        public virtual string ToSimpleString(string header) => throw new NotImplementedException();

        public virtual void FromSimpleString(string txt) => throw new NotImplementedException();

        public virtual bool IsSimple() => throw new NotImplementedException();
    }
}

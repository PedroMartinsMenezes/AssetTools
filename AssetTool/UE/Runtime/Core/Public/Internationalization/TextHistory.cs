using System.Diagnostics;
using System.Text.Json;
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

        public override object ToStringOrObject()
        {
            var sourceValue = SourceValue.ToStringOrObject();
            if (sourceValue is string)
            {
                return $"SourceValue(`{sourceValue}`) bHasFormatOptions(`{bHasFormatOptions}`) CultureName(`{CultureName}`) Options(`{Options}`)";
            }
            else
            {
                string key = $"bHasFormatOptions(`{bHasFormatOptions}`) CultureName(`{CultureName}`) Options(`{Options}`)";
                return new Dictionary<string, object> { { key, sourceValue } };
            }
        }

        public static T FromStringOrObject<T>(object obj) where T : FTextHistory_FormatNumber, new()
        {
            string s = obj is string ? obj as string : (obj as Dictionary<string, object>).First().Key;
            T result = new();
            (int a, int b, int c, int d) = (s.IndexOf("SourceValue(`"), s.IndexOf("`) bHasFormatOptions(`"), s.IndexOf("`) CultureName(`"), s.IndexOf("`) Options(`"));
            int e = s.IndexOf("`)", d + 1);
            result.bHasFormatOptions = bool.Parse(s[(b + "`) bHasFormatOptions(`".Length)..c]);
            result.CultureName = new FString(s[(c + "`) CultureName(`".Length)..d]);
            result.Options = FNumberFormattingOptions.FromString(s[(d + "`) Options(`".Length)..e]);
            object sourceValue = obj is string ? s[(a + "SourceValue(`".Length)..b] : (obj as Dictionary<string, object>).First().Value;
            result.SourceValue = FFormatArgumentValue.FromStringOrObject(sourceValue);
            return result;
        }
    }

    [DebuggerDisplay("Key(`{Key}`) Namespace(`{Namespace}`) SourceString(`{SourceString}`)")]
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

        public override object ToStringOrObject()
        {
            return $"Key(`{Key}`) Namespace(`{Namespace}`) SourceString(`{SourceString}`)";
        }

        public static FTextHistory_Base FromStringOrObject(string s)
        {
            FTextHistory_Base result = null;
            if (JsonSerializerExt.GetField(s, "Key(`", "`)", out string key) &&
                JsonSerializerExt.GetField(s, "Namespace(`", "`)", out string ns) &&
                JsonSerializerExt.GetField(s, "SourceString(`", "`)", out string sourceString))
            {
                if (key == string.Empty && ns == string.Empty && sourceString == string.Empty)
                {
                    return result;
                }
                result = new();
                result.Key = new FTextKey(key);
                result.Namespace = new FTextKey(ns);
                result.SourceString = new FString(sourceString);
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

        public override object ToStringOrObject()
        {
            if (SourceFmt.Flags == ETextFlag.Immutable)
                return ToStringFormat();
            else if (SourceFmt.Flags == ETextFlag.CultureInvariant)
                return ToStringTooltip();
            else
                throw new NotImplementedException();
        }

        public string ToStringFormat()
        {
            //SourceFmt fields
            string flag = SourceFmt.Flags.ToString();
            string history = SourceFmt.HistoryType.ToString();

            //TextData fields
            var textData = SourceFmt.TextData as FTextHistory_Base;
            string textDataString = textData.SourceString.ToString();
            string textDataKey = textData.Key.ToString();
            string textDataNamespace = textData.Namespace.ToString();

            //Argument fields
            string keys = string.Join("` `", Arguments.Select(x => x.Key.ToString()));
            string args = string.Join("` `", Arguments.Select(x => x.Value.GetText()));
            string ids = string.Join("` `", Arguments.Select(x => x.Value.GetKey()));
            string namespaces = string.Join("` `", Arguments.Select(x => x.Value.GetNamespace()));
            string flags = string.Join("` `", Arguments.Select(x => x.Value.GetFlag()));
            string histories = string.Join("` `", Arguments.Select(x => x.Value.GetHistoryType()));

            string text = $"format SourceFmt(`{flag}` `{history}`) TextData(`{textDataString}` `{textDataKey}` `{textDataNamespace}`) Keys(`{keys}`) Values(`{args}`) Ids(`{ids}`) Namespaces(`{namespaces}`) Flags(`{flags}`) Histories(`{histories}`)";
            return text;
        }

        public string ToStringTooltip()
        {
            string format = (SourceFmt.TextData as FTextHistory_Base).SourceString.ToString();
            string keys = string.Join("` `", Arguments.Select(x => x.Key.ToString()));
            string args = string.Join("` `", Arguments.Select(x => x.Value.TextValue.GetSourceString()));
            string ids = string.Join("` `", Arguments.Select(x => x.Value.TextValue.GetKey()));
            string namespaces = string.Join("` `", Arguments.Select(x => x.Value.TextValue.GetNamespace()));
            string text = $"tooltip `{format}` Keys(`{keys}`) Values(`{args}`) Ids(`{ids}`) Namespaces(`{namespaces}`)";
            return text;
        }

        public static FTextHistory_NamedFormat FromStringOrObject(string text)
        {
            if (text.StartsWith("format "))
                return FromStringFormat(text);
            else if (text.StartsWith("tooltip "))
                return FromStringTooltip(text);
            else
                throw new NotImplementedException();
        }

        public static FTextHistory_NamedFormat FromStringFormat(string text)
        {
            FTextHistory_NamedFormat result = new();

            int[] i = JsonSerializerExt.GetIndices(text, "SourceFmt(`", "`", " `", "`)", "TextData(`", "`", " `", "`", " `", "`)", "Keys(`", "`)", "Values(`", "`)", "Ids(`", "`)", "Namespaces(`", "`)", "Flags(`", "`)", "Histories(`", "`)");

            if (Array.TrueForAll(i, (x) => x > 0))
            {
                string flags = text[i[0]..i[1]];
                string history = text[i[2]..i[3]];

                string textDataString = text[i[4]..i[5]];
                string textDataKey = text[i[6]..i[7]];
                string textDataNamespace = text[i[8]..i[9]];

                FTextHistory_Base textData = new() { SourceString = new FString(textDataString), Key = new FTextKey(textDataKey), Namespace = new FTextKey(textDataNamespace) };

                result.SourceFmt = new FText { Flags = Enum.Parse<ETextFlag>(flags), HistoryType = Enum.Parse<ETextHistoryType>(history), TextData = textData };
                result.Arguments = [];

                string[] argKeys = text[i[10]..i[11]].Split("` `");
                string[] argValues = text[i[12]..i[13]].Split("` `");
                string[] argIds = text[i[14]..i[15]].Split("` `");
                string[] argNamespaces = text[i[16]..i[17]].Split("` `");
                string[] argFlags = text[i[18]..i[19]].Split("` `");
                string[] argHistories = text[i[20]..i[21]].Split("` `");

                for (int j = 0; j < argKeys.Length; j++)
                {
                    if (argFlags[j].Length > 0)
                    {
                        string argText = $"text-base Flags(`{argFlags[j]}`)  | Key(`{argIds[j]}`) Namespace(`{argNamespaces[j]}`) SourceString(`{argValues[j]}`) HistoryType(`{argHistories[j]}`)";
                        if (argHistories[j] == "-1")
                        {
                            argText = argText.Replace("text-base", "text");
                        }
                        FFormatArgumentValue arg = FFormatArgumentValue.FromStringOrObject(argText);
                        result.Arguments.Add(new FString(argKeys[j]), arg);
                    }
                    else
                    {
                        result.Arguments.Add(new FString(argKeys[j]), FFormatArgumentValue.FromStringOrObject(argValues[j]));
                    }

                }
            }
            return result;
        }

        public static FTextHistory_NamedFormat FromStringTooltip(string text)
        {
            FTextHistory_NamedFormat result = new();
            int[] i = JsonSerializerExt.GetIndices(text, "tooltip `", "`", "Keys(`", "`)", "Values(`", "`)", "Ids(`", "`)", "Namespaces(`", "`)");
            if (Array.TrueForAll(i, (x) => x > 0))
            {
                string sourceString = text[i[0]..i[1]];
                FTextHistory_Base textData = new() { SourceString = new FString(sourceString) };
                result.SourceFmt = new FText { Flags = ETextFlag.CultureInvariant, HistoryType = (ETextHistoryType)(-1), bHasCultureInvariantString = true, TextData = textData };
                result.Arguments = [];

                string[] argKeys = text[i[2]..i[3]].Split("` `");
                string[] argValues = text[i[4]..i[5]].Split("` `");
                string[] argIds = text[i[6]..i[7]].Split("` `");
                string[] argNamespaces = text[i[8]..i[9]].Split("` `");

                for (int j = 0; j < argKeys.Length; j++)
                {
                    string argText = $"text-base Flags(`None`)  | Key(`{argIds[j]}`) Namespace(`{argNamespaces[j]}`) SourceString(`{argValues[j]}`)";
                    FFormatArgumentValue arg = FFormatArgumentValue.FromStringOrObject(argText);
                    result.Arguments.Add(new FString(argKeys[j]), arg);
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

        public override object ToStringOrObject()
        {
            Dictionary<string, object> dict = new();
            dict["FormatText"] = FormatText.ToStringOrObject();
            dict["Arguments"] = Arguments.Select(x => x.ToStringOrObject()).ToArray();
            return dict;
        }

        public static FTextHistory_OrderedFormat FromStringOrObject(Dictionary<string, JsonElement> dict)
        {
            FTextHistory_OrderedFormat result = new();
            result.FormatText = FText.FromStringOrObject(dict["FormatText"].ToStringOrObject());
            List<JsonElement> arguments = dict["Arguments"].ToObject<List<JsonElement>>();
            result.Arguments = arguments.Select(x => FFormatArgumentValue.FromStringOrObject(x.ToStringOrObject())).ToList();
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

        public override object ToStringOrObject()
        {
            Dictionary<string, object> dict = new();
            dict["FormatText"] = FormatText.ToStringOrObject();
            dict["Arguments"] = Arguments.Select(x => x.ToStringOrObject()).ToArray();
            return dict;
        }

        public static FTextHistory_ArgumentDataFormat FromStringOrObject(Dictionary<string, JsonElement> dict)
        {
            FTextHistory_ArgumentDataFormat result = new();
            result.FormatText = FText.FromStringOrObject(dict["FormatText"].ToStringOrObject());

            List<JsonElement> arguments = dict["Arguments"].ToObject<List<JsonElement>>();
            result.Arguments = arguments.Select(x => FFormatArgumentData.FromStringOrObject(x.ToStringOrObject())).ToList();

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

        public static FTextHistory_AsNumber FromKeyAndValue(Dictionary<string, object> dict) => FromStringOrObject<FTextHistory_AsNumber>(dict);
    }

    public class FTextHistory_AsPercent : FTextHistory_FormatNumber
    {
        [Location("void FTextHistory_AsPercent::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        public static FTextHistory_AsPercent FromKeyAndValue(Dictionary<string, object> dict) => FromStringOrObject<FTextHistory_AsPercent>(dict);
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

        public override object ToStringOrObject()
        {
            var obj = base.ToStringOrObject();
            if (obj is string s)
            {
                return $"CurrencyCode(`{CurrencyCode}`) {s}";
            }
            else
            {
                var dict = obj as Dictionary<string, object>;
                string key = $"CurrencyCode(`{CurrencyCode}`) {dict.Keys.First()}";
                return new Dictionary<string, object> { { key, dict.Values.First() } };
            }
        }

        public static FTextHistory_AsCurrency FromStringOrObject(object obj)
        {
            FTextHistory_AsCurrency result = FromStringOrObject<FTextHistory_AsCurrency>(obj);
            if (obj is string s)
            {
                int a = s.IndexOf("CurrencyCode(`");
                int b = s.IndexOf("`)", a);
                result.CurrencyCode = new FString(s[(a + "CurrencyCode(`".Length)..b]);
                return result;
            }
            else if (obj is Dictionary<string, object> dict)
            {
                result.CurrencyCode = new FString(dict["CurrencyCode"].ToString());
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

        public override object ToStringOrObject()
        {
            return $"SourceDateTime(`{SourceDateTime}`) DateStyle(`{DateStyle}`) TimeZone(`{TimeZone}`) CultureName(`{CultureName}`)";
        }

        public static FTextHistory_AsDate FromStringOrObject(string s)
        {
            FTextHistory_AsDate result = new();
            (int a, int b, int c, int d) = (s.IndexOf("SourceDateTime(`"), s.IndexOf("`) DateStyle(`"), s.IndexOf("`) TimeZone(`"), s.IndexOf("`) CultureName(`"));
            int e = s.IndexOf("`)", d + 1);
            result.SourceDateTime = new FDateTime { Ticks = long.Parse(s[(a + "SourceDateTime(`".Length)..b]) };
            result.DateStyle = Enum.Parse<EDateTimeStyle>(s[(b + "`) DateStyle(`".Length)..c]);
            result.TimeZone = new FString(s[(c + "`) TimeZone(`".Length)..d]);
            result.CultureName = new FString(s[(d + "`) CultureName(`".Length)..e]);
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

        public override object ToStringOrObject()
        {
            return $"SourceDateTime(`{SourceDateTime}`) TimeStyle(`{TimeStyle}`) TimeZone(`{TimeZone}`) CultureName(`{CultureName}`)";
        }

        public static FTextHistory_AsTime FromStringOrObject(string s)
        {
            FTextHistory_AsTime result = new();
            (int a, int b, int c, int d) = (s.IndexOf("SourceDateTime(`"), s.IndexOf("`) TimeStyle(`"), s.IndexOf("`) TimeZone(`"), s.IndexOf("`) CultureName(`"));
            int e = s.IndexOf("`)", d + 1);
            result.SourceDateTime = new FDateTime { Ticks = long.Parse(s[(a + "SourceDateTime(`".Length)..b]) };
            result.TimeStyle = Enum.Parse<EDateTimeStyle>(s[(b + "`) TimeStyle(`".Length)..c]);
            result.TimeZone = new FString(s[(c + "`) TimeZone(`".Length)..d]);
            result.CultureName = new FString(s[(d + "`) CultureName(`".Length)..e]);
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

        public override object ToStringOrObject()
        {
            return $"SourceDateTime(`{SourceDateTime}`) DateStyle(`{DateStyle}`) TimeStyle(`{TimeStyle}`) TimeZone(`{TimeZone}`) CultureName(`{CultureName}`)";
        }

        public static FTextHistory_AsDateTime FromStringOrObject(string s)
        {
            FTextHistory_AsDateTime result = new();
            (int a, int b, int c, int d, int e) = (s.IndexOf("SourceDateTime(`"), s.IndexOf("`) DateStyle(`"), s.IndexOf("`) TimeStyle(`"), s.IndexOf("`) TimeZone(`"), s.IndexOf("`) CultureName(`"));
            int f = s.IndexOf("`)", e + 1);
            result.SourceDateTime = new FDateTime { Ticks = long.Parse(s[(a + "SourceDateTime(`".Length)..b]) };
            result.DateStyle = Enum.Parse<EDateTimeStyle>(s[(b + "`) DateStyle(`".Length)..c]);
            result.TimeStyle = Enum.Parse<EDateTimeStyle>(s[(c + "`) TimeStyle(`".Length)..d]);
            result.TimeZone = new FString(s[(d + "`) TimeZone(`".Length)..e]);
            result.CultureName = new FString(s[(e + "`) CultureName(`".Length)..f]);
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

        public override object ToStringOrObject()
        {
            var obj = base.ToStringOrObject();
            if (obj is string s)
            {
                return $"TransformType(`{TransformType}`) {s}";
            }
            else
            {
                var dict = obj as Dictionary<string, object>;
                string key = $"TransformType(`{TransformType}`) {dict.Keys.First()}";
                return new Dictionary<string, object> { { key, dict.Values.First() } };
            }
        }

        public static FTextHistory_Transform FromStringOrObject(object obj)
        {
            FTextHistory_Transform result = new();
            if (obj is string s)
            {
                int a = s.IndexOf("TransformType(`");
                int b = s.IndexOf("`)", a);
                result.TransformType = Enum.Parse<ETransformType>(s[(a + "TransformType(`".Length)..b]);
                result.SourceText = FText.FromStringOrObject(s);
                return result;
            }
            else if (obj is Dictionary<string, object> dict)
            {
                string key = dict.Keys.First();
                object value = dict.Values.First();
                result.SourceText = FText.FromStringOrObject(value);
                result.TransformType = Enum.Parse<ETransformType>(key);
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

        public override object ToStringOrObject()
        {
            return $"TableId(`{TableId}`) Key(`{Key}`)";
        }

        public static FTextHistory_StringTableEntry FromStringOrObject(string s)
        {
            FTextHistory_StringTableEntry result = new();
            (int a, int b) = (s.IndexOf("TableId(`"), s.IndexOf("`) Key(`"));
            int c = s.IndexOf("`)", b + 1);
            result.TableId = new FName(s[(a + "TableId(`".Length)..b]);
            result.Key = new FString(s[(b + "`) Key(`".Length)..c]);
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

        public override object ToStringOrObject()
        {
            return $"GeneratorTypeID(`{GeneratorTypeID}`) GeneratorContents(`{string.Join(" ", GeneratorContents)}`)";
        }

        public static FTextHistory_TextGenerator FromStringOrObject(string s)
        {
            FTextHistory_TextGenerator result = new();
            (int a, int b) = (s.IndexOf("GeneratorTypeID(`"), s.IndexOf("`) GeneratorContents(`"));
            int c = s.IndexOf("`)", b + 1);
            result.GeneratorTypeID = new FName(s[(a + "`) GeneratorTypeID(`".Length)..b]);
            result.GeneratorContents = s[(b + "`) GeneratorContents(`".Length)..c].Split(" ").Select(byte.Parse).ToArray();
            return result;
        }
    }

    public enum ETransformType : uint8
    {
        ToLower,
        ToUpper,
    }
}

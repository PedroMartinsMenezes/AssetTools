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
        public override bool IsSimple() => false;

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
        public override bool IsSimple() => true;

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
            int[] i = JsonSerializerExt.GetIndices(s, "Key(`", "`)", "`) Namespace(`", "`)", "`) SourceString(`", "`)");
            if (Array.TrueForAll(i, (x) => x > 0))
            {
                if (s[i[0]..i[1]].Length > 0 || s[i[2]..i[3]].Length > 0 || s[i[4]..i[5]].Length > 0)
                {
                    result = new();
                    result.Key = new FTextKey(s[i[0]..i[1]]);
                    result.Namespace = new FTextKey(s[i[2]..i[3]]);
                    result.SourceString = new FString(s[i[4]..i[5]]);
                }
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

        public override bool IsSimple()
        {
            ETextHistoryType[] complexTypes = [ETextHistoryType.NamedFormat, ETextHistoryType.OrderedFormat, ETextHistoryType.ArgumentFormat, ETextHistoryType.AsNumber, ETextHistoryType.AsPercent, ETextHistoryType.AsCurrency, ETextHistoryType.Transform];
            return !Arguments.Any(x => x.Value.Type == EFormatArgumentType.Text && complexTypes.Contains(x.Value.TextValue.HistoryType));
        }

        public override object ToStringOrObject()
        {
            if (IsSimple())
            {
                return ToSimpleString();
            }
            else
            {
                Dictionary<string, object> dict = new();
                dict["SourceFmt"] = SourceFmt.ToStringOrObject();
                dict["Arguments"] = Arguments.ToDictionary(x => x.Key.ToString(), x => x.Value.ToStringOrObject());
                return dict;
            }
        }

        public override string ToSimpleString()
        {
            //SourceFmt fields
            string flag = SourceFmt.Flags.ToString();
            string history = SourceFmt.HistoryType.ToString();

            //TextData fields
            var textData = SourceFmt.TextData as FTextHistory_Base;
            string textDataString = textData.SourceString.ToString();
            string textDataKey = textData.Key?.ToString();
            string textDataNamespace = textData.Namespace?.ToString();

            //Argument fields
            string keys = string.Join("` `", Arguments.Select(x => x.Key.ToString()));
            string args = string.Join("` `", Arguments.Select(x => x.Value.GetText()));
            string ids = string.Join("` `", Arguments.Select(x => x.Value.GetId()));
            string namespaces = string.Join("` `", Arguments.Select(x => x.Value.GetNamespace()));
            string flags = string.Join("` `", Arguments.Select(x => x.Value.GetFlag()));
            string histories = string.Join("` `", Arguments.Select(x => x.Value.GetHistoryType()));

            string text = $"SourceFmt(`{flag}` `{history}`) TextData(`{textDataString}` `{textDataKey}` `{textDataNamespace}`) Keys(`{keys}`) Values(`{args}`) Ids(`{ids}`) Namespaces(`{namespaces}`) Flags(`{flags}`) Histories(`{histories}`)";
            return text;
        }

        public static FTextHistory_NamedFormat FromStringOrObject(Dictionary<string, JsonElement> dict)
        {
            FTextHistory_NamedFormat result = new();
            result.SourceFmt = FText.FromStringOrObject(dict["SourceFmt"].ToStringOrObject());
            Dictionary<string, JsonElement> arguments = dict["Arguments"].ToObject<Dictionary<string, JsonElement>>();
            result.Arguments = arguments.ToDictionary(x => new FString(x.Key), x => FFormatArgumentValue.FromStringOrObject(x.Value.ToStringOrObject()));
            return result;
        }

        public static FTextHistory_NamedFormat FromString(string text)
        {
            FTextHistory_NamedFormat result = new() { Arguments = [] };

            int[] i = JsonSerializerExt.GetIndices(text, "SourceFmt(`", "`", " `", "`)", "TextData(`", "`", " `", "`", " `", "`)", "Keys(`", "`)", "Values(`", "`)", "Ids(`", "`)", "Namespaces(`", "`)", "Flags(`", "`)", "Histories(`", "`)");

            if (Array.TrueForAll(i, (x) => x > 0))
            {
                //SourceFmt fields
                result.SourceFmt = new FText
                {
                    Flags = Enum.Parse<ETextFlag>(text[i[0]..i[1]]),
                    HistoryType = Enum.Parse<ETextHistoryType>(text[i[2]..i[3]]),
                };

                //SourceFmt.TextData fields
                FTextHistory_Base textData = null;
                if (text[i[4]..i[5]].Length > 0 || text[i[6]..i[7]].Length > 0 || text[i[8]..i[9]].Length > 0)
                {
                    textData = new();
                    textData.SourceString = new FString(text[i[4]..i[5]]);
                    textData.Key = new FTextKey(text[i[6]..i[7]]);
                    textData.Namespace = new FTextKey(text[i[8]..i[9]]);
                    result.SourceFmt.TextData = textData;
                }

                //bHasCultureInvariantString flag
                result.SourceFmt.bHasCultureInvariantString = result.SourceFmt.HistoryType == (ETextHistoryType)(-1) && result.SourceFmt.TextData is { };

                //Arguments fields
                string[] argKeys = text[i[10]..i[11]].Split("` `");
                string[] argValues = text[i[12]..i[13]].Split("` `");
                string[] argIds = text[i[14]..i[15]].Split("` `");
                string[] argNamespaces = text[i[16]..i[17]].Split("` `");
                string[] argFlags = text[i[18]..i[19]].Split("` `");
                string[] argHistories = text[i[20]..i[21]].Split("` `");

                for (int j = 0; j < argKeys.Length; j++)
                {
                    if (argFlags[j].Length > 0) //Argument is Text
                    {
                        string argText = $"text-base Flags(`{argFlags[j]}`)  | Key(`{argIds[j]}`) Namespace(`{argNamespaces[j]}`) SourceString(`{argValues[j]}`) HistoryType(`{argHistories[j]}`)";
                        if (argHistories[j] == "-1")
                        {
                            argText = argText.Replace("text-base", "text");
                        }
                        FFormatArgumentValue arg = FFormatArgumentValue.FromStringOrObject(argText);
                        result.Arguments.Add(new FString(argKeys[j]), arg);
                    }
                    else //Argument is Number
                    {
                        result.Arguments.Add(new FString(argKeys[j]), FFormatArgumentValue.FromStringOrObject(argValues[j]));
                    }
                }
            }
            return result;
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
        public override bool IsSimple() => false;

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
        public override bool IsSimple() => false;
        public static FTextHistory_AsNumber FromKeyAndValue(Dictionary<string, object> dict) => FromStringOrObject<FTextHistory_AsNumber>(dict);
    }

    public class FTextHistory_AsPercent : FTextHistory_FormatNumber
    {
        [Location("void FTextHistory_AsPercent::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITextData Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
        public override bool IsSimple() => false;
        public static FTextHistory_AsPercent FromKeyAndValue(Dictionary<string, object> dict) => FromStringOrObject<FTextHistory_AsPercent>(dict);
    }

    public class FTextHistory_AsCurrency : FTextHistory_FormatNumber
    {
        public FString CurrencyCode;
        public override bool IsSimple() => false;

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
        public override bool IsSimple() => false;

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
        public override bool IsSimple() => true;

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
        public override bool IsSimple() => true;

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

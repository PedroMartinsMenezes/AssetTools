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
            FTextHistory_Base result = new();
            int[] i = JsonSerializerExt.GetIndices(s, "Key(`", "`)", "`) Namespace(`", "`)", "`) SourceString(`", "`)");
            if (Array.TrueForAll(i, (x) => x > 0))
            {
                result.Key = new FTextKey(s[i[0]..i[1]]);
                result.Namespace = new FTextKey(s[i[2]..i[3]]);
                result.SourceString = new FString(s[i[4]..i[5]]);
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
            ///"PinFriendlyName-3": {
            ///    "text-named-format Flags(`None`) ": {
            ///        "Arguments": {
            ///            "PinDisplayName": "text-base Flags(`None`)  | Key(`E2A63D624D9425D3B72F61BDC489E579`) Namespace(`\\0`) SourceString(`In Rot`)",
            ///            "ProtoPinDisplayName": "text-base Flags(`None`)  | Key(`F42DED39443F0101F92C81800E1986F3`) Namespace(`\\0`) SourceString(`Z (Yaw)`)"
            ///        },
            ///        "SourceFmt": "text-base Flags(`Immutable`)  | Key(`SplitPinFriendlyNameFormat`) Namespace(`KismetSchema`) SourceString(`{PinDisplayName} {ProtoPinDisplayName}`)"
            ///    }
            ///},
            ///"PinFriendlyName-3-Small": "format(`{PinDisplayName} {ProtoPinDisplayName}`) Args(`In Rot` `Z (Yaw)`)  Guids(`E2A63D624D9425D3B72F61BDC489E579` `F42DED39443F0101F92C81800E1986F3`)",
            string format = (SourceFmt.TextData as FTextHistory_Base).SourceString.ToString();
            string keys = string.Join("` `", Arguments.Select(x => x.Key.ToString()));
            string args = string.Join("` `", Arguments.Select(x => x.Value.TextValue.GetSourceString()));
            string ids = string.Join("` `", Arguments.Select(x => x.Value.TextValue.GetKey()));
            string namespaces = string.Join("` `", Arguments.Select(x => x.Value.TextValue.GetNamespace()));
            string text = $"format `{format}` Keys(`{keys}`) Values(`{args}`) Ids(`{ids}`) Namespaces(`{namespaces}`)";
            return text;
        }

        public string ToStringTooltip()
        {
            ///"PinFriendlyName-4": {
            ///    "text-named-format Flags(`None`) ": {
            ///        "Arguments": {
            ///            "Delimiter": "text-base Flags(`None`)  | Key(`52F1F3E948D9A73B363418987BE6DB77`) Namespace(`\\0`) SourceString(`:\r\n`)",
            ///            "0": "text-base Flags(`None`)  | Key(`B4220E8A41C57E64B6B66ABFA5F92636`) Namespace(`\\0`) SourceString(`LODThreshold`)",
            ///            "1": "text-base Flags(`None`)  | Key(`AnimNode_ApplyAdditive:LODThreshold`) Namespace(`UObjectToolTips`) SourceString(`* Max LOD that this node is allowed to run\n* For example if you have LODThreadhold to be 2, it will run until LOD 2 (based on 0 index)\n* when the component LOD becomes 3, it will stop update/evaluate\n* currently transition would be issue and that has to be re-visited`)"
            ///        },
            ///        "SourceFmt": "text Flags(`CultureInvariant`)  | Key(``) Namespace(``) SourceString(`{0}{Delimiter}{1}`)"
            ///    }
            ///},
            ///"PinFriendlyName-4-Small": "tooltip `{0}{Delimiter}{1}` Args(`LODThreshold` `* Max LOD that this node is allowed to run\n* For example if you have LODThreadhold to be 2, it will run until LOD 2 (based on 0 index)\n* when the component LOD becomes 3, it will stop update/evaluate\n* currently transition would be issue and that has to be re-visited` `:\r\n`)  Keys(`B4220E8A41C57E64B6B66ABFA5F92636` `AnimNode_ApplyAdditive:LODThreshold` `52F1F3E948D9A73B363418987BE6DB77`) Namespaces(`\\0` `UObjectToolTips` `\\0`)",
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
            int[] i = JsonSerializerExt.GetIndices(text, "format `", "`", "Keys(`", "`)", "Values(`", "`)", "Ids(`", "`)", "Namespaces(`", "`)");
            if (Array.TrueForAll(i, (x) => x > 0))
            {
                string sourceString = text[i[0]..i[1]];
                FTextHistory_Base textData = new() { Key = new FTextKey("SplitPinFriendlyNameFormat"), Namespace = new FTextKey("KismetSchema"), SourceString = new FString(sourceString) };
                result.SourceFmt = new FText { Flags = ETextFlag.Immutable, TextData = textData };
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

        private static List<string> GetArgNames(string text)
        {
            List<string> argNames = [];
            (int a, int b) = (0, 0);
            while (true)
            {
                a = text.IndexOf("{", b);
                b = a < 0 ? -1 : text.IndexOf("}", a);
                if (a < 0 || b < 0) break;
                argNames.Add(text[(a + 1)..b]);
            }
            return argNames;
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

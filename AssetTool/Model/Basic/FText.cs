namespace AssetTool
{
    [Location("void FText::SerializeText(FStructuredArchive::FSlot Slot, FText& Value)")]
    public class FText
    {
        public UInt32 Flags;
        public sbyte HistoryType;
        public FBool bHasCultureInvariantString;

        public ITextData TextData;

        public string Value => TextData is FTextHistory text ? text.Value : null;
    }

    public static class FTextExt
    {
        public static void Write(this BinaryWriter writer, FText item)
        {
            writer.Write(item.Flags);
            writer.Write(item.HistoryType);

            bool bSerializeHistory = true;
            switch ((ETextHistoryType)item.HistoryType)
            {
                case ETextHistoryType.Base:
                    break;
                case ETextHistoryType.NamedFormat:
                    break;
                case ETextHistoryType.OrderedFormat:
                    break;
                case ETextHistoryType.ArgumentFormat:
                    break;
                case ETextHistoryType.AsNumber:
                    break;
                case ETextHistoryType.AsPercent:
                    break;
                case ETextHistoryType.AsCurrency:
                    break;
                case ETextHistoryType.AsDate:
                    break;
                case ETextHistoryType.AsTime:
                    break;
                case ETextHistoryType.AsDateTime:
                    break;
                case ETextHistoryType.Transform:
                    break;
                case ETextHistoryType.StringTableEntry:
                    break;
                case ETextHistoryType.TextGenerator:
                    break;
                default:
                    bSerializeHistory = false;
                    writer.Write(item.bHasCultureInvariantString);
                    if (item.bHasCultureInvariantString?.Value == true)
                    {
                        item.TextData.Write(writer);

                    }
                    break;
            }
            if (bSerializeHistory)
            {
                item.TextData.Write(writer);
            }
        }

        public static FText Read(this BinaryReader reader, ref FText item)
        {
            item ??= new();
            reader.Read(ref item.Flags);
            reader.Read(ref item.HistoryType);

            bool bSerializeHistory = true;
            switch ((ETextHistoryType)item.HistoryType)
            {
                case ETextHistoryType.Base:
                    item.TextData = new FTextHistory_Base();
                    break;
                case ETextHistoryType.NamedFormat:
                    item.TextData = new FTextHistory_NamedFormat();
                    break;
                case ETextHistoryType.OrderedFormat:
                    item.TextData = new FTextHistory_OrderedFormat();
                    break;
                case ETextHistoryType.ArgumentFormat:
                    item.TextData = new FTextHistory_ArgumentDataFormat();
                    break;
                case ETextHistoryType.AsNumber:
                    item.TextData = new FTextHistory_AsNumber();
                    break;
                case ETextHistoryType.AsPercent:
                    item.TextData = new FTextHistory_AsPercent();
                    break;
                case ETextHistoryType.AsCurrency:
                    item.TextData = new FTextHistory_AsCurrency();
                    break;
                case ETextHistoryType.AsDate:
                    item.TextData = new FTextHistory_AsDate();
                    break;
                case ETextHistoryType.AsTime:
                    item.TextData = new FTextHistory_AsTime();
                    break;
                case ETextHistoryType.AsDateTime:
                    item.TextData = new FTextHistory_AsDateTime();
                    break;
                case ETextHistoryType.Transform:
                    item.TextData = new FTextHistory_Transform();
                    break;
                case ETextHistoryType.StringTableEntry:
                    item.TextData = new FTextHistory_StringTableEntry();
                    break;
                case ETextHistoryType.TextGenerator:
                    item.TextData = new FTextHistory_TextGenerator();
                    break;
                default:
                    bSerializeHistory = false;
                    reader.Read(ref item.bHasCultureInvariantString);
                    if (item.bHasCultureInvariantString?.Value == true)
                    {
                        FString CultureInvariantString = null;
                        reader.Read(ref CultureInvariantString);
                        item.TextData = new FTextHistory_Base(CultureInvariantString);

                    }
                    break;
            }
            if (bSerializeHistory)
            {
                item.TextData.Read(reader);
            }
            return item;
        }

        public static FText ReadFText(this BinaryReader reader)
        {
            var value = new FText();
            return reader.Read(ref value);
        }

        public enum ETextHistoryType
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
        };
    }
}



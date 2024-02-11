using static AssetTool.FText;

namespace AssetTool
{
    public class FText
    {
        public UInt32 Flags;
        public sbyte HistoryType;
        public FBool bHasCultureInvariantString;

        public enum ETextHistoryType
        {
            Base = 0,
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

    public static class FTextExt
    {
        public static void Write(this BinaryWriter writer, FText item)
        {
            writer.Write(item.Flags);
            writer.Write(item.HistoryType);

            bool bSerializeHistory = true;
            if (!Enum.IsDefined(typeof(ETextHistoryType), (ETextHistoryType)item.HistoryType))
            {
                writer.Write(item.bHasCultureInvariantString);
                bSerializeHistory = false;
            }
            if (bSerializeHistory)
            {
                //void FTextHistory_Base::Serialize(FStructuredArchive::FRecord Record)
            }
        }

        public static FText Read(this BinaryReader reader, ref FText item)
        {
            item ??= new();
            reader.Read(ref item.Flags);
            reader.Read(ref item.HistoryType);

            bool bSerializeHistory = true;
            if (!Enum.IsDefined(typeof(ETextHistoryType), (ETextHistoryType)item.HistoryType))
            {
                reader.Read(ref item.bHasCultureInvariantString);
                bSerializeHistory = false;
            }
            if (bSerializeHistory)
            {
                //void FTextHistory_Base::Serialize(FStructuredArchive::FRecord Record)

            }
            return item;
        }
    }
}



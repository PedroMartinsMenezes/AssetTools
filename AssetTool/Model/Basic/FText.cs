namespace AssetTool
{
    public class FText : ITransferible
    {
        public UInt32 Flags;
        public sbyte HistoryType;
        public FBool bHasCultureInvariantString;
        public ITextData TextData;

        [Location("void FText::SerializeText(FStructuredArchive::FSlot Slot, FText& Value)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Flags);
            transfer.Move(ref HistoryType);

            bool bSerializeHistory = true;
            switch ((ETextHistoryType)HistoryType)
            {
                #region
                case ETextHistoryType.Base:
                    TextData ??= new FTextHistory_Base();
                    break;
                case ETextHistoryType.NamedFormat:
                    TextData ??= new FTextHistory_NamedFormat();
                    break;
                case ETextHistoryType.OrderedFormat:
                    TextData ??= new FTextHistory_OrderedFormat();
                    break;
                case ETextHistoryType.ArgumentFormat:
                    TextData ??= new FTextHistory_ArgumentDataFormat();
                    break;
                case ETextHistoryType.AsNumber:
                    TextData ??= new FTextHistory_AsNumber();
                    break;
                case ETextHistoryType.AsPercent:
                    TextData ??= new FTextHistory_AsPercent();
                    break;
                case ETextHistoryType.AsCurrency:
                    TextData ??= new FTextHistory_AsCurrency();
                    break;
                case ETextHistoryType.AsDate:
                    TextData ??= new FTextHistory_AsDate();
                    break;
                case ETextHistoryType.AsTime:
                    TextData ??= new FTextHistory_AsTime();
                    break;
                case ETextHistoryType.AsDateTime:
                    TextData ??= new FTextHistory_AsDateTime();
                    break;
                case ETextHistoryType.Transform:
                    TextData ??= new FTextHistory_Transform();
                    break;
                case ETextHistoryType.StringTableEntry:
                    TextData ??= new FTextHistory_StringTableEntry();
                    break;
                case ETextHistoryType.TextGenerator:
                    TextData ??= new FTextHistory_TextGenerator();
                    break;
                #endregion
                default:
                    bSerializeHistory = false;
                    if (GlobalObjects.CustomVer(FEditorObjectVersion.Guid) >= (int)FEditorObjectVersion.Enums.CultureInvariantTextSerializationKeyStability)
                    {
                        transfer.Move(ref bHasCultureInvariantString);
                        if (bHasCultureInvariantString?.Value == true)
                        {
                            TextData ??= new FTextHistory_Base();
                            FTextHistory_Base textData = TextData as FTextHistory_Base;
                            transfer.Move(ref textData.SourceString);
                        }
                    }
                    break;
            }
            if (bSerializeHistory)
            {
                TextData.Move(transfer);
            }
            return this;
        }
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
    }

    public static class FTextExt
    {



    }
}



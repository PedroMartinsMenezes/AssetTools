namespace AssetTool
{
    [Location("class ITextData")]
    public interface ITextData
    {
        void Read(BinaryReader reader);
        void Write(BinaryWriter writer);
    }

    public class FTextHistory : ITextData
    {
        public UInt16 GlobalRevision;
        public UInt16 LocalRevision;

        public virtual void Read(BinaryReader reader)
        {

        }

        public virtual void Write(BinaryWriter writer)
        {

        }
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
        public FString Namespace;
        public FString Key;
        public FString SourceString;

        public FTextHistory_Base() { }

        public FTextHistory_Base(FString other)
        {
            SourceString = other;
        }

        public override void Read(BinaryReader reader)
        {
            reader.Read(ref Namespace);
            reader.Read(ref Key);
            reader.Read(ref SourceString);
        }

        public override void Write(BinaryWriter writer)
        {
            writer.Write(Namespace);
            writer.Write(Key);
            writer.Write(SourceString);
        }
    }
    [Location("void FTextHistory_NamedFormat::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory_NamedFormat : FTextHistory_Generated
    {
        public FText SourceFmt;
        public TMap1<FString, FFormatArgumentValue> Arguments;

        public override void Read(BinaryReader reader)
        {
            reader.Read(ref SourceFmt);
            Arguments = new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                FString key = null;
                reader.Read(ref key);
                FFormatArgumentValue value = new();
                value.Read(reader);
                Arguments.Add(key, value);
            }
        }

        public override void Write(BinaryWriter writer)
        {
            writer.Write(SourceFmt);
            writer.Write(Arguments.Count);
            foreach (KeyValuePair<string, FFormatArgumentValue> item in Arguments)
            {
                writer.Write(new FString(item.Key));
                item.Value.Write(writer);
            }
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

namespace AssetTool.Model
{
    //3730..8106
    public class UUserDefinedStructEditorData
    {
        public UInt32 UniqueNameId;

        public string UniqueName => GlobalNames.Get(UniqueNameId);
    }

    public static class UUserDefinedStructEditorDataExt
    {
        public static void Write(this BinaryWriter writer, UUserDefinedStructEditorData item)
        {
            writer.Write(item.UniqueNameId);
        }

        public static UUserDefinedStructEditorData Read(this BinaryReader reader, UUserDefinedStructEditorData item)
        {
            reader.Read(ref item.UniqueNameId);
            return item;
        }
    }
}

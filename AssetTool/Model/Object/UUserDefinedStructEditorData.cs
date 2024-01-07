namespace AssetTool.Model
{
    //3730..8106
    public class UUserDefinedStructEditorData : UObject
    {
        public UInt32 UniqueNameId;

        public string UniqueName => GlobalNames.Get(UniqueNameId);
    }

    public static class UUserDefinedStructEditorDataExt
    {
        public static void Write(this BinaryWriter writer, UUserDefinedStructEditorData item)
        {
            writer.Write((UObject)item);

            writer.Write(item.UniqueNameId);
        }

        public static UUserDefinedStructEditorData Read(this BinaryReader reader, UUserDefinedStructEditorData item)
        {
            //3730
            reader.Read((UObject)item);

            reader.Read(ref item.UniqueNameId);
            return item;
        }
    }
}

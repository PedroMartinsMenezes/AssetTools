namespace AssetTool.Model
{
    //3730..8054
    public class UUserDefinedStructEditorData : UObject
    {
    }

    public static class UUserDefinedStructEditorDataExt
    {
        public static void Write(this BinaryWriter writer, UUserDefinedStructEditorData item)
        {
            writer.Write((UObject)item);
        }

        public static void Read(this BinaryReader reader, UUserDefinedStructEditorData item)
        {
            //3730..8054
            reader.Read((UObject)item);
        }
    }
}

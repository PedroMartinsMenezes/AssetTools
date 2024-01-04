using AssetTool.Model;
using AssetTool.Model.Const;

namespace AssetTool
{
    public class AssetObject
    {
        public long Offset;
        public string Type;

        //polymorphic members
        public UMetadata MetaData;
        public UUserDefinedStruct UserDefinedStruct;
        public UUserDefinedStructEditorData UserDefinedStructEditorData;
    }

    public static class StructBodyExt
    {
        public static void Write(this BinaryWriter writer, AssetObject item)
        {
            writer.BaseStream.Position = item.Offset;
            writer.Write(item.MetaData);
        }

        public static void Read(this BinaryReader reader, List<AssetObject> list) =>
            list.ForEach(x => reader.Read(x));

        public static AssetObject Read(this BinaryReader reader, AssetObject item)
        {
            reader.BaseStream.Position = item.Offset;
            if (item.Type == Consts.MetaData)
            {
                item.MetaData = reader.Read(new UMetadata());
            }
            else if (item.Type == Consts.UserDefinedStruct)
            {
                item.UserDefinedStruct = reader.Read(new UUserDefinedStruct());
            }
            else if (item.Type == Consts.UserDefinedStructEditorData)
            {
                item.UserDefinedStructEditorData = reader.Read(new UUserDefinedStructEditorData());
            }
            return item;
        }
    }
}

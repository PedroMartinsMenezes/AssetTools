using AssetTool.Model;
using AssetTool.Model.Const;

namespace AssetTool
{
    public class StructAsset
    {
        public StructHeader Header = new();
        public List<AssetObject> Objects = new();
    }

    public static class StructAssetExt
    {
        public static void Write(this BinaryWriter writer, StructAsset item)
        {
            writer.Write(item.Header);

            foreach (var obj in item.Objects)
            {
                writer.BaseStream.Position = obj.Offset;
                if (obj.Type == Consts.MetaData)
                {
                    writer.Write(obj.MetaData);
                }
                if (obj.Type == Consts.UserDefinedStruct)
                {
                    writer.Write(obj.UserDefinedStruct);
                }
                else if (obj.Type == Consts.UserDefinedStructEditorData)
                {
                    writer.Write(obj.UserDefinedStructEditorData);
                }
            }
        }

        public static void Read(this BinaryReader reader, StructAsset item)
        {
            reader.Read(item.Header);

            item.Objects = item.Header.ExportMap.Select(x => new AssetObject
            {
                Offset = x.SerialOffset,
                Type = item.Header.ImportMap[-x.ClassIndex.Index - 1].ObjectName.Value
            })
            .ToList();

            reader.Read(item.Objects);
        }
    }
}

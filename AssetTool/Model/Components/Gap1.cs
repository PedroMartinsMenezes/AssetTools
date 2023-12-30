using AssetTool.Model.Basic;
using AssetTool.Service;

namespace AssetTool.Model
{
    public class Gap1
    {
        public FName Name;
        public Int32 Pad1;
        public Int32 Pad2;
    }

    public static class Gap1Ext
    {
        public static void Write(this BinaryWriter writer, Gap1 item)
        {
            writer.Write(item.Name);
            writer.Write(item.Pad1);
            writer.Write(item.Pad2);
        }

        public static Gap1 Read(this BinaryReader reader, Gap1 item)
        {
            reader.Read(ref item.Name);
            reader.Read(ref item.Pad1);
            reader.Read(ref item.Pad2);
            return item;
        }
    }
}

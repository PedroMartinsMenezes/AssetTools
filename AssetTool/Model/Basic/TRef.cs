using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class TRef
    {
        public UInt32 ExportIndex;

        public string Value => GlobalObjects.ExportDiaplayValue(ExportIndex - 1);

        public TRef Read(BinaryReader reader)
        {
            reader.Read(ref ExportIndex);
            if (ExportIndex >= GlobalObjects.ExportMap.Count)
            {
                throw new InvalidOperationException("Invalid Export Index");
            }
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(ExportIndex);
            if (ExportIndex >= GlobalObjects.ExportMap.Count)
            {
                throw new InvalidOperationException("Invalid Export Index");
            }
        }
    }
}

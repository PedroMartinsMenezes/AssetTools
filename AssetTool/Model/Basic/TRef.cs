using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class TRef
    {
        public UInt32 ExportIndex;

        public string Value => GlobalObjects.ExportDiaplayValue(ExportIndex - 1);

        public TRef Move(Transfer transfer)
        {
            transfer.Move(ref ExportIndex);
            if (ExportIndex >= GlobalObjects.ExportMap.Count)
            {
                throw new InvalidOperationException("Invalid Export Index");
            }
            return this;
        }
    }
}

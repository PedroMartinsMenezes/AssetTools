namespace AssetTool
{
    public class TRef
    {
        public UInt32 ExportIndex;

        ///public string Value => GlobalObjects.ExportDiaplayValue(ExportIndex - 1);

        public TRef Move(Transfer transfer)
        {
            transfer.Move(ref ExportIndex);
            if (ExportIndex > transfer.GlobalObjects.ExportMap.Count)
            {
                throw new InvalidOperationException("Invalid Export Index");
            }
            return this;
        }
    }
}

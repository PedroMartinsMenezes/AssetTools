namespace AssetTool
{
    public class TRef : ITransferible
    {
        public UInt32 ExportIndex;

        public ITransferible Move(Transfer transfer)
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

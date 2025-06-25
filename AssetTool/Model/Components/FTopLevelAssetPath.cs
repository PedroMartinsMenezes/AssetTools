namespace AssetTool
{
    public class FTopLevelAssetPath : ITransferible
    {
        public FName PackageName;
        public FName AssetName;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref PackageName);
            transfer.Move(ref AssetName);
            return this;
        }

        public bool IsNull(Transfer transfer)
        {
            return PackageName is null || PackageName.IsNone(transfer);
        }
    }
}

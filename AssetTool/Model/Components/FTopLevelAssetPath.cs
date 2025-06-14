namespace AssetTool
{
    public class FTopLevelAssetPath
    {
        public FName PackageName;
        public FName AssetName;

        public FTopLevelAssetPath Move(Transfer transfer)
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

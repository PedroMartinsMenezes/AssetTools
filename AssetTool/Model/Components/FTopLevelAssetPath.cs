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
    }
}

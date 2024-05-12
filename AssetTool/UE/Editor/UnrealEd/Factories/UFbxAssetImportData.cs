namespace AssetTool
{
    public class UFbxAssetImportData : UAssetImportData
    {
        public new UFbxAssetImportData Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}

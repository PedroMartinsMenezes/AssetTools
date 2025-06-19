namespace AssetTool
{
    [JsonAsset("FbxAssetImportData")]
    public class UFbxAssetImportData : UAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
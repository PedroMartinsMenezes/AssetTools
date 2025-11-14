namespace AssetTool
{
    [JsonAsset("FbxAssetImportData")]
    public class UFbxAssetImportData : UAssetImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
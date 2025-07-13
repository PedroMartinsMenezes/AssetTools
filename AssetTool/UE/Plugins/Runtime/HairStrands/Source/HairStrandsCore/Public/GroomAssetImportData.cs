namespace AssetTool
{
    [JsonAsset("GroomAssetImportData")]
    public class UGroomAssetImportData : UAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
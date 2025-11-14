namespace AssetTool
{
    [JsonAsset("GroomAssetImportData")]
    public class UGroomAssetImportData : UAssetImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
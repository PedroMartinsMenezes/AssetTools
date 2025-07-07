namespace AssetTool
{
    [JsonAsset("DMXGDTFAssetImportData")]
    public class UDMXGDTFAssetImportData : UAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
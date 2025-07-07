namespace AssetTool
{
    [JsonAsset("DMXMVRAssetImportData")]
    public class UDMXMVRAssetImportData : UAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
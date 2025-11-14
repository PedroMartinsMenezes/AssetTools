namespace AssetTool
{
    [JsonAsset("DMXMVRAssetImportData")]
    public class UDMXMVRAssetImportData : UAssetImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
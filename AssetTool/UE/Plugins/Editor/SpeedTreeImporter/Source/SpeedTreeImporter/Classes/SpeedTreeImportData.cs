namespace AssetTool
{
    [JsonAsset("SpeedTreeImportData")]
    public class USpeedTreeImportData : UAssetImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
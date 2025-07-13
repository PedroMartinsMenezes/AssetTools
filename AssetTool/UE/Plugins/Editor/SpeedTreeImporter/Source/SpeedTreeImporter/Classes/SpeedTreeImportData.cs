namespace AssetTool
{
    [JsonAsset("SpeedTreeImportData")]
    public class USpeedTreeImportData : UAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
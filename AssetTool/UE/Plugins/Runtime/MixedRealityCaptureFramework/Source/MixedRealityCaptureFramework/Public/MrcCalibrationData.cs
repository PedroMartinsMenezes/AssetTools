namespace AssetTool
{
    [JsonAsset("MrcCalibrationData")]
    public class UMrcCalibrationData : USaveGame
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MrcCalibrationSaveGame")]
    public class UMrcCalibrationSaveGame : UMrcCalibrationData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
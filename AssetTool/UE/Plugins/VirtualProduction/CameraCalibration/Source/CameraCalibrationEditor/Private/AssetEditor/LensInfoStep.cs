namespace AssetTool
{
    [JsonAsset("LensInfoStep")]
    public class ULensInfoStep : UCameraCalibrationStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
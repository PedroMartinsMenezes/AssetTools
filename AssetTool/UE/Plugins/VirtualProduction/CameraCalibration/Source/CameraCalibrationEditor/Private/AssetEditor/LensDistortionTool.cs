namespace AssetTool
{
    [JsonAsset("LensDistortionTool")]
    public class ULensDistortionTool : UCameraCalibrationStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("LensDistortionTool")]
    public class ULensDistortionTool : UCameraCalibrationStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
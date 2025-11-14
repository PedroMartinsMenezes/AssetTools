namespace AssetTool
{
    [JsonAsset("LensInfoStep")]
    public class ULensInfoStep : UCameraCalibrationStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
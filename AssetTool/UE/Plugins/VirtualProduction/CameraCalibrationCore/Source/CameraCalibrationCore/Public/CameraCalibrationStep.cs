namespace AssetTool
{
    [JsonAsset("CameraCalibrationStep")]
    public class UCameraCalibrationStep : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
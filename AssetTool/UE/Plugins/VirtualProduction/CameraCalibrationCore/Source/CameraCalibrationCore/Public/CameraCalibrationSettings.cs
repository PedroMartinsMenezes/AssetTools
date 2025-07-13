namespace AssetTool
{
    [JsonAsset("CameraCalibrationSettings")]
    public class UCameraCalibrationSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CameraCalibrationEditorSettings")]
    public class UCameraCalibrationEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
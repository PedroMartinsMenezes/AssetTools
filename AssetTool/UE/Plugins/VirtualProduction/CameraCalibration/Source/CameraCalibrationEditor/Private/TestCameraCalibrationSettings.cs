namespace AssetTool
{
    [JsonAsset("TestCameraCalibrationSettings")]
    public class UTestCameraCalibrationSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
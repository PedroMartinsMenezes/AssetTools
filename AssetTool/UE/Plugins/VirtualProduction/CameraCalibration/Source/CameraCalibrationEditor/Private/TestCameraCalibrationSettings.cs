namespace AssetTool
{
    [JsonAsset("TestCameraCalibrationSettings")]
    public class UTestCameraCalibrationSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
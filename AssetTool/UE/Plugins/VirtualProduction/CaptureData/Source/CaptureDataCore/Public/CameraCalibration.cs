namespace AssetTool
{
    [JsonAsset("CameraCalibration")]
    public class UCameraCalibration : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
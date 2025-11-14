namespace AssetTool
{
    [JsonAsset("CameraCalibration")]
    public class UCameraCalibration : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("OpenXRHandTrackingSettings")]
    public class UOpenXRHandTrackingSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
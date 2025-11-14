namespace AssetTool
{
    [JsonAsset("OpenXRHandTrackingSettings")]
    public class UOpenXRHandTrackingSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
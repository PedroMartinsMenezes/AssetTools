namespace AssetTool
{
    [JsonAsset("ARKitGeoTrackingSupport")]
    public class UARKitGeoTrackingSupport : UARGeoTrackingSupport
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ARKitGeoTrackingSupport")]
    public class UARKitGeoTrackingSupport : UARGeoTrackingSupport
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
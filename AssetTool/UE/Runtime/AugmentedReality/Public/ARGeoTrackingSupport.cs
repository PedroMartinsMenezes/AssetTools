namespace AssetTool
{
    [JsonAsset("ARGeoTrackingSupport")]
    public class UARGeoTrackingSupport : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy")]
    public class UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GetGeoLocationAsyncTaskBlueprintProxy")]
    public class UGetGeoLocationAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
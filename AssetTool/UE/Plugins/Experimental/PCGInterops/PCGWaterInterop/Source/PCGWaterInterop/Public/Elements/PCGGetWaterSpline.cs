namespace AssetTool
{
    [JsonAsset("PCGGetWaterSplineSettings")]
    public class UPCGGetWaterSplineSettings : UPCGGetSplineSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
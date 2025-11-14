namespace AssetTool
{
    [JsonAsset("PCGGetWaterSplineSettings")]
    public class UPCGGetWaterSplineSettings : UPCGGetSplineSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("PCGSplineToSegmentSettings")]
    public class UPCGSplineToSegmentSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
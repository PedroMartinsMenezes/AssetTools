namespace AssetTool
{
    [JsonAsset("PCGCleanSplineSettings")]
    public class UPCGCleanSplineSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("PCGCleanSplineSettings")]
    public class UPCGCleanSplineSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
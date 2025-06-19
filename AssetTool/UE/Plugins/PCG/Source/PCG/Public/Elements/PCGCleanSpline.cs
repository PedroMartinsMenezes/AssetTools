namespace AssetTool
{
    [JsonAsset("PCGCleanSplineSettings")]
    public class UPCGCleanSplineSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("PCGWaitLandscapeReadySettings")]
    public class UPCGWaitLandscapeReadySettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
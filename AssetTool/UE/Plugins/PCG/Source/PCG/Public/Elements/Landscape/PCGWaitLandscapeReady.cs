namespace AssetTool
{
    [JsonAsset("PCGWaitLandscapeReadySettings")]
    public class UPCGWaitLandscapeReadySettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("PCGWaitLandscapeReadySettings")]
    public class UPCGWaitLandscapeReadySettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
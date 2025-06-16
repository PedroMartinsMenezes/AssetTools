namespace AssetTool
{
    [JsonAsset("PCGResetPointCenterSettings")]
    public class UPCGResetPointCenterSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
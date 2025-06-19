namespace AssetTool
{
    [JsonAsset("PCGResetPointCenterSettings")]
    public class UPCGResetPointCenterSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
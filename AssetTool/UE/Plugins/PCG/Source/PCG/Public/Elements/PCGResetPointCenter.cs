namespace AssetTool
{
    [JsonAsset("PCGResetPointCenterSettings")]
    public class UPCGResetPointCenterSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
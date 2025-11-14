namespace AssetTool
{
    [JsonAsset("PCGSwitchSettings")]
    public class UPCGSwitchSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
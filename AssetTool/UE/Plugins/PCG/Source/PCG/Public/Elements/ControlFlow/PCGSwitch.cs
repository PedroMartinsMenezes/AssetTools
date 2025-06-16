namespace AssetTool
{
    [JsonAsset("PCGSwitchSettings")]
    public class UPCGSwitchSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
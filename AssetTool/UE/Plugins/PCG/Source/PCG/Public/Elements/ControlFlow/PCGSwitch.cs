namespace AssetTool
{
    [JsonAsset("PCGSwitchSettings")]
    public class UPCGSwitchSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
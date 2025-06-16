namespace AssetTool
{
    [JsonAsset("PCGGridLinkageSettings")]
    public class UPCGGridLinkageSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
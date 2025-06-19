namespace AssetTool
{
    [JsonAsset("PCGGridLinkageSettings")]
    public class UPCGGridLinkageSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
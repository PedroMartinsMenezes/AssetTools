namespace AssetTool
{
    [JsonAsset("PCGGridLinkageSettings")]
    public class UPCGGridLinkageSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
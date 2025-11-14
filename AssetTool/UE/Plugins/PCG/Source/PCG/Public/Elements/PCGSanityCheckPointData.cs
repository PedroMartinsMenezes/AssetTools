namespace AssetTool
{
    [JsonAsset("PCGSanityCheckPointDataSettings")]
    public class UPCGSanityCheckPointDataSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
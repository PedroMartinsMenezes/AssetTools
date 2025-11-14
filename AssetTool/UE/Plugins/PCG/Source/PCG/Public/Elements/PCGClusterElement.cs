namespace AssetTool
{
    [JsonAsset("PCGClusterSettings")]
    public class UPCGClusterSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
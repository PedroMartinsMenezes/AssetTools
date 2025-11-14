namespace AssetTool
{
    [JsonAsset("PCGSelfPruningSettings")]
    public class UPCGSelfPruningSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
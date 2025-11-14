namespace AssetTool
{
    [JsonAsset("PCGMutateSeedSettings")]
    public class UPCGMutateSeedSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
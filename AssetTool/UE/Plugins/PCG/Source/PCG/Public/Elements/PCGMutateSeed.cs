namespace AssetTool
{
    [JsonAsset("PCGMutateSeedSettings")]
    public class UPCGMutateSeedSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
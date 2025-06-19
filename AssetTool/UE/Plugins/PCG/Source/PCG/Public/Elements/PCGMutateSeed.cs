namespace AssetTool
{
    [JsonAsset("PCGMutateSeedSettings")]
    public class UPCGMutateSeedSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
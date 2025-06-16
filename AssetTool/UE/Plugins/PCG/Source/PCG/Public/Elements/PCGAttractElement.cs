namespace AssetTool
{
    [JsonAsset("PCGAttractSettings")]
    public class UPCGAttractSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
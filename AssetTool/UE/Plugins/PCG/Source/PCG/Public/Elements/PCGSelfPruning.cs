namespace AssetTool
{
    [JsonAsset("PCGSelfPruningSettings")]
    public class UPCGSelfPruningSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
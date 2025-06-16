namespace AssetTool
{
    [JsonAsset("PCGGatherSettings")]
    public class UPCGGatherSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
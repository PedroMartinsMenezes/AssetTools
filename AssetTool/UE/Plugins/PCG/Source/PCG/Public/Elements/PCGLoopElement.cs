namespace AssetTool
{
    [JsonAsset("PCGLoopSettings")]
    public class UPCGLoopSettings : UPCGSubgraphSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
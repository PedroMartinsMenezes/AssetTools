namespace AssetTool
{
    [JsonAsset("PCGLoopSettings")]
    public class UPCGLoopSettings : UPCGSubgraphSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
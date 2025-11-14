namespace AssetTool
{
    [JsonAsset("PCGLoopSettings")]
    public class UPCGLoopSettings : UPCGSubgraphSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
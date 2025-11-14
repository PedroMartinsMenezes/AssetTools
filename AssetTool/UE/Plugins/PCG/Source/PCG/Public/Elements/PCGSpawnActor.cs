namespace AssetTool
{
    [JsonAsset("PCGSpawnActorSettings")]
    public class UPCGSpawnActorSettings : UPCGBaseSubgraphSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSpawnActorNode")]
    public class UPCGSpawnActorNode : UPCGBaseSubgraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
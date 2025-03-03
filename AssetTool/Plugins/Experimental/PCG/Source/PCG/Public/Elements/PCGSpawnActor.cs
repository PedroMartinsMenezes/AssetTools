namespace AssetTool
{
    [JsonAsset("PCGSpawnActorSettings")]
    public class UPCGSpawnActorSettings : UPCGBaseSubgraphSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSpawnActorNode")]
    public class UPCGSpawnActorNode : UPCGBaseSubgraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
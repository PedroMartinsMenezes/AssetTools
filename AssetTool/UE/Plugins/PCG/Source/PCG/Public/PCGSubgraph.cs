namespace AssetTool
{
    [JsonAsset("PCGBaseSubgraphSettings")]
    public class UPCGBaseSubgraphSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSubgraphSettings")]
    public class UPCGSubgraphSettings : UPCGBaseSubgraphSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGBaseSubgraphNode")]
    public class UPCGBaseSubgraphNode : UPCGNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSubgraphNode")]
    public class UPCGSubgraphNode : UPCGBaseSubgraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
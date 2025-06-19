namespace AssetTool
{
    [JsonAsset("PCGBaseSubgraphSettings")]
    public class UPCGBaseSubgraphSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSubgraphSettings")]
    public class UPCGSubgraphSettings : UPCGBaseSubgraphSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGBaseSubgraphNode")]
    public class UPCGBaseSubgraphNode : UPCGNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSubgraphNode")]
    public class UPCGSubgraphNode : UPCGBaseSubgraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
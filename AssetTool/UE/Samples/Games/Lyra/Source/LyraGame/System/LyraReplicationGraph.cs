namespace AssetTool
{
    [JsonAsset("LyraReplicationGraph")]
    public class ULyraReplicationGraph : UReplicationGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraReplicationGraphNode_AlwaysRelevant_ForConnection")]
    public class ULyraReplicationGraphNode_AlwaysRelevant_ForConnection : UReplicationGraphNode_AlwaysRelevant_ForConnection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraReplicationGraphNode_PlayerStateFrequencyLimiter")]
    public class ULyraReplicationGraphNode_PlayerStateFrequencyLimiter : UReplicationGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
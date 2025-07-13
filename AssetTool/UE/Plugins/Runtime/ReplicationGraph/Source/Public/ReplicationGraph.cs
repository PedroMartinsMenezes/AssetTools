namespace AssetTool
{
    [JsonAsset("ReplicationGraphNode")]
    public class UReplicationGraphNode : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraphNode_ActorList")]
    public class UReplicationGraphNode_ActorList : UReplicationGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraphNode_ActorListFrequencyBuckets")]
    public class UReplicationGraphNode_ActorListFrequencyBuckets : UReplicationGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraphNode_DynamicSpatialFrequency")]
    public class UReplicationGraphNode_DynamicSpatialFrequency : UReplicationGraphNode_ActorList
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraphNode_ConnectionDormancyNode")]
    public class UReplicationGraphNode_ConnectionDormancyNode : UReplicationGraphNode_ActorList
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraphNode_DormancyNode")]
    public class UReplicationGraphNode_DormancyNode : UReplicationGraphNode_ActorList
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraphNode_GridCell")]
    public class UReplicationGraphNode_GridCell : UReplicationGraphNode_ActorList
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraphNode_GridSpatialization2D")]
    public class UReplicationGraphNode_GridSpatialization2D : UReplicationGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraphNode_AlwaysRelevant")]
    public class UReplicationGraphNode_AlwaysRelevant : UReplicationGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraphNode_AlwaysRelevant_ForConnection")]
    public class UReplicationGraphNode_AlwaysRelevant_ForConnection : UReplicationGraphNode_ActorList
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraphNode_TearOff_ForConnection")]
    public class UReplicationGraphNode_TearOff_ForConnection : UReplicationGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraph")]
    public class UReplicationGraph : UReplicationDriver
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetReplicationGraphConnection")]
    public class UNetReplicationGraphConnection : UReplicationConnectionDriver
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationGraphDebugActor")]
    public class AReplicationGraphDebugActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
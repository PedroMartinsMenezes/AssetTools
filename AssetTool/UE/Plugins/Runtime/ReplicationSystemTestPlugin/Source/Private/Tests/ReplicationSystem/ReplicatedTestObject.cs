namespace AssetTool
{
    [JsonAsset("ReplicatedTestObject")]
    public class UReplicatedTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicatedIrisPropertyComponent")]
    public class UTestReplicatedIrisPropertyComponent : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicatedIrisPushModelComponentWithObjectReference")]
    public class UTestReplicatedIrisPushModelComponentWithObjectReference : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicatedIrisDynamicStatePropertyComponent")]
    public class UTestReplicatedIrisDynamicStatePropertyComponent : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicatedIrisLifetimeConditionalsPropertyState")]
    public class UTestReplicatedIrisLifetimeConditionalsPropertyState : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicatedIrisObject")]
    public class UTestReplicatedIrisObject : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicatedIrisObjectWithObjectReference")]
    public class UTestReplicatedIrisObjectWithObjectReference : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicatedIrisObjectWithDynamicCondition")]
    public class UTestReplicatedIrisObjectWithDynamicCondition : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicatedSubObjectOrderObject")]
    public class UReplicatedSubObjectOrderObject : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicatedObjectWithRepNotifies")]
    public class UTestReplicatedObjectWithRepNotifies : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicatedIrisObjectWithNoReplicatedMembers")]
    public class UTestReplicatedIrisObjectWithNoReplicatedMembers : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicatedIrisPushModelObject")]
    public class UTestReplicatedIrisPushModelObject : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicatedTestObjectBridge")]
    public class UReplicatedTestObjectBridge : UObjectReplicationBridge
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
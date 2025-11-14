namespace AssetTool
{
    [JsonAsset("SmartObjectTestBehaviorDefinition")]
    public class USmartObjectTestBehaviorDefinition : USmartObjectBehaviorDefinition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectTestSubsystem")]
    public class USmartObjectTestSubsystem : USmartObjectSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectTestCollection")]
    public class ASmartObjectTestCollection : ASmartObjectPersistentCollection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
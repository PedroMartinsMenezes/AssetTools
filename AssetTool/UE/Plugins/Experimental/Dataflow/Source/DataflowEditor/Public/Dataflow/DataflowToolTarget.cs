namespace AssetTool
{
    [JsonAsset("DataflowReadOnlyToolTarget")]
    public class UDataflowReadOnlyToolTarget : UToolTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowToolTarget")]
    public class UDataflowToolTarget : UDataflowReadOnlyToolTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowReadOnlyToolTargetFactory")]
    public class UDataflowReadOnlyToolTargetFactory : UToolTargetFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowToolTargetFactory")]
    public class UDataflowToolTargetFactory : UToolTargetFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
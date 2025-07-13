namespace AssetTool
{
    [JsonAsset("DataflowComponentReadOnlyToolTarget")]
    public class UDataflowComponentReadOnlyToolTarget : UPrimitiveComponentToolTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowComponentToolTarget")]
    public class UDataflowComponentToolTarget : UDataflowComponentReadOnlyToolTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowComponentReadOnlyToolTargetFactory")]
    public class UDataflowComponentReadOnlyToolTargetFactory : UToolTargetFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowComponentToolTargetFactory")]
    public class UDataflowComponentToolTargetFactory : UToolTargetFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
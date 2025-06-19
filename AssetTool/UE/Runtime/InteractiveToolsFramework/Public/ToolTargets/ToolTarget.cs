namespace AssetTool
{
    [JsonAsset("ToolTarget")]
    public class UToolTarget : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ToolTargetFactory")]
    public class UToolTargetFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
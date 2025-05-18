namespace AssetTool
{
    [JsonAsset("ToolTarget")]
    public class UToolTarget : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ToolTargetFactory")]
    public class UToolTargetFactory : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
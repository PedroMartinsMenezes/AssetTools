namespace AssetTool
{
    [JsonAsset("OptimusNode_ResourceAccessorBase")]
    public class UOptimusNode_ResourceAccessorBase : UOptimusNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
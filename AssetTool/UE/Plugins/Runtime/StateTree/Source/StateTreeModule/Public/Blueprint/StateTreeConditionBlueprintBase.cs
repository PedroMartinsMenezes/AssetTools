namespace AssetTool
{
    [JsonAsset("StateTreeConditionBlueprintBase")]
    public class UStateTreeConditionBlueprintBase : UStateTreeNodeBlueprintBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("StateTreeConditionBlueprintBase")]
    public class UStateTreeConditionBlueprintBase : UStateTreeNodeBlueprintBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
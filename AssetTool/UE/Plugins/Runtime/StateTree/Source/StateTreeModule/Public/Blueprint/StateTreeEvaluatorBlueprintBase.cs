namespace AssetTool
{
    [JsonAsset("StateTreeEvaluatorBlueprintBase")]
    public class UStateTreeEvaluatorBlueprintBase : UStateTreeNodeBlueprintBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
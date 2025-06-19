namespace AssetTool
{
    [JsonAsset("StateTreeEvaluatorBlueprintBase")]
    public class UStateTreeEvaluatorBlueprintBase : UStateTreeNodeBlueprintBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
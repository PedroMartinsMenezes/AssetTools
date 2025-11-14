namespace AssetTool
{
    [JsonAsset("StateTreeEvaluatorBlueprintBase")]
    public class UStateTreeEvaluatorBlueprintBase : UStateTreeNodeBlueprintBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
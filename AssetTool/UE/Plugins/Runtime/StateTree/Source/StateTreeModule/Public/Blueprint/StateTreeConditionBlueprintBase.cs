namespace AssetTool
{
    [JsonAsset("StateTreeConditionBlueprintBase")]
    public class UStateTreeConditionBlueprintBase : UStateTreeNodeBlueprintBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
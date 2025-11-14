namespace AssetTool
{
    [JsonAsset("StateTreeConsiderationBlueprintBase")]
    public class UStateTreeConsiderationBlueprintBase : UStateTreeNodeBlueprintBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
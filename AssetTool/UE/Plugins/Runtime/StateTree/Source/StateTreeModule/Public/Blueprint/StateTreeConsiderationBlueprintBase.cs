namespace AssetTool
{
    [JsonAsset("StateTreeConsiderationBlueprintBase")]
    public class UStateTreeConsiderationBlueprintBase : UStateTreeNodeBlueprintBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
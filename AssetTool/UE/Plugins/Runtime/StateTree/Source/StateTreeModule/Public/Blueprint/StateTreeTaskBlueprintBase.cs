namespace AssetTool
{
    [JsonAsset("StateTreeTaskBlueprintBase")]
    public class UStateTreeTaskBlueprintBase : UStateTreeNodeBlueprintBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("StateTreeTaskBlueprintBase")]
    public class UStateTreeTaskBlueprintBase : UStateTreeNodeBlueprintBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
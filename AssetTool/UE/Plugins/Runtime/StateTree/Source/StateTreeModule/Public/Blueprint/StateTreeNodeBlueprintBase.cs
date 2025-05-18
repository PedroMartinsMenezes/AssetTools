namespace AssetTool
{
    [JsonAsset("StateTreeNodeBlueprintBase")]
    public class UStateTreeNodeBlueprintBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
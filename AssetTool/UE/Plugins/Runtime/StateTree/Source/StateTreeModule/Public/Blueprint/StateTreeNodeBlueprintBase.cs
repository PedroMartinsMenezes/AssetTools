namespace AssetTool
{
    [JsonAsset("StateTreeNodeBlueprintBase")]
    public class UStateTreeNodeBlueprintBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
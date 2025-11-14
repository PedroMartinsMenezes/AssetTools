namespace AssetTool
{
    [JsonAsset("StateTreeNodeBlueprintBase")]
    public class UStateTreeNodeBlueprintBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
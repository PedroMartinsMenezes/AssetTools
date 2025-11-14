namespace AssetTool
{
    [JsonAsset("StateTreeTaskBlueprintBase")]
    public class UStateTreeTaskBlueprintBase : UStateTreeNodeBlueprintBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
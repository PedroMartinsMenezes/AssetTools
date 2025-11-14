namespace AssetTool
{
    [JsonAsset("AvaTransitionTaskBlueprint")]
    public class UAvaTransitionTaskBlueprint : UStateTreeTaskBlueprintBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
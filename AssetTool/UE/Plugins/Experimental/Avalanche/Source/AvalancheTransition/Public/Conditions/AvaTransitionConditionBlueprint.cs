namespace AssetTool
{
    [JsonAsset("AvaTransitionConditionBlueprint")]
    public class UAvaTransitionConditionBlueprint : UStateTreeConditionBlueprintBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
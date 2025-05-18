namespace AssetTool
{
    [JsonAsset("AvaTransitionConditionBlueprint")]
    public class UAvaTransitionConditionBlueprint : UStateTreeConditionBlueprintBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
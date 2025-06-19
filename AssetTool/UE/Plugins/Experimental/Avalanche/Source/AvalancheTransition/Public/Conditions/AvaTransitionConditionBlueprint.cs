namespace AssetTool
{
    [JsonAsset("AvaTransitionConditionBlueprint")]
    public class UAvaTransitionConditionBlueprint : UStateTreeConditionBlueprintBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
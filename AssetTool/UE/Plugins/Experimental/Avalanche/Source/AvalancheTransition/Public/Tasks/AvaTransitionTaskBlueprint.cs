namespace AssetTool
{
    [JsonAsset("AvaTransitionTaskBlueprint")]
    public class UAvaTransitionTaskBlueprint : UStateTreeTaskBlueprintBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
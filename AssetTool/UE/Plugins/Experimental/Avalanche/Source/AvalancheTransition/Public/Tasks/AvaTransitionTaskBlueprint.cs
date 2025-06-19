namespace AssetTool
{
    [JsonAsset("AvaTransitionTaskBlueprint")]
    public class UAvaTransitionTaskBlueprint : UStateTreeTaskBlueprintBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
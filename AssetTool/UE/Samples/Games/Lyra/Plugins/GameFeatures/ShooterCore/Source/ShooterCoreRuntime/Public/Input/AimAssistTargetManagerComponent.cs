namespace AssetTool
{
    [JsonAsset("AimAssistTargetManagerComponent")]
    public class UAimAssistTargetManagerComponent : UGameStateComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
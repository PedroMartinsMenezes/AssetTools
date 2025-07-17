namespace AssetTool
{
    [JsonAsset("AimAssistTargetComponent")]
    public class UAimAssistTargetComponent : UCapsuleComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
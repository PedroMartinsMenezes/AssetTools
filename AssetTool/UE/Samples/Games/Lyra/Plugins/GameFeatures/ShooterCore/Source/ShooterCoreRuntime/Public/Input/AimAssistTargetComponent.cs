namespace AssetTool
{
    [JsonAsset("AimAssistTargetComponent")]
    public class UAimAssistTargetComponent : UCapsuleComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("AimAssistInputModifier")]
    public class UAimAssistInputModifier : UInputModifier
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
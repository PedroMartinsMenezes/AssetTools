namespace AssetTool
{
    [JsonAsset("AimAssistInputModifier")]
    public class UAimAssistInputModifier : UInputModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("AnimationModifierSettings")]
    public class UAnimationModifierSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("AnimationModifierSettings")]
    public class UAnimationModifierSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
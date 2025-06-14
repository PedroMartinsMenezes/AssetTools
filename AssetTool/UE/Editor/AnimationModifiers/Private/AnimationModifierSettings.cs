namespace AssetTool
{
    [JsonAsset("AnimationModifierSettings")]
    public class UAnimationModifierSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
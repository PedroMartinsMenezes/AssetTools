namespace AssetTool
{
    [JsonAsset("AnimationModifier")]
    public class UAnimationModifier : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
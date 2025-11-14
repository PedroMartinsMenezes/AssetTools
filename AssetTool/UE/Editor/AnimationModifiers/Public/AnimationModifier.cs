namespace AssetTool
{
    [JsonAsset("AnimationModifier")]
    public class UAnimationModifier : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
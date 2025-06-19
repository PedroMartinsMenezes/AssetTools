namespace AssetTool
{
    [JsonAsset("AnimationCustomTransitionSchema")]
    public class UAnimationCustomTransitionSchema : UAnimationGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
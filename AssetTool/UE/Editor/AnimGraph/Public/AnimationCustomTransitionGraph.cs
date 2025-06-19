namespace AssetTool
{
    [JsonAsset("AnimationCustomTransitionGraph")]
    public class UAnimationCustomTransitionGraph : UAnimationGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
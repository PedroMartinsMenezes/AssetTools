namespace AssetTool
{
    [JsonAsset("AnimationTransitionGraph")]
    public class UAnimationTransitionGraph : UAnimationGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
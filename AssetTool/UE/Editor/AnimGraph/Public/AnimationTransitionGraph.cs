namespace AssetTool
{
    [JsonAsset("AnimationTransitionGraph")]
    public class UAnimationTransitionGraph : UAnimationGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("AnimationTransitionGraph")]
    public class UAnimationTransitionGraph : UAnimationGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("AnimationCustomTransitionGraph")]
    public class UAnimationCustomTransitionGraph : UAnimationGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
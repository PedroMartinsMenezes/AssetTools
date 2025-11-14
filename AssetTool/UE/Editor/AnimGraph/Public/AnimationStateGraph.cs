namespace AssetTool
{
    [JsonAsset("AnimationStateGraph")]
    public class UAnimationStateGraph : UAnimationGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
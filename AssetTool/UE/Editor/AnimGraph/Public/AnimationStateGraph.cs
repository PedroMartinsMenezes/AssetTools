namespace AssetTool
{
    [JsonAsset("AnimationStateGraph")]
    public class UAnimationStateGraph : UAnimationGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
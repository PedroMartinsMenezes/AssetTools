namespace AssetTool
{
    [JsonAsset("AnimationGraph")]
    public class UAnimationGraph : UEdGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
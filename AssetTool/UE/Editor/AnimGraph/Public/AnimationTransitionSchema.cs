namespace AssetTool
{
    [JsonAsset("AnimationTransitionSchema")]
    public class UAnimationTransitionSchema : UEdGraphSchema_K2
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
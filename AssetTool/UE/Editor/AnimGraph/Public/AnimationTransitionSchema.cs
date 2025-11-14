namespace AssetTool
{
    [JsonAsset("AnimationTransitionSchema")]
    public class UAnimationTransitionSchema : UEdGraphSchema_K2
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
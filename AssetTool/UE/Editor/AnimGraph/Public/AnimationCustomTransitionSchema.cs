namespace AssetTool
{
    [JsonAsset("AnimationCustomTransitionSchema")]
    public class UAnimationCustomTransitionSchema : UAnimationGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
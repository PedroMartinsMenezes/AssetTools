namespace AssetTool
{
    [JsonAsset("AnimationStateGraphSchema")]
    public class UAnimationStateGraphSchema : UAnimationGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
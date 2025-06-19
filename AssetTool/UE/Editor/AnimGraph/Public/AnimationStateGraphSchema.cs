namespace AssetTool
{
    [JsonAsset("AnimationStateGraphSchema")]
    public class UAnimationStateGraphSchema : UAnimationGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
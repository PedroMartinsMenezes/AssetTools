namespace AssetTool
{
    [JsonAsset("AnimationStateGraphSchema")]
    public class UAnimationStateGraphSchema : UAnimationGraphSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
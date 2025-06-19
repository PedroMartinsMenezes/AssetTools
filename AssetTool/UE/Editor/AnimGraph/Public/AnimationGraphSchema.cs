namespace AssetTool
{
    [JsonAsset("AnimationGraphSchema")]
    public class UAnimationGraphSchema : UEdGraphSchema_K2
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("AnimationConduitGraphSchema")]
    public class UAnimationConduitGraphSchema : UEdGraphSchema_K2
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
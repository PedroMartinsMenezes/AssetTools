namespace AssetTool
{
    [JsonAsset("AnimationGraphSchema")]
    public class UAnimationGraphSchema : UEdGraphSchema_K2
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
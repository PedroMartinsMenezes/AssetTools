namespace AssetTool
{
    [JsonAsset("RichTextBlock")]
    public class URichTextBlock : UTextLayoutWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
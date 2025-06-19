namespace AssetTool
{
    [JsonAsset("CommonRichTextBlock")]
    public class UCommonRichTextBlock : URichTextBlock
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
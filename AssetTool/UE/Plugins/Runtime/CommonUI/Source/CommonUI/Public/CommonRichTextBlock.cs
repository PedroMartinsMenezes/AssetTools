namespace AssetTool
{
    [JsonAsset("CommonRichTextBlock")]
    public class UCommonRichTextBlock : URichTextBlock
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
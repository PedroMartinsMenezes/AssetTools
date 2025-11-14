namespace AssetTool
{
    [JsonAsset("CommonRichTextBlock")]
    public class UCommonRichTextBlock : URichTextBlock
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
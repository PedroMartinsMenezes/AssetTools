namespace AssetTool
{
    [JsonAsset("RichTextBlock")]
    public class URichTextBlock : UTextLayoutWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
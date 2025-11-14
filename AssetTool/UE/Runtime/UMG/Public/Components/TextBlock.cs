namespace AssetTool
{
    [JsonAsset("TextBlock")]
    public class UTextBlock : UTextLayoutWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
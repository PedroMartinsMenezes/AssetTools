namespace AssetTool
{
    [JsonAsset("WidgetBinding")]
    public class UWidgetBinding : UPropertyBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
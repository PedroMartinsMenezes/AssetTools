namespace AssetTool
{
    [JsonAsset("WidgetBinding")]
    public class UWidgetBinding : UPropertyBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
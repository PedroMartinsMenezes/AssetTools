namespace AssetTool
{
    [JsonAsset("Widget")]
    public class UWidget : UVisual
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
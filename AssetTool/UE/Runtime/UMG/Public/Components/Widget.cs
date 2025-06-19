namespace AssetTool
{
    [JsonAsset("Widget")]
    public class UWidget : UVisual
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
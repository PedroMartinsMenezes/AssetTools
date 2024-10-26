namespace AssetTool
{
    [JsonAsset("Widget")]
    public class UWidget : UVisual
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
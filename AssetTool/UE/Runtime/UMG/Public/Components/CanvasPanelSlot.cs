namespace AssetTool
{
    [JsonAsset("CanvasPanelSlot")]
    public class UCanvasPanelSlot : UPanelSlot
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
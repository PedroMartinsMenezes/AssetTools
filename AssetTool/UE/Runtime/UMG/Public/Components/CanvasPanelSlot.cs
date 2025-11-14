namespace AssetTool
{
    [JsonAsset("CanvasPanelSlot")]
    public class UCanvasPanelSlot : UPanelSlot
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
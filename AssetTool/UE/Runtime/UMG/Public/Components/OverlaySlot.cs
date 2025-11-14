namespace AssetTool
{
    [JsonAsset("OverlaySlot")]
    public class UOverlaySlot : UPanelSlot
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
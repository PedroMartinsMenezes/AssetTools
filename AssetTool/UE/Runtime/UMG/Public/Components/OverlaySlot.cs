namespace AssetTool
{
    [JsonAsset("OverlaySlot")]
    public class UOverlaySlot : UPanelSlot
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
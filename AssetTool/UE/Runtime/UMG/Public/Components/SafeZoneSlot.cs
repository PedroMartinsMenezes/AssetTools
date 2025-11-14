namespace AssetTool
{
    [JsonAsset("SafeZoneSlot")]
    public class USafeZoneSlot : UPanelSlot
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
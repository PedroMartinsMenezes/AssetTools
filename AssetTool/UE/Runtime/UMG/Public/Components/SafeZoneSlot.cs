namespace AssetTool
{
    [JsonAsset("SafeZoneSlot")]
    public class USafeZoneSlot : UPanelSlot
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
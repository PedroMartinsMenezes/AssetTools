namespace AssetTool
{
    [JsonAsset("SafeZoneSlot")]
    public class USafeZoneSlot : UPanelSlot
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
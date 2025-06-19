namespace AssetTool
{
    [JsonAsset("GridSlot")]
    public class UGridSlot : UPanelSlot
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
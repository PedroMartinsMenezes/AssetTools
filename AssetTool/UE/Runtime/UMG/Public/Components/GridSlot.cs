namespace AssetTool
{
    [JsonAsset("GridSlot")]
    public class UGridSlot : UPanelSlot
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
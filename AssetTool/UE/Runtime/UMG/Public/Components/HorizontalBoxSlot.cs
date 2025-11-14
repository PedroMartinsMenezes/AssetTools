namespace AssetTool
{
    [JsonAsset("HorizontalBoxSlot")]
    public class UHorizontalBoxSlot : UPanelSlot
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
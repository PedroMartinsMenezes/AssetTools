namespace AssetTool
{
    [JsonAsset("BorderSlot")]
    public class UBorderSlot : UPanelSlot
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
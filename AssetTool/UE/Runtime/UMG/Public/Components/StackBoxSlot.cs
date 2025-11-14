namespace AssetTool
{
    [JsonAsset("StackBoxSlot")]
    public class UStackBoxSlot : UPanelSlot
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
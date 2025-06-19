namespace AssetTool
{
    [JsonAsset("HorizontalBoxSlot")]
    public class UHorizontalBoxSlot : UPanelSlot
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("BorderSlot")]
    public class UBorderSlot : UPanelSlot
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
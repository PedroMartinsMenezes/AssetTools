namespace AssetTool
{
    [JsonAsset("StackBoxSlot")]
    public class UStackBoxSlot : UPanelSlot
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
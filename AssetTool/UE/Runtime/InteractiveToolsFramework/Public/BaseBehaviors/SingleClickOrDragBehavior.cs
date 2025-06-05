namespace AssetTool
{
    [JsonAsset("SingleClickOrDragInputBehavior")]
    public class USingleClickOrDragInputBehavior : UAnyButtonInputBehavior
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
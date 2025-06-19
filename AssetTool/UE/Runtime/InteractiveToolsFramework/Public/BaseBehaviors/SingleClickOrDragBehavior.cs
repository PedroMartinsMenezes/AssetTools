namespace AssetTool
{
    [JsonAsset("SingleClickOrDragInputBehavior")]
    public class USingleClickOrDragInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("SingleClickOrDragInputBehavior")]
    public class USingleClickOrDragInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
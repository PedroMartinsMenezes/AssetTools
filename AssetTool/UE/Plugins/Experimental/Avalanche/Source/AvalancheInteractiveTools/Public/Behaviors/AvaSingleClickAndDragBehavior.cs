namespace AssetTool
{
    [JsonAsset("AvaSingleClickAndDragBehavior")]
    public class UAvaSingleClickAndDragBehavior : UAnyButtonInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
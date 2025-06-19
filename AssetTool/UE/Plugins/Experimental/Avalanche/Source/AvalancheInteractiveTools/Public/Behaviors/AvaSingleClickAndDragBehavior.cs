namespace AssetTool
{
    [JsonAsset("AvaSingleClickAndDragBehavior")]
    public class UAvaSingleClickAndDragBehavior : UAnyButtonInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
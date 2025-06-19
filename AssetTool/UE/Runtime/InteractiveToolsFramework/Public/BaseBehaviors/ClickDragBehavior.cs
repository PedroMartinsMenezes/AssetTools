namespace AssetTool
{
    [JsonAsset("ClickDragInputBehavior")]
    public class UClickDragInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalClickDragInputBehavior")]
    public class ULocalClickDragInputBehavior : UClickDragInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
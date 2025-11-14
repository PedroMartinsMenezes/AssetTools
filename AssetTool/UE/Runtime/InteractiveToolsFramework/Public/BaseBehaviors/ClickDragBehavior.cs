namespace AssetTool
{
    [JsonAsset("ClickDragInputBehavior")]
    public class UClickDragInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalClickDragInputBehavior")]
    public class ULocalClickDragInputBehavior : UClickDragInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}